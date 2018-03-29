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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.WAFRegional.Model;
using Amazon.WAFRegional.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WAFRegional
{
    /// <summary>
    /// Implementation for accessing WAFRegional
    ///
    /// This is the <i>AWS WAF Regional API Reference</i> for using AWS WAF with Elastic Load
    /// Balancing (ELB) Application Load Balancers. The AWS WAF actions and data types listed
    /// in the reference are available for protecting Application Load Balancers. You can
    /// use these actions and data types by means of the endpoints listed in <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#waf_region">AWS
    /// Regions and Endpoints</a>. This guide is for developers who need detailed information
    /// about the AWS WAF API actions, data types, and errors. For detailed information about
    /// AWS WAF features and an overview of how to use the AWS WAF API, see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS
    /// WAF Developer Guide</a>.
    /// </summary>
    public partial class AmazonWAFRegionalClient : AmazonServiceClient, IAmazonWAFRegional
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWAFRegionalConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWAFRegionalConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        /// <summary>
        /// Associates a web ACL with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
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
        public virtual AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request)
        {
            var marshaller = AssociateWebACLRequestMarshaller.Instance;
            var unmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return Invoke<AssociateWebACLRequest,AssociateWebACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual Task<AssociateWebACLResponse> AssociateWebACLAsync(AssociateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateWebACLRequestMarshaller.Instance;
            var unmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWebACLRequest,AssociateWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateByteMatchSet


        /// <summary>
        /// Creates a <code>ByteMatchSet</code>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <code>User-Agent</code> header or the query string. For example, you can create
        /// a <code>ByteMatchSet</code> that matches any requests with <code>User-Agent</code>
        /// headers that contain the string <code>BadBot</code>. You can then configure AWS WAF
        /// to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>ByteMatchSet</a>. You can't change <code>Name</code> after you create a <code>ByteMatchSet</code>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        public virtual CreateByteMatchSetResponse CreateByteMatchSet(string name, string changeToken)
        {
            var request = new CreateByteMatchSetRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            return CreateByteMatchSet(request);
        }


        /// <summary>
        /// Creates a <code>ByteMatchSet</code>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <code>User-Agent</code> header or the query string. For example, you can create
        /// a <code>ByteMatchSet</code> that matches any requests with <code>User-Agent</code>
        /// headers that contain the string <code>BadBot</code>. You can then configure AWS WAF
        /// to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        public virtual CreateByteMatchSetResponse CreateByteMatchSet(CreateByteMatchSetRequest request)
        {
            var marshaller = CreateByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateByteMatchSetRequest,CreateByteMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a <code>ByteMatchSet</code>. You then use <a>UpdateByteMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <code>User-Agent</code> header or the query string. For example, you can create
        /// a <code>ByteMatchSet</code> that matches any requests with <code>User-Agent</code>
        /// headers that contain the string <code>BadBot</code>. You can then configure AWS WAF
        /// to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>ByteMatchSet</a>. You can't change <code>Name</code> after you create a <code>ByteMatchSet</code>.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
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
        /// Initiates the asynchronous execution of the CreateByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateByteMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateByteMatchSet">REST API Reference for CreateByteMatchSet Operation</seealso>
        public virtual Task<CreateByteMatchSetResponse> CreateByteMatchSetAsync(CreateByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateByteMatchSetRequest,CreateByteMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGeoMatchSet


        /// <summary>
        /// Creates an <a>GeoMatchSet</a>, which you use to specify which web requests you want
        /// to allow or block based on the country that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more countries and you want to block
        /// the requests, you can create an <code>GeoMatchSet</code> that contains those countries
        /// and then configure AWS WAF to block the requests. 
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>GeoMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateGeoMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateGeoMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateGeoMatchSetSet</code> request to specify the countries that
        /// you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeoMatchSet service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateGeoMatchSet">REST API Reference for CreateGeoMatchSet Operation</seealso>
        public virtual CreateGeoMatchSetResponse CreateGeoMatchSet(CreateGeoMatchSetRequest request)
        {
            var marshaller = CreateGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateGeoMatchSetRequest,CreateGeoMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGeoMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGeoMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateGeoMatchSet">REST API Reference for CreateGeoMatchSet Operation</seealso>
        public virtual Task<CreateGeoMatchSetResponse> CreateGeoMatchSetAsync(CreateGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGeoMatchSetRequest,CreateGeoMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests you want to allow
        /// or block based on the IP addresses that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more individual IP addresses or
        /// one or more ranges of IP addresses and you want to block the requests, you can create
        /// an <code>IPSet</code> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>IPSet</a>. You can't change <code>Name</code> after you create the <code>IPSet</code>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse CreateIPSet(string name, string changeToken)
        {
            var request = new CreateIPSetRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            return CreateIPSet(request);
        }


        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests you want to allow
        /// or block based on the IP addresses that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more individual IP addresses or
        /// one or more ranges of IP addresses and you want to block the requests, you can create
        /// an <code>IPSet</code> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var marshaller = CreateIPSetRequestMarshaller.Instance;
            var unmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetRequest,CreateIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to specify which web requests you want to allow
        /// or block based on the IP addresses that the requests originate from. For example,
        /// if you're receiving a lot of requests from one or more individual IP addresses or
        /// one or more ranges of IP addresses and you want to block the requests, you can create
        /// an <code>IPSet</code> that contains those IP addresses and then configure AWS WAF
        /// to block the requests. 
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>IPSet</a>. You can't change <code>Name</code> after you create the <code>IPSet</code>.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
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
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateIPSetRequestMarshaller.Instance;
            var unmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIPSetRequest,CreateIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRateBasedRule


        /// <summary>
        /// Creates a <a>RateBasedRule</a>. The <code>RateBasedRule</code> contains a <code>RateLimit</code>,
        /// which specifies the maximum number of requests that AWS WAF allows from a specified
        /// IP address in a five-minute period. The <code>RateBasedRule</code> also contains the
        /// <code>IPSet</code> objects, <code>ByteMatchSet</code> objects, and other predicates
        /// that identify the requests that you want to count or block if these requests exceed
        /// the <code>RateLimit</code>.
        /// 
        ///  
        /// <para>
        /// If you add more than one predicate to a <code>RateBasedRule</code>, a request not
        /// only must exceed the <code>RateLimit</code>, but it also must match all the specifications
        /// to be counted or blocked. For example, suppose you add the following to a <code>RateBasedRule</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <code>RateLimit</code> of 15,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <code>RateBasedRule</code> to a <code>WebACL</code> and specify that
        /// you want to block requests that meet the conditions in the rule. For a request to
        /// be blocked, it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
        /// header in the request must contain the value <code>BadBot</code>. Further, requests
        /// that match these two conditions must be received at a rate of more than 15,000 requests
        /// every five minutes. If both conditions are met and the rate is exceeded, AWS WAF blocks
        /// the requests. If the rate drops below 15,000 for a five-minute period, AWS WAF no
        /// longer blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <code>RateBasedRule</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> with <code>FieldToMatch</code> of <code>URI</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>PositionalConstraint</code> of <code>STARTS_WITH</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>TargetString</code> of <code>login</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <code>RateLimit</code> of 15,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <code>RateBasedRule</code> to a <code>WebACL</code>, you could limit
        /// requests to your login page without affecting the rest of your site.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>RateBasedRule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the rule. For more information,
        /// see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRateBasedRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRateBasedRule</code> request to specify the predicates that
        /// you want to include in the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>RateBasedRule</code>.
        /// For more information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRateBasedRule service method.</param>
        /// 
        /// <returns>The response from the CreateRateBasedRule service method, as returned by WAFRegional.</returns>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRateBasedRule">REST API Reference for CreateRateBasedRule Operation</seealso>
        public virtual CreateRateBasedRuleResponse CreateRateBasedRule(CreateRateBasedRuleRequest request)
        {
            var marshaller = CreateRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = CreateRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRateBasedRuleRequest,CreateRateBasedRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRateBasedRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRateBasedRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRateBasedRule">REST API Reference for CreateRateBasedRule Operation</seealso>
        public virtual Task<CreateRateBasedRuleResponse> CreateRateBasedRuleAsync(CreateRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = CreateRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRateBasedRuleRequest,CreateRateBasedRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRegexMatchSet


        /// <summary>
        /// Creates a <a>RegexMatchSet</a>. You then use <a>UpdateRegexMatchSet</a> to identify
        /// the part of a web request that you want AWS WAF to inspect, such as the values of
        /// the <code>User-Agent</code> header or the query string. For example, you can create
        /// a <code>RegexMatchSet</code> that contains a <code>RegexMatchTuple</code> that looks
        /// for any requests with <code>User-Agent</code> headers that match a <code>RegexPatternSet</code>
        /// with pattern <code>B[a@]dB[o0]t</code>. You can then configure AWS WAF to reject those
        /// requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>RegexMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRegexMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRegexMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateRegexMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexMatchSet</a> request to specify the part of the request that
        /// you want AWS WAF to inspect (for example, the header or the URI) and the value, using
        /// a <code>RegexPatternSet</code>, that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexMatchSet service method.</param>
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
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRegexMatchSet">REST API Reference for CreateRegexMatchSet Operation</seealso>
        public virtual CreateRegexMatchSetResponse CreateRegexMatchSet(CreateRegexMatchSetRequest request)
        {
            var marshaller = CreateRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateRegexMatchSetRequest,CreateRegexMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRegexMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRegexMatchSet">REST API Reference for CreateRegexMatchSet Operation</seealso>
        public virtual Task<CreateRegexMatchSetResponse> CreateRegexMatchSetAsync(CreateRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegexMatchSetRequest,CreateRegexMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRegexPatternSet


        /// <summary>
        /// Creates a <code>RegexPatternSet</code>. You then use <a>UpdateRegexPatternSet</a>
        /// to specify the regular expression (regex) pattern that you want AWS WAF to search
        /// for, such as <code>B[a@]dB[o0]t</code>. You can then configure AWS WAF to reject those
        /// requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>RegexPatternSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRegexPatternSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRegexPatternSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateRegexPatternSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateRegexPatternSet</a> request to specify the string that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
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
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request)
        {
            var marshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<CreateRegexPatternSetRequest,CreateRegexPatternSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual Task<CreateRegexPatternSetResponse> CreateRegexPatternSetAsync(CreateRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegexPatternSetRequest,CreateRegexPatternSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a <code>Rule</code>, which contains the <code>IPSet</code> objects, <code>ByteMatchSet</code>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <code>Rule</code>, a request must match all of
        /// the specifications to be allowed or blocked. For example, suppose you add the following
        /// to a <code>Rule</code>:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to blocks requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
        /// header in the request must contain the value <code>BadBot</code>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// For more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to specify the predicates that you want
        /// to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>Rule</a>. You can't change the name of a <code>Rule</code> after you create it.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="metricName">A friendly name or description for the metrics for this <code>Rule</code>. The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace. You can't change the name of the metric after you create the <code>Rule</code>.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(string name, string changeToken, string metricName)
        {
            var request = new CreateRuleRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            request.MetricName = metricName;
            return CreateRule(request);
        }


        /// <summary>
        /// Creates a <code>Rule</code>, which contains the <code>IPSet</code> objects, <code>ByteMatchSet</code>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <code>Rule</code>, a request must match all of
        /// the specifications to be allowed or blocked. For example, suppose you add the following
        /// to a <code>Rule</code>:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to blocks requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
        /// header in the request must contain the value <code>BadBot</code>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// For more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to specify the predicates that you want
        /// to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var marshaller = CreateRuleRequestMarshaller.Instance;
            var unmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleRequest,CreateRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a <code>Rule</code>, which contains the <code>IPSet</code> objects, <code>ByteMatchSet</code>
        /// objects, and other predicates that identify the requests that you want to block. If
        /// you add more than one predicate to a <code>Rule</code>, a request must match all of
        /// the specifications to be allowed or blocked. For example, suppose you add the following
        /// to a <code>Rule</code>:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to blocks requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
        /// header in the request must contain the value <code>BadBot</code>.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// For more information, see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to specify the predicates that you want
        /// to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. For more
        /// information, see <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description of the <a>Rule</a>. You can't change the name of a <code>Rule</code> after you create it.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
        /// <param name="metricName">A friendly name or description for the metrics for this <code>Rule</code>. The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain whitespace. You can't change the name of the metric after you create the <code>Rule</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by WAFRegional.</returns>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
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
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRuleRequestMarshaller.Instance;
            var unmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleRequest,CreateRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRuleGroup


        /// <summary>
        /// Creates a <code>RuleGroup</code>. A rule group is a collection of predefined rules
        /// that you add to a web ACL. You use <a>UpdateRuleGroup</a> to add rules to the rule
        /// group.
        /// 
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFDisallowedNameException">
        /// The name specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var marshaller = CreateRuleGroupRequestMarshaller.Instance;
            var unmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupRequest,CreateRuleGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRuleGroupRequestMarshaller.Instance;
            var unmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleGroupRequest,CreateRuleGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSizeConstraintSet


        /// <summary>
        /// Creates a <code>SizeConstraintSet</code>. You then use <a>UpdateSizeConstraintSet</a>
        /// to identify the part of a web request that you want AWS WAF to check for length, such
        /// as the length of the <code>User-Agent</code> header or the length of the query string.
        /// For example, you can create a <code>SizeConstraintSet</code> that matches any requests
        /// that have a query string that is longer than 100 bytes. You can then configure AWS
        /// WAF to reject those requests.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SizeConstraintSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateSizeConstraintSet</code> request.
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSizeConstraintSet">REST API Reference for CreateSizeConstraintSet Operation</seealso>
        public virtual CreateSizeConstraintSetResponse CreateSizeConstraintSet(CreateSizeConstraintSetRequest request)
        {
            var marshaller = CreateSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = CreateSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<CreateSizeConstraintSetRequest,CreateSizeConstraintSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSizeConstraintSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSizeConstraintSet">REST API Reference for CreateSizeConstraintSet Operation</seealso>
        public virtual Task<CreateSizeConstraintSetResponse> CreateSizeConstraintSetAsync(CreateSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = CreateSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSizeConstraintSetRequest,CreateSizeConstraintSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSqlInjectionMatchSet


        /// <summary>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description for the <a>SqlInjectionMatchSet</a> that you're creating. You can't change <code>Name</code> after you create the <code>SqlInjectionMatchSet</code>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        public virtual CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(string name, string changeToken)
        {
            var request = new CreateSqlInjectionMatchSetRequest();
            request.Name = name;
            request.ChangeToken = changeToken;
            return CreateSqlInjectionMatchSet(request);
        }


        /// <summary>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        public virtual CreateSqlInjectionMatchSetResponse CreateSqlInjectionMatchSet(CreateSqlInjectionMatchSetRequest request)
        {
            var marshaller = CreateSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateSqlInjectionMatchSetRequest,CreateSqlInjectionMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a <a>SqlInjectionMatchSet</a>, which you use to allow, block, or count requests
        /// that contain snippets of SQL code in a specified part of web requests. AWS WAF searches
        /// for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="name">A friendly name or description for the <a>SqlInjectionMatchSet</a> that you're creating. You can't change <code>Name</code> after you create the <code>SqlInjectionMatchSet</code>.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
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
        /// Initiates the asynchronous execution of the CreateSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSqlInjectionMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateSqlInjectionMatchSet">REST API Reference for CreateSqlInjectionMatchSet Operation</seealso>
        public virtual Task<CreateSqlInjectionMatchSetResponse> CreateSqlInjectionMatchSetAsync(CreateSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSqlInjectionMatchSetRequest,CreateSqlInjectionMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateWebACL


        /// <summary>
        /// Creates a <code>WebACL</code>, which contains the <code>Rules</code> that identify
        /// the CloudFront web requests that you want to allow, block, or count. AWS WAF evaluates
        /// <code>Rules</code> in order based on the value of <code>Priority</code> for each <code>Rule</code>.
        /// 
        ///  
        /// <para>
        /// You also specify a default action, either <code>ALLOW</code> or <code>BLOCK</code>.
        /// If a web request doesn't match any of the <code>Rules</code> in a <code>WebACL</code>,
        /// AWS WAF responds to the request with the default action. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <code>ByteMatchSet</code> objects and other predicates that
        /// you want to include in <code>Rules</code>. For more information, see <a>CreateByteMatchSet</a>,
        /// <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>, <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>,
        /// and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <code>Rules</code> that you want to include in the <code>WebACL</code>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <a>UpdateWebACL</a> request to specify the <code>Rules</code> that you want
        /// to include in the <code>WebACL</code>, to specify the default action, and to associate
        /// the <code>WebACL</code> with a CloudFront distribution.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API, see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS
        /// WAF Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFRegional.</returns>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual CreateWebACLResponse CreateWebACL(CreateWebACLRequest request)
        {
            var marshaller = CreateWebACLRequestMarshaller.Instance;
            var unmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return Invoke<CreateWebACLRequest,CreateWebACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual Task<CreateWebACLResponse> CreateWebACLAsync(CreateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateWebACLRequestMarshaller.Instance;
            var unmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWebACLRequest,CreateWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateXssMatchSet


        /// <summary>
        /// Creates an <a>XssMatchSet</a>, which you use to allow, block, or count requests that
        /// contain cross-site scripting attacks in the specified part of web requests. AWS WAF
        /// searches for character sequences that are likely to be malicious strings.
        /// 
        ///  
        /// <para>
        /// To create and configure an <code>XssMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>CreateXssMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>CreateXssMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateXssMatchSet">REST API Reference for CreateXssMatchSet Operation</seealso>
        public virtual CreateXssMatchSetResponse CreateXssMatchSet(CreateXssMatchSetRequest request)
        {
            var marshaller = CreateXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<CreateXssMatchSetRequest,CreateXssMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateXssMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/CreateXssMatchSet">REST API Reference for CreateXssMatchSet Operation</seealso>
        public virtual Task<CreateXssMatchSetResponse> CreateXssMatchSetAsync(CreateXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = CreateXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateXssMatchSetRequest,CreateXssMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteByteMatchSet


        /// <summary>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <code>ByteMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>ByteMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>ByteMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to delete. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        public virtual DeleteByteMatchSetResponse DeleteByteMatchSet(string byteMatchSetId, string changeToken)
        {
            var request = new DeleteByteMatchSetRequest();
            request.ByteMatchSetId = byteMatchSetId;
            request.ChangeToken = changeToken;
            return DeleteByteMatchSet(request);
        }


        /// <summary>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <code>ByteMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>ByteMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>ByteMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        public virtual DeleteByteMatchSetResponse DeleteByteMatchSet(DeleteByteMatchSetRequest request)
        {
            var marshaller = DeleteByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteByteMatchSetRequest,DeleteByteMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <code>ByteMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>ByteMatchTuple</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>ByteMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>ByteMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteByteMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to delete. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
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
        /// Initiates the asynchronous execution of the DeleteByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteByteMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteByteMatchSet">REST API Reference for DeleteByteMatchSet Operation</seealso>
        public virtual Task<DeleteByteMatchSetResponse> DeleteByteMatchSetAsync(DeleteByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteByteMatchSetRequest,DeleteByteMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGeoMatchSet


        /// <summary>
        /// Permanently deletes a <a>GeoMatchSet</a>. You can't delete a <code>GeoMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any countries.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>GeoMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>GeoMatchSet</code> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>GeoMatchSet</code> to remove any countries. For more information,
        /// see <a>UpdateGeoMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteGeoMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteGeoMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeoMatchSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteGeoMatchSet">REST API Reference for DeleteGeoMatchSet Operation</seealso>
        public virtual DeleteGeoMatchSetResponse DeleteGeoMatchSet(DeleteGeoMatchSetRequest request)
        {
            var marshaller = DeleteGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteGeoMatchSetRequest,DeleteGeoMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGeoMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeoMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteGeoMatchSet">REST API Reference for DeleteGeoMatchSet Operation</seealso>
        public virtual Task<DeleteGeoMatchSetResponse> DeleteGeoMatchSetAsync(DeleteGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGeoMatchSetRequest,DeleteGeoMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <code>IPSet</code> if it's
        /// still used in any <code>Rules</code> or if it still includes any IP addresses.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>IPSet</code> from a <code>Rule</code>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>IPSet</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>IPSet</code> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to delete. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse DeleteIPSet(string ipSetId, string changeToken)
        {
            var request = new DeleteIPSetRequest();
            request.IPSetId = ipSetId;
            request.ChangeToken = changeToken;
            return DeleteIPSet(request);
        }


        /// <summary>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <code>IPSet</code> if it's
        /// still used in any <code>Rules</code> or if it still includes any IP addresses.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>IPSet</code> from a <code>Rule</code>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>IPSet</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>IPSet</code> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var marshaller = DeleteIPSetRequestMarshaller.Instance;
            var unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetRequest,DeleteIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Permanently deletes an <a>IPSet</a>. You can't delete an <code>IPSet</code> if it's
        /// still used in any <code>Rules</code> or if it still includes any IP addresses.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>IPSet</code> from a <code>Rule</code>, use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>IPSet</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>IPSet</code> to remove IP address ranges, if any. For more information,
        /// see <a>UpdateIPSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteIPSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to delete. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
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
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIPSetRequestMarshaller.Instance;
            var unmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIPSetRequest,DeleteIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePermissionPolicy


        /// <summary>
        /// Permanently deletes an IAM policy from the specified RuleGroup.
        /// 
        ///  
        /// <para>
        /// The user making the request must be the owner of the RuleGroup.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
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
        public virtual DeletePermissionPolicyResponse DeletePermissionPolicy(DeletePermissionPolicyRequest request)
        {
            var marshaller = DeletePermissionPolicyRequestMarshaller.Instance;
            var unmarshaller = DeletePermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionPolicyRequest,DeletePermissionPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        public virtual Task<DeletePermissionPolicyResponse> DeletePermissionPolicyAsync(DeletePermissionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePermissionPolicyRequestMarshaller.Instance;
            var unmarshaller = DeletePermissionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePermissionPolicyRequest,DeletePermissionPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRateBasedRule


        /// <summary>
        /// Permanently deletes a <a>RateBasedRule</a>. You can't delete a rule if it's still
        /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
        /// as <code>ByteMatchSet</code> objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a rule from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>RateBasedRule</code> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>RateBasedRule</code> to remove predicates, if any. For more information,
        /// see <a>UpdateRateBasedRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRateBasedRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRateBasedRule</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRateBasedRule service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRateBasedRule">REST API Reference for DeleteRateBasedRule Operation</seealso>
        public virtual DeleteRateBasedRuleResponse DeleteRateBasedRule(DeleteRateBasedRuleRequest request)
        {
            var marshaller = DeleteRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRateBasedRuleRequest,DeleteRateBasedRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRateBasedRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRateBasedRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRateBasedRule">REST API Reference for DeleteRateBasedRule Operation</seealso>
        public virtual Task<DeleteRateBasedRuleResponse> DeleteRateBasedRuleAsync(DeleteRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRateBasedRuleRequest,DeleteRateBasedRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegexMatchSet


        /// <summary>
        /// Permanently deletes a <a>RegexMatchSet</a>. You can't delete a <code>RegexMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <code>RegexMatchTuples</code>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>RegexMatchSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>RegexMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>RegexMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRegexMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRegexMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexMatchSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRegexMatchSet">REST API Reference for DeleteRegexMatchSet Operation</seealso>
        public virtual DeleteRegexMatchSetResponse DeleteRegexMatchSet(DeleteRegexMatchSetRequest request)
        {
            var marshaller = DeleteRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRegexMatchSetRequest,DeleteRegexMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegexMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRegexMatchSet">REST API Reference for DeleteRegexMatchSet Operation</seealso>
        public virtual Task<DeleteRegexMatchSetResponse> DeleteRegexMatchSetAsync(DeleteRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegexMatchSetRequest,DeleteRegexMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRegexPatternSet


        /// <summary>
        /// Permanently deletes a <a>RegexPatternSet</a>. You can't delete a <code>RegexPatternSet</code>
        /// if it's still used in any <code>RegexMatchSet</code> or if the <code>RegexPatternSet</code>
        /// is not empty.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request)
        {
            var marshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRegexPatternSetRequest,DeleteRegexPatternSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual Task<DeleteRegexPatternSetResponse> DeleteRegexPatternSetAsync(DeleteRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegexPatternSetRequest,DeleteRegexPatternSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <code>Rule</code> if it's still
        /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
        /// as <code>ByteMatchSet</code> objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>Rule</code> from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>Rule</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>Rule</code> to remove predicates, if any. For more information, see
        /// <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <a>Rule</a> that you want to delete. <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(string ruleId, string changeToken)
        {
            var request = new DeleteRuleRequest();
            request.RuleId = ruleId;
            request.ChangeToken = changeToken;
            return DeleteRule(request);
        }


        /// <summary>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <code>Rule</code> if it's still
        /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
        /// as <code>ByteMatchSet</code> objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>Rule</code> from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>Rule</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>Rule</code> to remove predicates, if any. For more information, see
        /// <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var marshaller = DeleteRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Permanently deletes a <a>Rule</a>. You can't delete a <code>Rule</code> if it's still
        /// used in any <code>WebACL</code> objects or if it still includes any predicates, such
        /// as <code>ByteMatchSet</code> objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>Rule</code> from a <code>WebACL</code>, use <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>Rule</code> from AWS WAF, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>Rule</code> to remove predicates, if any. For more information, see
        /// <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRule</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <a>Rule</a> that you want to delete. <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
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
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRuleGroup


        /// <summary>
        /// Permanently deletes a <a>RuleGroup</a>. You can't delete a <code>RuleGroup</code>
        /// if it's still used in any <code>WebACL</code> objects or if it still includes any
        /// rules.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>RuleGroup</code> from a <code>WebACL</code>, use
        /// <a>UpdateWebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>RuleGroup</code> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>RuleGroup</code> to remove rules, if any. For more information, see
        /// <a>UpdateRuleGroup</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteRuleGroup</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteRuleGroup</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonEmptyEntityException">
        /// The operation failed because you tried to delete an object that isn't empty. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var marshaller = DeleteRuleGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupRequest,DeleteRuleGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRuleGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleGroupRequest,DeleteRuleGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSizeConstraintSet


        /// <summary>
        /// Permanently deletes a <a>SizeConstraintSet</a>. You can't delete a <code>SizeConstraintSet</code>
        /// if it's still used in any <code>Rules</code> or if it still includes any <a>SizeConstraint</a>
        /// objects (any filters).
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SizeConstraintSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SizeConstraintSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SizeConstraintSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSizeConstraintSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSizeConstraintSet">REST API Reference for DeleteSizeConstraintSet Operation</seealso>
        public virtual DeleteSizeConstraintSetResponse DeleteSizeConstraintSet(DeleteSizeConstraintSetRequest request)
        {
            var marshaller = DeleteSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = DeleteSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<DeleteSizeConstraintSetRequest,DeleteSizeConstraintSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSizeConstraintSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSizeConstraintSet">REST API Reference for DeleteSizeConstraintSet Operation</seealso>
        public virtual Task<DeleteSizeConstraintSetResponse> DeleteSizeConstraintSetAsync(DeleteSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = DeleteSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSizeConstraintSetRequest,DeleteSizeConstraintSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSqlInjectionMatchSet


        /// <summary>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <code>SqlInjectionMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SqlInjectionMatchSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SqlInjectionMatchSet</code> from AWS WAF, perform the
        /// following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SqlInjectionMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you want to delete. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        public virtual DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(string sqlInjectionMatchSetId, string changeToken)
        {
            var request = new DeleteSqlInjectionMatchSetRequest();
            request.SqlInjectionMatchSetId = sqlInjectionMatchSetId;
            request.ChangeToken = changeToken;
            return DeleteSqlInjectionMatchSet(request);
        }


        /// <summary>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <code>SqlInjectionMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SqlInjectionMatchSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SqlInjectionMatchSet</code> from AWS WAF, perform the
        /// following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SqlInjectionMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        public virtual DeleteSqlInjectionMatchSetResponse DeleteSqlInjectionMatchSet(DeleteSqlInjectionMatchSetRequest request)
        {
            var marshaller = DeleteSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteSqlInjectionMatchSetRequest,DeleteSqlInjectionMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Permanently deletes a <a>SqlInjectionMatchSet</a>. You can't delete a <code>SqlInjectionMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>SqlInjectionMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove a <code>SqlInjectionMatchSet</code> from a <code>Rule</code>,
        /// use <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete a <code>SqlInjectionMatchSet</code> from AWS WAF, perform the
        /// following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>SqlInjectionMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteSqlInjectionMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you want to delete. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
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
        /// Initiates the asynchronous execution of the DeleteSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSqlInjectionMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteSqlInjectionMatchSet">REST API Reference for DeleteSqlInjectionMatchSet Operation</seealso>
        public virtual Task<DeleteSqlInjectionMatchSetResponse> DeleteSqlInjectionMatchSetAsync(DeleteSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSqlInjectionMatchSetRequest,DeleteSqlInjectionMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebACL


        /// <summary>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <code>WebACL</code> if it
        /// still contains any <code>Rules</code>.
        /// 
        ///  
        /// <para>
        /// To delete a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>WebACL</code> to remove <code>Rules</code>, if any. For more information,
        /// see <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="webACLId">The <code>WebACLId</code> of the <a>WebACL</a> that you want to delete. <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual DeleteWebACLResponse DeleteWebACL(string webACLId, string changeToken)
        {
            var request = new DeleteWebACLRequest();
            request.WebACLId = webACLId;
            request.ChangeToken = changeToken;
            return DeleteWebACL(request);
        }


        /// <summary>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <code>WebACL</code> if it
        /// still contains any <code>Rules</code>.
        /// 
        ///  
        /// <para>
        /// To delete a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>WebACL</code> to remove <code>Rules</code>, if any. For more information,
        /// see <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request)
        {
            var marshaller = DeleteWebACLRequestMarshaller.Instance;
            var unmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return Invoke<DeleteWebACLRequest,DeleteWebACLResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Permanently deletes a <a>WebACL</a>. You can't delete a <code>WebACL</code> if it
        /// still contains any <code>Rules</code>.
        /// 
        ///  
        /// <para>
        /// To delete a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>WebACL</code> to remove <code>Rules</code>, if any. For more information,
        /// see <a>UpdateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteWebACL</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="webACLId">The <code>WebACLId</code> of the <a>WebACL</a> that you want to delete. <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
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
        /// Initiates the asynchronous execution of the DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual Task<DeleteWebACLResponse> DeleteWebACLAsync(DeleteWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteWebACLRequestMarshaller.Instance;
            var unmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWebACLRequest,DeleteWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteXssMatchSet


        /// <summary>
        /// Permanently deletes an <a>XssMatchSet</a>. You can't delete an <code>XssMatchSet</code>
        /// if it's still used in any <code>Rules</code> or if it still contains any <a>XssMatchTuple</a>
        /// objects.
        /// 
        ///  
        /// <para>
        /// If you just want to remove an <code>XssMatchSet</code> from a <code>Rule</code>, use
        /// <a>UpdateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To permanently delete an <code>XssMatchSet</code> from AWS WAF, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Update the <code>XssMatchSet</code> to remove filters, if any. For more information,
        /// see <a>UpdateXssMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of a <code>DeleteXssMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DeleteXssMatchSet</code> request.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet service method.</param>
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
        /// You tried to delete a <code>WebACL</code> that still contains one or more <code>Rule</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that still contains one or more <code>ByteMatchSet</code>
        /// objects or other predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>ByteMatchSet</code> that contains one or more <code>ByteMatchTuple</code>
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete an <code>IPSet</code> that references one or more IP addresses.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteXssMatchSet">REST API Reference for DeleteXssMatchSet Operation</seealso>
        public virtual DeleteXssMatchSetResponse DeleteXssMatchSet(DeleteXssMatchSetRequest request)
        {
            var marshaller = DeleteXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<DeleteXssMatchSetRequest,DeleteXssMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteXssMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DeleteXssMatchSet">REST API Reference for DeleteXssMatchSet Operation</seealso>
        public virtual Task<DeleteXssMatchSetResponse> DeleteXssMatchSetAsync(DeleteXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = DeleteXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteXssMatchSetRequest,DeleteXssMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWebACL


        /// <summary>
        /// Removes a web ACL from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
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
        public virtual DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request)
        {
            var marshaller = DisassociateWebACLRequestMarshaller.Instance;
            var unmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebACLRequest,DisassociateWebACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual Task<DisassociateWebACLResponse> DisassociateWebACLAsync(DisassociateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateWebACLRequestMarshaller.Instance;
            var unmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWebACLRequest,DisassociateWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetByteMatchSet


        /// <summary>
        /// Returns the <a>ByteMatchSet</a> specified by <code>ByteMatchSetId</code>.
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to get. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
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
        public virtual GetByteMatchSetResponse GetByteMatchSet(string byteMatchSetId)
        {
            var request = new GetByteMatchSetRequest();
            request.ByteMatchSetId = byteMatchSetId;
            return GetByteMatchSet(request);
        }


        /// <summary>
        /// Returns the <a>ByteMatchSet</a> specified by <code>ByteMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet service method.</param>
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
        public virtual GetByteMatchSetResponse GetByteMatchSet(GetByteMatchSetRequest request)
        {
            var marshaller = GetByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetByteMatchSetRequest,GetByteMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the <a>ByteMatchSet</a> specified by <code>ByteMatchSetId</code>.
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to get. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
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
        /// Initiates the asynchronous execution of the GetByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetByteMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetByteMatchSet">REST API Reference for GetByteMatchSet Operation</seealso>
        public virtual Task<GetByteMatchSetResponse> GetByteMatchSetAsync(GetByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetByteMatchSetRequest,GetByteMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChangeToken


        /// <summary>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// 
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <code>GetChangeToken</code> request and then submits a second <code>GetChangeToken</code>
        /// request before submitting a create, update, or delete request, the second <code>GetChangeToken</code>
        /// request returns the same value as the first <code>GetChangeToken</code> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <code>PENDING</code>, which indicates that AWS WAF is
        /// propagating the change to all AWS WAF servers. Use <code>GetChangeTokenStatus</code>
        /// to determine the status of your change token.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        public virtual GetChangeTokenResponse GetChangeToken()
        {
            return GetChangeToken(new GetChangeTokenRequest());
        }


        /// <summary>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// 
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <code>GetChangeToken</code> request and then submits a second <code>GetChangeToken</code>
        /// request before submitting a create, update, or delete request, the second <code>GetChangeToken</code>
        /// request returns the same value as the first <code>GetChangeToken</code> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <code>PENDING</code>, which indicates that AWS WAF is
        /// propagating the change to all AWS WAF servers. Use <code>GetChangeTokenStatus</code>
        /// to determine the status of your change token.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken service method.</param>
        /// 
        /// <returns>The response from the GetChangeToken service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        public virtual GetChangeTokenResponse GetChangeToken(GetChangeTokenRequest request)
        {
            var marshaller = GetChangeTokenRequestMarshaller.Instance;
            var unmarshaller = GetChangeTokenResponseUnmarshaller.Instance;

            return Invoke<GetChangeTokenRequest,GetChangeTokenResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// When you want to create, update, or delete AWS WAF objects, get a change token and
        /// include the change token in the create, update, or delete request. Change tokens ensure
        /// that your application doesn't submit conflicting requests to AWS WAF.
        /// 
        ///  
        /// <para>
        /// Each create, update, or delete request must use a unique change token. If your application
        /// submits a <code>GetChangeToken</code> request and then submits a second <code>GetChangeToken</code>
        /// request before submitting a create, update, or delete request, the second <code>GetChangeToken</code>
        /// request returns the same value as the first <code>GetChangeToken</code> request.
        /// </para>
        ///  
        /// <para>
        /// When you use a change token in a create, update, or delete request, the status of
        /// the change token changes to <code>PENDING</code>, which indicates that AWS WAF is
        /// propagating the change to all AWS WAF servers. Use <code>GetChangeTokenStatus</code>
        /// to determine the status of your change token.
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
        /// Initiates the asynchronous execution of the GetChangeToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeToken">REST API Reference for GetChangeToken Operation</seealso>
        public virtual Task<GetChangeTokenResponse> GetChangeTokenAsync(GetChangeTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetChangeTokenRequestMarshaller.Instance;
            var unmarshaller = GetChangeTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeTokenRequest,GetChangeTokenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChangeTokenStatus


        /// <summary>
        /// Returns the status of a <code>ChangeToken</code> that you got by calling <a>GetChangeToken</a>.
        /// <code>ChangeTokenStatus</code> is one of the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PROVISIONED</code>: You requested the change token by calling <code>GetChangeToken</code>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code>: AWS WAF is propagating the create, update, or delete request
        /// to all AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="changeToken">The change token for which you want to get the status. This change token was previously returned in the <code>GetChangeToken</code> response.</param>
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
        public virtual GetChangeTokenStatusResponse GetChangeTokenStatus(string changeToken)
        {
            var request = new GetChangeTokenStatusRequest();
            request.ChangeToken = changeToken;
            return GetChangeTokenStatus(request);
        }


        /// <summary>
        /// Returns the status of a <code>ChangeToken</code> that you got by calling <a>GetChangeToken</a>.
        /// <code>ChangeTokenStatus</code> is one of the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PROVISIONED</code>: You requested the change token by calling <code>GetChangeToken</code>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code>: AWS WAF is propagating the create, update, or delete request
        /// to all AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus service method.</param>
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
        public virtual GetChangeTokenStatusResponse GetChangeTokenStatus(GetChangeTokenStatusRequest request)
        {
            var marshaller = GetChangeTokenStatusRequestMarshaller.Instance;
            var unmarshaller = GetChangeTokenStatusResponseUnmarshaller.Instance;

            return Invoke<GetChangeTokenStatusRequest,GetChangeTokenStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the status of a <code>ChangeToken</code> that you got by calling <a>GetChangeToken</a>.
        /// <code>ChangeTokenStatus</code> is one of the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PROVISIONED</code>: You requested the change token by calling <code>GetChangeToken</code>,
        /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code>: AWS WAF is propagating the create, update, or delete request
        /// to all AWS WAF servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: Propagation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="changeToken">The change token for which you want to get the status. This change token was previously returned in the <code>GetChangeToken</code> response.</param>
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
        /// Initiates the asynchronous execution of the GetChangeTokenStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeTokenStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetChangeTokenStatus">REST API Reference for GetChangeTokenStatus Operation</seealso>
        public virtual Task<GetChangeTokenStatusResponse> GetChangeTokenStatusAsync(GetChangeTokenStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetChangeTokenStatusRequestMarshaller.Instance;
            var unmarshaller = GetChangeTokenStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeTokenStatusRequest,GetChangeTokenStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGeoMatchSet


        /// <summary>
        /// Returns the <a>GeoMatchSet</a> that is specified by <code>GeoMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoMatchSet service method.</param>
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
        public virtual GetGeoMatchSetResponse GetGeoMatchSet(GetGeoMatchSetRequest request)
        {
            var marshaller = GetGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetGeoMatchSetRequest,GetGeoMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetGeoMatchSet">REST API Reference for GetGeoMatchSet Operation</seealso>
        public virtual Task<GetGeoMatchSetResponse> GetGeoMatchSetAsync(GetGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeoMatchSetRequest,GetGeoMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// Returns the <a>IPSet</a> that is specified by <code>IPSetId</code>.
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to get. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
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
        public virtual GetIPSetResponse GetIPSet(string ipSetId)
        {
            var request = new GetIPSetRequest();
            request.IPSetId = ipSetId;
            return GetIPSet(request);
        }


        /// <summary>
        /// Returns the <a>IPSet</a> that is specified by <code>IPSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
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
        public virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var marshaller = GetIPSetRequestMarshaller.Instance;
            var unmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetRequest,GetIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the <a>IPSet</a> that is specified by <code>IPSetId</code>.
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to get. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
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
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIPSetRequestMarshaller.Instance;
            var unmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetIPSetRequest,GetIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPermissionPolicy


        /// <summary>
        /// Returns the IAM policy attached to the RuleGroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
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
        public virtual GetPermissionPolicyResponse GetPermissionPolicy(GetPermissionPolicyRequest request)
        {
            var marshaller = GetPermissionPolicyRequestMarshaller.Instance;
            var unmarshaller = GetPermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPermissionPolicyRequest,GetPermissionPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        public virtual Task<GetPermissionPolicyResponse> GetPermissionPolicyAsync(GetPermissionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPermissionPolicyRequestMarshaller.Instance;
            var unmarshaller = GetPermissionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPermissionPolicyRequest,GetPermissionPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRateBasedRule


        /// <summary>
        /// Returns the <a>RateBasedRule</a> that is specified by the <code>RuleId</code> that
        /// you included in the <code>GetRateBasedRule</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRule service method.</param>
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
        public virtual GetRateBasedRuleResponse GetRateBasedRule(GetRateBasedRuleRequest request)
        {
            var marshaller = GetRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = GetRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<GetRateBasedRuleRequest,GetRateBasedRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRateBasedRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRateBasedRule">REST API Reference for GetRateBasedRule Operation</seealso>
        public virtual Task<GetRateBasedRuleResponse> GetRateBasedRuleAsync(GetRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = GetRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRateBasedRuleRequest,GetRateBasedRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRateBasedRuleManagedKeys


        /// <summary>
        /// Returns an array of IP addresses currently being blocked by the <a>RateBasedRule</a>
        /// that is specified by the <code>RuleId</code>. The maximum number of managed keys that
        /// will be blocked is 10,000. If more than 10,000 addresses exceed the rate limit, the
        /// 10,000 addresses with the highest rates will be blocked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRuleManagedKeys service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
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
        public virtual GetRateBasedRuleManagedKeysResponse GetRateBasedRuleManagedKeys(GetRateBasedRuleManagedKeysRequest request)
        {
            var marshaller = GetRateBasedRuleManagedKeysRequestMarshaller.Instance;
            var unmarshaller = GetRateBasedRuleManagedKeysResponseUnmarshaller.Instance;

            return Invoke<GetRateBasedRuleManagedKeysRequest,GetRateBasedRuleManagedKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRateBasedRuleManagedKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedRuleManagedKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRateBasedRuleManagedKeys">REST API Reference for GetRateBasedRuleManagedKeys Operation</seealso>
        public virtual Task<GetRateBasedRuleManagedKeysResponse> GetRateBasedRuleManagedKeysAsync(GetRateBasedRuleManagedKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRateBasedRuleManagedKeysRequestMarshaller.Instance;
            var unmarshaller = GetRateBasedRuleManagedKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetRateBasedRuleManagedKeysRequest,GetRateBasedRuleManagedKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRegexMatchSet


        /// <summary>
        /// Returns the <a>RegexMatchSet</a> specified by <code>RegexMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexMatchSet service method.</param>
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
        public virtual GetRegexMatchSetResponse GetRegexMatchSet(GetRegexMatchSetRequest request)
        {
            var marshaller = GetRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetRegexMatchSetRequest,GetRegexMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegexMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegexMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRegexMatchSet">REST API Reference for GetRegexMatchSet Operation</seealso>
        public virtual Task<GetRegexMatchSetResponse> GetRegexMatchSetAsync(GetRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegexMatchSetRequest,GetRegexMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRegexPatternSet


        /// <summary>
        /// Returns the <a>RegexPatternSet</a> specified by <code>RegexPatternSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
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
        public virtual GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request)
        {
            var marshaller = GetRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<GetRegexPatternSetRequest,GetRegexPatternSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual Task<GetRegexPatternSetResponse> GetRegexPatternSetAsync(GetRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegexPatternSetRequest,GetRegexPatternSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Returns the <a>Rule</a> that is specified by the <code>RuleId</code> that you included
        /// in the <code>GetRule</code> request.
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <a>Rule</a> that you want to get. <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
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
        public virtual GetRuleResponse GetRule(string ruleId)
        {
            var request = new GetRuleRequest();
            request.RuleId = ruleId;
            return GetRule(request);
        }


        /// <summary>
        /// Returns the <a>Rule</a> that is specified by the <code>RuleId</code> that you included
        /// in the <code>GetRule</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
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
        public virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var marshaller = GetRuleRequestMarshaller.Instance;
            var unmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleRequest,GetRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the <a>Rule</a> that is specified by the <code>RuleId</code> that you included
        /// in the <code>GetRule</code> request.
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <a>Rule</a> that you want to get. <code>RuleId</code> is returned by <a>CreateRule</a> and by <a>ListRules</a>.</param>
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
        /// Initiates the asynchronous execution of the GetRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRuleRequestMarshaller.Instance;
            var unmarshaller = GetRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleRequest,GetRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRuleGroup


        /// <summary>
        /// Returns the <a>RuleGroup</a> that is specified by the <code>RuleGroupId</code> that
        /// you included in the <code>GetRuleGroup</code> request.
        /// 
        ///  
        /// <para>
        /// To view the rules in a rule group, use <a>ListActivatedRulesInRuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
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
        public virtual GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request)
        {
            var marshaller = GetRuleGroupRequestMarshaller.Instance;
            var unmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return Invoke<GetRuleGroupRequest,GetRuleGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual Task<GetRuleGroupResponse> GetRuleGroupAsync(GetRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRuleGroupRequestMarshaller.Instance;
            var unmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleGroupRequest,GetRuleGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSampledRequests


        /// <summary>
        /// Gets detailed information about a specified number of requests--a sample--that AWS
        /// WAF randomly selects from among the first 5,000 requests that your AWS resource received
        /// during a time range that you choose. You can specify a sample size of up to 500 requests,
        /// and you can specify any time range in the previous three hours.
        /// 
        ///  
        /// <para>
        ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
        /// that you specified. However, if your resource (such as a CloudFront distribution)
        /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
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
        public virtual GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request)
        {
            var marshaller = GetSampledRequestsRequestMarshaller.Instance;
            var unmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return Invoke<GetSampledRequestsRequest,GetSampledRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual Task<GetSampledRequestsResponse> GetSampledRequestsAsync(GetSampledRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSampledRequestsRequestMarshaller.Instance;
            var unmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSampledRequestsRequest,GetSampledRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSizeConstraintSet


        /// <summary>
        /// Returns the <a>SizeConstraintSet</a> specified by <code>SizeConstraintSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet service method.</param>
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
        public virtual GetSizeConstraintSetResponse GetSizeConstraintSet(GetSizeConstraintSetRequest request)
        {
            var marshaller = GetSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = GetSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<GetSizeConstraintSetRequest,GetSizeConstraintSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSizeConstraintSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSizeConstraintSet">REST API Reference for GetSizeConstraintSet Operation</seealso>
        public virtual Task<GetSizeConstraintSetResponse> GetSizeConstraintSetAsync(GetSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = GetSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetSizeConstraintSetRequest,GetSizeConstraintSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSqlInjectionMatchSet


        /// <summary>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <code>SqlInjectionMatchSetId</code>.
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you want to get. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
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
        public virtual GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(string sqlInjectionMatchSetId)
        {
            var request = new GetSqlInjectionMatchSetRequest();
            request.SqlInjectionMatchSetId = sqlInjectionMatchSetId;
            return GetSqlInjectionMatchSet(request);
        }


        /// <summary>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <code>SqlInjectionMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet service method.</param>
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
        public virtual GetSqlInjectionMatchSetResponse GetSqlInjectionMatchSet(GetSqlInjectionMatchSetRequest request)
        {
            var marshaller = GetSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetSqlInjectionMatchSetRequest,GetSqlInjectionMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the <a>SqlInjectionMatchSet</a> that is specified by <code>SqlInjectionMatchSetId</code>.
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <a>SqlInjectionMatchSet</a> that you want to get. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
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
        /// Initiates the asynchronous execution of the GetSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSqlInjectionMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetSqlInjectionMatchSet">REST API Reference for GetSqlInjectionMatchSet Operation</seealso>
        public virtual Task<GetSqlInjectionMatchSetResponse> GetSqlInjectionMatchSetAsync(GetSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetSqlInjectionMatchSetRequest,GetSqlInjectionMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetWebACL


        /// <summary>
        /// Returns the <a>WebACL</a> that is specified by <code>WebACLId</code>.
        /// </summary>
        /// <param name="webACLId">The <code>WebACLId</code> of the <a>WebACL</a> that you want to get. <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
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
        public virtual GetWebACLResponse GetWebACL(string webACLId)
        {
            var request = new GetWebACLRequest();
            request.WebACLId = webACLId;
            return GetWebACL(request);
        }


        /// <summary>
        /// Returns the <a>WebACL</a> that is specified by <code>WebACLId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
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
        public virtual GetWebACLResponse GetWebACL(GetWebACLRequest request)
        {
            var marshaller = GetWebACLRequestMarshaller.Instance;
            var unmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return Invoke<GetWebACLRequest,GetWebACLResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the <a>WebACL</a> that is specified by <code>WebACLId</code>.
        /// </summary>
        /// <param name="webACLId">The <code>WebACLId</code> of the <a>WebACL</a> that you want to get. <code>WebACLId</code> is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.</param>
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
        /// Initiates the asynchronous execution of the GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual Task<GetWebACLResponse> GetWebACLAsync(GetWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetWebACLRequestMarshaller.Instance;
            var unmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebACLRequest,GetWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetWebACLForResource


        /// <summary>
        /// Returns the web ACL for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
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
        public virtual GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request)
        {
            var marshaller = GetWebACLForResourceRequestMarshaller.Instance;
            var unmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return Invoke<GetWebACLForResourceRequest,GetWebACLForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual Task<GetWebACLForResourceResponse> GetWebACLForResourceAsync(GetWebACLForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetWebACLForResourceRequestMarshaller.Instance;
            var unmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetWebACLForResourceRequest,GetWebACLForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetXssMatchSet


        /// <summary>
        /// Returns the <a>XssMatchSet</a> that is specified by <code>XssMatchSetId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet service method.</param>
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
        public virtual GetXssMatchSetResponse GetXssMatchSet(GetXssMatchSetRequest request)
        {
            var marshaller = GetXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<GetXssMatchSetRequest,GetXssMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetXssMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/GetXssMatchSet">REST API Reference for GetXssMatchSet Operation</seealso>
        public virtual Task<GetXssMatchSetResponse> GetXssMatchSetAsync(GetXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = GetXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetXssMatchSetRequest,GetXssMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListActivatedRulesInRuleGroup


        /// <summary>
        /// Returns an array of <a>ActivatedRule</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivatedRulesInRuleGroup service method.</param>
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
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
        public virtual ListActivatedRulesInRuleGroupResponse ListActivatedRulesInRuleGroup(ListActivatedRulesInRuleGroupRequest request)
        {
            var marshaller = ListActivatedRulesInRuleGroupRequestMarshaller.Instance;
            var unmarshaller = ListActivatedRulesInRuleGroupResponseUnmarshaller.Instance;

            return Invoke<ListActivatedRulesInRuleGroupRequest,ListActivatedRulesInRuleGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActivatedRulesInRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivatedRulesInRuleGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListActivatedRulesInRuleGroup">REST API Reference for ListActivatedRulesInRuleGroup Operation</seealso>
        public virtual Task<ListActivatedRulesInRuleGroupResponse> ListActivatedRulesInRuleGroupAsync(ListActivatedRulesInRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListActivatedRulesInRuleGroupRequestMarshaller.Instance;
            var unmarshaller = ListActivatedRulesInRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ListActivatedRulesInRuleGroupRequest,ListActivatedRulesInRuleGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListByteMatchSets


        /// <summary>
        /// Returns an array of <a>ByteMatchSetSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets service method.</param>
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
        public virtual ListByteMatchSetsResponse ListByteMatchSets(ListByteMatchSetsRequest request)
        {
            var marshaller = ListByteMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListByteMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListByteMatchSetsRequest,ListByteMatchSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListByteMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListByteMatchSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListByteMatchSets">REST API Reference for ListByteMatchSets Operation</seealso>
        public virtual Task<ListByteMatchSetsResponse> ListByteMatchSetsAsync(ListByteMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListByteMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListByteMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListByteMatchSetsRequest,ListByteMatchSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGeoMatchSets


        /// <summary>
        /// Returns an array of <a>GeoMatchSetSummary</a> objects in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoMatchSets service method.</param>
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
        public virtual ListGeoMatchSetsResponse ListGeoMatchSets(ListGeoMatchSetsRequest request)
        {
            var marshaller = ListGeoMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListGeoMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListGeoMatchSetsRequest,ListGeoMatchSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoMatchSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListGeoMatchSets">REST API Reference for ListGeoMatchSets Operation</seealso>
        public virtual Task<ListGeoMatchSetsResponse> ListGeoMatchSetsAsync(ListGeoMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGeoMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListGeoMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeoMatchSetsRequest,ListGeoMatchSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// Returns an array of <a>IPSetSummary</a> objects in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
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
        public virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var marshaller = ListIPSetsRequestMarshaller.Instance;
            var unmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsRequest,ListIPSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListIPSetsRequestMarshaller.Instance;
            var unmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIPSetsRequest,ListIPSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRateBasedRules


        /// <summary>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRateBasedRules service method.</param>
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
        public virtual ListRateBasedRulesResponse ListRateBasedRules(ListRateBasedRulesRequest request)
        {
            var marshaller = ListRateBasedRulesRequestMarshaller.Instance;
            var unmarshaller = ListRateBasedRulesResponseUnmarshaller.Instance;

            return Invoke<ListRateBasedRulesRequest,ListRateBasedRulesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRateBasedRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRateBasedRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRateBasedRules">REST API Reference for ListRateBasedRules Operation</seealso>
        public virtual Task<ListRateBasedRulesResponse> ListRateBasedRulesAsync(ListRateBasedRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRateBasedRulesRequestMarshaller.Instance;
            var unmarshaller = ListRateBasedRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRateBasedRulesRequest,ListRateBasedRulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRegexMatchSets


        /// <summary>
        /// Returns an array of <a>RegexMatchSetSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexMatchSets service method.</param>
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
        public virtual ListRegexMatchSetsResponse ListRegexMatchSets(ListRegexMatchSetsRequest request)
        {
            var marshaller = ListRegexMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListRegexMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListRegexMatchSetsRequest,ListRegexMatchSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegexMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegexMatchSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRegexMatchSets">REST API Reference for ListRegexMatchSets Operation</seealso>
        public virtual Task<ListRegexMatchSetsResponse> ListRegexMatchSetsAsync(ListRegexMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRegexMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListRegexMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegexMatchSetsRequest,ListRegexMatchSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRegexPatternSets


        /// <summary>
        /// Returns an array of <a>RegexPatternSetSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
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
        public virtual ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request)
        {
            var marshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            var unmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return Invoke<ListRegexPatternSetsRequest,ListRegexPatternSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegexPatternSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual Task<ListRegexPatternSetsResponse> ListRegexPatternSetsAsync(ListRegexPatternSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            var unmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegexPatternSetsRequest,ListRegexPatternSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourcesForWebACL


        /// <summary>
        /// Returns an array of resources associated with the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
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
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentItemException">
        /// The operation failed because the referenced object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request)
        {
            var marshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            var unmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForWebACLRequest,ListResourcesForWebACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual Task<ListResourcesForWebACLResponse> ListResourcesForWebACLAsync(ListResourcesForWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            var unmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcesForWebACLRequest,ListResourcesForWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRuleGroups


        /// <summary>
        /// Returns an array of <a>RuleGroup</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFRegional.</returns>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var marshaller = ListRuleGroupsRequestMarshaller.Instance;
            var unmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsRequest,ListRuleGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRuleGroupsRequestMarshaller.Instance;
            var unmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleGroupsRequest,ListRuleGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Returns an array of <a>RuleSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
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
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var marshaller = ListRulesRequestMarshaller.Instance;
            var unmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesRequest,ListRulesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRulesRequestMarshaller.Instance;
            var unmarshaller = ListRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesRequest,ListRulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSizeConstraintSets


        /// <summary>
        /// Returns an array of <a>SizeConstraintSetSummary</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets service method.</param>
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
        public virtual ListSizeConstraintSetsResponse ListSizeConstraintSets(ListSizeConstraintSetsRequest request)
        {
            var marshaller = ListSizeConstraintSetsRequestMarshaller.Instance;
            var unmarshaller = ListSizeConstraintSetsResponseUnmarshaller.Instance;

            return Invoke<ListSizeConstraintSetsRequest,ListSizeConstraintSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSizeConstraintSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSizeConstraintSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListSizeConstraintSets">REST API Reference for ListSizeConstraintSets Operation</seealso>
        public virtual Task<ListSizeConstraintSetsResponse> ListSizeConstraintSetsAsync(ListSizeConstraintSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSizeConstraintSetsRequestMarshaller.Instance;
            var unmarshaller = ListSizeConstraintSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSizeConstraintSetsRequest,ListSizeConstraintSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSqlInjectionMatchSets


        /// <summary>
        /// Returns an array of <a>SqlInjectionMatchSet</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets service method.</param>
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
        public virtual ListSqlInjectionMatchSetsResponse ListSqlInjectionMatchSets(ListSqlInjectionMatchSetsRequest request)
        {
            var marshaller = ListSqlInjectionMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListSqlInjectionMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListSqlInjectionMatchSetsRequest,ListSqlInjectionMatchSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSqlInjectionMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSqlInjectionMatchSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListSqlInjectionMatchSets">REST API Reference for ListSqlInjectionMatchSets Operation</seealso>
        public virtual Task<ListSqlInjectionMatchSetsResponse> ListSqlInjectionMatchSetsAsync(ListSqlInjectionMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSqlInjectionMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListSqlInjectionMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSqlInjectionMatchSetsRequest,ListSqlInjectionMatchSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSubscribedRuleGroups


        /// <summary>
        /// Returns an array of <a>RuleGroup</a> objects that you are subscribed to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedRuleGroups service method.</param>
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
        public virtual ListSubscribedRuleGroupsResponse ListSubscribedRuleGroups(ListSubscribedRuleGroupsRequest request)
        {
            var marshaller = ListSubscribedRuleGroupsRequestMarshaller.Instance;
            var unmarshaller = ListSubscribedRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListSubscribedRuleGroupsRequest,ListSubscribedRuleGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscribedRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedRuleGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListSubscribedRuleGroups">REST API Reference for ListSubscribedRuleGroups Operation</seealso>
        public virtual Task<ListSubscribedRuleGroupsResponse> ListSubscribedRuleGroupsAsync(ListSubscribedRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSubscribedRuleGroupsRequestMarshaller.Instance;
            var unmarshaller = ListSubscribedRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscribedRuleGroupsRequest,ListSubscribedRuleGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListWebACLs


        /// <summary>
        /// Returns an array of <a>WebACLSummary</a> objects in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
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
        public virtual ListWebACLsResponse ListWebACLs(ListWebACLsRequest request)
        {
            var marshaller = ListWebACLsRequestMarshaller.Instance;
            var unmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return Invoke<ListWebACLsRequest,ListWebACLsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual Task<ListWebACLsResponse> ListWebACLsAsync(ListWebACLsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListWebACLsRequestMarshaller.Instance;
            var unmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebACLsRequest,ListWebACLsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListXssMatchSets


        /// <summary>
        /// Returns an array of <a>XssMatchSet</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets service method.</param>
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
        public virtual ListXssMatchSetsResponse ListXssMatchSets(ListXssMatchSetsRequest request)
        {
            var marshaller = ListXssMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListXssMatchSetsResponseUnmarshaller.Instance;

            return Invoke<ListXssMatchSetsRequest,ListXssMatchSetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListXssMatchSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListXssMatchSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/ListXssMatchSets">REST API Reference for ListXssMatchSets Operation</seealso>
        public virtual Task<ListXssMatchSetsResponse> ListXssMatchSetsAsync(ListXssMatchSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListXssMatchSetsRequestMarshaller.Instance;
            var unmarshaller = ListXssMatchSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListXssMatchSetsRequest,ListXssMatchSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutPermissionPolicy


        /// <summary>
        /// Attaches a IAM policy to the specified resource. The only supported use for this action
        /// is to share a RuleGroup across accounts.
        /// 
        ///  
        /// <para>
        /// The <code>PutPermissionPolicy</code> is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <code>Effect</code>, <code>Action</code> and <code>Principal</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Effect</code> must specify <code>Allow</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Action</code> in the policy must be <code>waf:UpdateWebACL</code> and <code>waf-regional:UpdateWebACL</code>.
        /// Any extra or wildcard actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <code>Resource</code> parameter.
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
        /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include an <code>Effect</code>, <code>Action</code> and <code>Principal</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Effect</code> must specify <code>Allow</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Action</code> in the policy must be <code>waf:UpdateWebACL</code> or <code>waf-regional:UpdateWebACL</code>.
        /// Any extra or wildcard actions in the policy will be rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy cannot include a <code>Resource</code> parameter.
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
        public virtual PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request)
        {
            var marshaller = PutPermissionPolicyRequestMarshaller.Instance;
            var unmarshaller = PutPermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPermissionPolicyRequest,PutPermissionPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        public virtual Task<PutPermissionPolicyResponse> PutPermissionPolicyAsync(PutPermissionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutPermissionPolicyRequestMarshaller.Instance;
            var unmarshaller = PutPermissionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutPermissionPolicyRequest,PutPermissionPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateByteMatchSet


        /// <summary>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <code>ByteMatchTuple</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>ByteMatchSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <code>User-Agent</code> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <code>TargetString</code> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <code>ByteMatchSetUpdate</code> object that matches web
        /// requests in which <code>User-Agent</code> headers contain the string <code>BadBot</code>.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>ByteMatchSet.</code> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateByteMatchSet</code> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to update. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="updates">An array of <code>ByteMatchSetUpdate</code> objects that you want to insert into or delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>ByteMatchSetUpdate</a>: Contains <code>Action</code> and <code>ByteMatchTuple</code>  </li> <li>  <a>ByteMatchTuple</a>: Contains <code>FieldToMatch</code>, <code>PositionalConstraint</code>, <code>TargetString</code>, and <code>TextTransformation</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateByteMatchSetResponse UpdateByteMatchSet(string byteMatchSetId, List<ByteMatchSetUpdate> updates, string changeToken)
        {
            var request = new UpdateByteMatchSetRequest();
            request.ByteMatchSetId = byteMatchSetId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateByteMatchSet(request);
        }


        /// <summary>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <code>ByteMatchTuple</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>ByteMatchSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <code>User-Agent</code> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <code>TargetString</code> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <code>ByteMatchSetUpdate</code> object that matches web
        /// requests in which <code>User-Agent</code> headers contain the string <code>BadBot</code>.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>ByteMatchSet.</code> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateByteMatchSet</code> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateByteMatchSetResponse UpdateByteMatchSet(UpdateByteMatchSetRequest request)
        {
            var marshaller = UpdateByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateByteMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateByteMatchSetRequest,UpdateByteMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
        /// For each <code>ByteMatchTuple</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>ByteMatchSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspect, such as a query string
        /// or the value of the <code>User-Agent</code> header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The bytes (typically a string that corresponds with ASCII characters) that you want
        /// AWS WAF to look for. For more information, including how you specify the values for
        /// the AWS WAF API and the AWS CLI or SDKs, see <code>TargetString</code> in the <a>ByteMatchTuple</a>
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
        /// For example, you can add a <code>ByteMatchSetUpdate</code> object that matches web
        /// requests in which <code>User-Agent</code> headers contain the string <code>BadBot</code>.
        /// You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>ByteMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>ByteMatchSet.</code> For more information, see <a>CreateByteMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateByteMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateByteMatchSet</code> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
        /// that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="byteMatchSetId">The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to update. <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.</param>
        /// <param name="updates">An array of <code>ByteMatchSetUpdate</code> objects that you want to insert into or delete from a <a>ByteMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>ByteMatchSetUpdate</a>: Contains <code>Action</code> and <code>ByteMatchTuple</code>  </li> <li>  <a>ByteMatchTuple</a>: Contains <code>FieldToMatch</code>, <code>PositionalConstraint</code>, <code>TargetString</code>, and <code>TextTransformation</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// Initiates the asynchronous execution of the UpdateByteMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateByteMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateByteMatchSet">REST API Reference for UpdateByteMatchSet Operation</seealso>
        public virtual Task<UpdateByteMatchSetResponse> UpdateByteMatchSetAsync(UpdateByteMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateByteMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateByteMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateByteMatchSetRequest,UpdateByteMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGeoMatchSet


        /// <summary>
        /// Inserts or deletes <a>GeoMatchConstraint</a> objects in an <code>GeoMatchSet</code>.
        /// For each <code>GeoMatchConstraint</code> object, you specify the following values:
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <code>GeoMatchConstraint</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Type</code>. The only valid value for <code>Type</code> is <code>Country</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Value</code>, which is a two character code for the country to add to the
        /// <code>GeoMatchConstraint</code> object. Valid codes are listed in <a>GeoMatchConstraint$Value</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure an <code>GeoMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateGeoMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateGeoMatchSet</code> request to specify the country that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <code>GeoMatchSet</code>, you specify the country that you want
        /// to add and/or the country that you want to delete. If you want to change a country,
        /// you delete the existing country and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeoMatchSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateGeoMatchSet">REST API Reference for UpdateGeoMatchSet Operation</seealso>
        public virtual UpdateGeoMatchSetResponse UpdateGeoMatchSet(UpdateGeoMatchSetRequest request)
        {
            var marshaller = UpdateGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateGeoMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateGeoMatchSetRequest,UpdateGeoMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGeoMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeoMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateGeoMatchSet">REST API Reference for UpdateGeoMatchSet Operation</seealso>
        public virtual Task<UpdateGeoMatchSetResponse> UpdateGeoMatchSetAsync(UpdateGeoMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateGeoMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateGeoMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGeoMatchSetRequest,UpdateGeoMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <code>IPSet</code>. For each
        /// <code>IPSetDescriptor</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <code>IPSetDescriptor</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <code>IPv4</code> or <code>IPv6</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <code>192.0.2.0/24</code> (for the range
        /// of IP addresses from <code>192.0.2.0</code> to <code>192.0.2.255</code>) or <code>192.0.2.44/32</code>
        /// (for the individual IP address <code>192.0.2.44</code>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports /8, /16, /24, and /32 IP address ranges for IPv4, and /24, /32, /48,
        /// /56, /64 and /128 for IPv6. For more information about CIDR notation, see the Wikipedia
        /// entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <code>IPSet</code> to specify which web requests you want to allow or block
        /// based on the IP addresses that the requests originated from. For example, if you're
        /// receiving a lot of requests from one or a small number of IP addresses and you want
        /// to block the requests, you can create an <code>IPSet</code> that specifies those IP
        /// addresses, and then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <code>IPSet</code>, you specify the IP addresses that you want
        /// to add and/or the IP addresses that you want to delete. If you want to change an IP
        /// address, you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to update. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="updates">An array of <code>IPSetUpdate</code> objects that you want to insert into or delete from an <a>IPSet</a>. For more information, see the applicable data types: <ul> <li>  <a>IPSetUpdate</a>: Contains <code>Action</code> and <code>IPSetDescriptor</code>  </li> <li>  <a>IPSetDescriptor</a>: Contains <code>Type</code> and <code>Value</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse UpdateIPSet(string ipSetId, List<IPSetUpdate> updates, string changeToken)
        {
            var request = new UpdateIPSetRequest();
            request.IPSetId = ipSetId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateIPSet(request);
        }


        /// <summary>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <code>IPSet</code>. For each
        /// <code>IPSetDescriptor</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <code>IPSetDescriptor</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <code>IPv4</code> or <code>IPv6</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <code>192.0.2.0/24</code> (for the range
        /// of IP addresses from <code>192.0.2.0</code> to <code>192.0.2.255</code>) or <code>192.0.2.44/32</code>
        /// (for the individual IP address <code>192.0.2.44</code>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports /8, /16, /24, and /32 IP address ranges for IPv4, and /24, /32, /48,
        /// /56, /64 and /128 for IPv6. For more information about CIDR notation, see the Wikipedia
        /// entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <code>IPSet</code> to specify which web requests you want to allow or block
        /// based on the IP addresses that the requests originated from. For example, if you're
        /// receiving a lot of requests from one or a small number of IP addresses and you want
        /// to block the requests, you can create an <code>IPSet</code> that specifies those IP
        /// addresses, and then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <code>IPSet</code>, you specify the IP addresses that you want
        /// to add and/or the IP addresses that you want to delete. If you want to change an IP
        /// address, you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var marshaller = UpdateIPSetRequestMarshaller.Instance;
            var unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetRequest,UpdateIPSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <code>IPSet</code>. For each
        /// <code>IPSetDescriptor</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change an <code>IPSetDescriptor</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address version, <code>IPv4</code> or <code>IPv6</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IP address in CIDR notation, for example, <code>192.0.2.0/24</code> (for the range
        /// of IP addresses from <code>192.0.2.0</code> to <code>192.0.2.255</code>) or <code>192.0.2.44/32</code>
        /// (for the individual IP address <code>192.0.2.44</code>). 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS WAF supports /8, /16, /24, and /32 IP address ranges for IPv4, and /24, /32, /48,
        /// /56, /64 and /128 for IPv6. For more information about CIDR notation, see the Wikipedia
        /// entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
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
        /// You use an <code>IPSet</code> to specify which web requests you want to allow or block
        /// based on the IP addresses that the requests originated from. For example, if you're
        /// receiving a lot of requests from one or a small number of IP addresses and you want
        /// to block the requests, you can create an <code>IPSet</code> that specifies those IP
        /// addresses, and then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>IPSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
        /// AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you update an <code>IPSet</code>, you specify the IP addresses that you want
        /// to add and/or the IP addresses that you want to delete. If you want to change an IP
        /// address, you delete the existing IP address and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ipSetId">The <code>IPSetId</code> of the <a>IPSet</a> that you want to update. <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.</param>
        /// <param name="updates">An array of <code>IPSetUpdate</code> objects that you want to insert into or delete from an <a>IPSet</a>. For more information, see the applicable data types: <ul> <li>  <a>IPSetUpdate</a>: Contains <code>Action</code> and <code>IPSetDescriptor</code>  </li> <li>  <a>IPSetDescriptor</a>: Contains <code>Type</code> and <code>Value</code>  </li> </ul></param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
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
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateIPSetRequestMarshaller.Instance;
            var unmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIPSetRequest,UpdateIPSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRateBasedRule


        /// <summary>
        /// Inserts or deletes <a>Predicate</a> objects in a rule and updates the <code>RateLimit</code>
        /// in the rule. 
        /// 
        ///  
        /// <para>
        /// Each <code>Predicate</code> object identifies a predicate, such as a <a>ByteMatchSet</a>
        /// or an <a>IPSet</a>, that specifies the web requests that you want to block or count.
        /// The <code>RateLimit</code> specifies the number of requests every five minutes that
        /// triggers the rule.
        /// </para>
        ///  
        /// <para>
        /// If you add more than one predicate to a <code>RateBasedRule</code>, a request must
        /// match all the predicates and exceed the <code>RateLimit</code> to be counted or blocked.
        /// For example, suppose you add the following to a <code>RateBasedRule</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <code>RateLimit</code> of 15,000.
        /// </para>
        ///  
        /// <para>
        /// You then add the <code>RateBasedRule</code> to a <code>WebACL</code> and specify that
        /// you want to block requests that satisfy the rule. For a request to be blocked, it
        /// must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code> header
        /// in the request must contain the value <code>BadBot</code>. Further, requests that
        /// match these two conditions much be received at a rate of more than 15,000 every five
        /// minutes. If the rate drops below this limit, AWS WAF no longer blocks the requests.
        /// </para>
        ///  
        /// <para>
        /// As a second example, suppose you want to limit requests to a particular page on your
        /// site. To do this, you could add the following to a <code>RateBasedRule</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> with <code>FieldToMatch</code> of <code>URI</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>PositionalConstraint</code> of <code>STARTS_WITH</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>TargetString</code> of <code>login</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Further, you specify a <code>RateLimit</code> of 15,000.
        /// </para>
        ///  
        /// <para>
        /// By adding this <code>RateBasedRule</code> to a <code>WebACL</code>, you could limit
        /// requests to your login page without affecting the rest of your site.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRateBasedRule service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRateBasedRule">REST API Reference for UpdateRateBasedRule Operation</seealso>
        public virtual UpdateRateBasedRuleResponse UpdateRateBasedRule(UpdateRateBasedRuleRequest request)
        {
            var marshaller = UpdateRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateRateBasedRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRateBasedRuleRequest,UpdateRateBasedRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRateBasedRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRateBasedRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRateBasedRule">REST API Reference for UpdateRateBasedRule Operation</seealso>
        public virtual Task<UpdateRateBasedRuleResponse> UpdateRateBasedRuleAsync(UpdateRateBasedRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRateBasedRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateRateBasedRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRateBasedRuleRequest,UpdateRateBasedRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRegexMatchSet


        /// <summary>
        /// Inserts or deletes <a>RegexMatchTuple</a> objects (filters) in a <a>RegexMatchSet</a>.
        /// For each <code>RegexMatchSetUpdate</code> object, you specify the following values:
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>RegexMatchSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to inspectupdate, such as a query
        /// string or the value of the <code>User-Agent</code> header. 
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
        ///  For example, you can create a <code>RegexPatternSet</code> that matches any requests
        /// with <code>User-Agent</code> headers that contain the string <code>B[a@]dB[o0]t</code>.
        /// You can then configure AWS WAF to reject those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>RegexMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>RegexMatchSet.</code> For more information, see <a>CreateRegexMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateRegexMatchSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRegexMatchSet</code> request to specify the part of the request
        /// that you want AWS WAF to inspect (for example, the header or the URI) and the identifier
        /// of the <code>RegexPatternSet</code> that contain the regular expression patters you
        /// want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexMatchSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateRegexMatchSetResponse UpdateRegexMatchSet(UpdateRegexMatchSetRequest request)
        {
            var marshaller = UpdateRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateRegexMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRegexMatchSetRequest,UpdateRegexMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegexMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRegexMatchSet">REST API Reference for UpdateRegexMatchSet Operation</seealso>
        public virtual Task<UpdateRegexMatchSetResponse> UpdateRegexMatchSetAsync(UpdateRegexMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRegexMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateRegexMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegexMatchSetRequest,UpdateRegexMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRegexPatternSet


        /// <summary>
        /// Inserts or deletes <code>RegexPatternString</code> objects in a <a>RegexPatternSet</a>.
        /// For each <code>RegexPatternString</code> object, you specify the following values:
        /// 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the <code>RegexPatternString</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The regular expression pattern that you want to insert or delete. For more information,
        /// see <a>RegexPatternSet</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, you can create a <code>RegexPatternString</code> such as <code>B[a@]dB[o0]t</code>.
        /// AWS WAF will match this <code>RegexPatternString</code> to:
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
        /// To create and configure a <code>RegexPatternSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>RegexPatternSet.</code> For more information, see <a>CreateRegexPatternSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateRegexPatternSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRegexPatternSet</code> request to specify the regular expression
        /// pattern that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFInvalidRegexPatternException">
        /// The regular expression (regex) you specified in <code>RegexPatternString</code> is
        /// invalid.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request)
        {
            var marshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRegexPatternSetRequest,UpdateRegexPatternSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual Task<UpdateRegexPatternSetResponse> UpdateRegexPatternSetAsync(UpdateRegexPatternSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            var unmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegexPatternSetRequest,UpdateRegexPatternSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Inserts or deletes <a>Predicate</a> objects in a <code>Rule</code>. Each <code>Predicate</code>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <code>Rule</code>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose you add the following to
        /// a <code>Rule</code>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches the value <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to block requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// the <code>User-Agent</code> header in the request must contain the value <code>BadBot</code>
        /// <i>and</i> the request must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <code>Rule</code>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to add predicates to the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <code>ByteMatchSet</code> or <code>IPSet</code> with another,
        /// you delete the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <code>Rule</code> that you want to update. <code>RuleId</code> is returned by <code>CreateRule</code> and by <a>ListRules</a>.</param>
        /// <param name="updates">An array of <code>RuleUpdate</code> objects that you want to insert into or delete from a <a>Rule</a>. For more information, see the applicable data types: <ul> <li>  <a>RuleUpdate</a>: Contains <code>Action</code> and <code>Predicate</code>  </li> <li>  <a>Predicate</a>: Contains <code>DataId</code>, <code>Negated</code>, and <code>Type</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse UpdateRule(string ruleId, List<RuleUpdate> updates, string changeToken)
        {
            var request = new UpdateRuleRequest();
            request.RuleId = ruleId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateRule(request);
        }


        /// <summary>
        /// Inserts or deletes <a>Predicate</a> objects in a <code>Rule</code>. Each <code>Predicate</code>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <code>Rule</code>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose you add the following to
        /// a <code>Rule</code>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches the value <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to block requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// the <code>User-Agent</code> header in the request must contain the value <code>BadBot</code>
        /// <i>and</i> the request must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <code>Rule</code>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to add predicates to the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <code>ByteMatchSet</code> or <code>IPSet</code> with another,
        /// you delete the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var marshaller = UpdateRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleRequest,UpdateRuleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Inserts or deletes <a>Predicate</a> objects in a <code>Rule</code>. Each <code>Predicate</code>
        /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
        /// specifies the web requests that you want to allow, block, or count. If you add more
        /// than one predicate to a <code>Rule</code>, a request must match all of the specifications
        /// to be allowed, blocked, or counted. For example, suppose you add the following to
        /// a <code>Rule</code>: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A <code>ByteMatchSet</code> that matches the value <code>BadBot</code> in the <code>User-Agent</code>
        /// header
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
        /// to block requests that satisfy the <code>Rule</code>. For a request to be blocked,
        /// the <code>User-Agent</code> header in the request must contain the value <code>BadBot</code>
        /// <i>and</i> the request must originate from the IP address 192.0.2.44.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>Rule</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the <code>Rule</code>. See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRule</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRule</code> request to add predicates to the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <code>ByteMatchSet</code> or <code>IPSet</code> with another,
        /// you delete the existing one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="ruleId">The <code>RuleId</code> of the <code>Rule</code> that you want to update. <code>RuleId</code> is returned by <code>CreateRule</code> and by <a>ListRules</a>.</param>
        /// <param name="updates">An array of <code>RuleUpdate</code> objects that you want to insert into or delete from a <a>Rule</a>. For more information, see the applicable data types: <ul> <li>  <a>RuleUpdate</a>: Contains <code>Action</code> and <code>Predicate</code>  </li> <li>  <a>Predicate</a>: Contains <code>DataId</code>, <code>Negated</code>, and <code>Type</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
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
        /// Initiates the asynchronous execution of the UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleRequest,UpdateRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuleGroup


        /// <summary>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <code>RuleGroup</code>.
        /// 
        ///  
        /// <para>
        /// You can only insert <code>REGULAR</code> rules into a rule group.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of ten rules per rule group.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>RuleGroup</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the <code>Rules</code> that you want to include in the <code>RuleGroup</code>.
        /// See <a>CreateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateRuleGroup</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateRuleGroup</code> request to add <code>Rules</code> to the <code>RuleGroup</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update a <code>WebACL</code> that contains the <code>RuleGroup</code>.
        /// See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to replace one <code>Rule</code> with another, you delete the existing
        /// one and add the new one.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var marshaller = UpdateRuleGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleGroupRequest,UpdateRuleGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRuleGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleGroupRequest,UpdateRuleGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSizeConstraintSet


        /// <summary>
        /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
        /// For each <code>SizeConstraint</code> object, you specify the following values: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Whether to insert or delete the object from the array. If you want to change a <code>SizeConstraintSetUpdate</code>
        /// object, you delete the existing object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The part of a web request that you want AWS WAF to evaluate, such as the length of
        /// a query string or the length of the <code>User-Agent</code> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether to perform any transformations on the request, such as converting it to lowercase,
        /// before checking its length. Note that transformations of the request body are not
        /// supported because the AWS resource forwards only the first <code>8192</code> bytes
        /// of your request to AWS WAF.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <code>ComparisonOperator</code> used for evaluating the selected part of the request
        /// against the specified <code>Size</code>, such as equals, greater than, less than,
        /// and so on.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
        /// The length is computed after applying the transformation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, you can add a <code>SizeConstraintSetUpdate</code> object that matches
        /// web requests in which the length of the <code>User-Agent</code> header is greater
        /// than 100 bytes. You can then configure AWS WAF to block those requests.
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SizeConstraintSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a <code>SizeConstraintSet.</code> For more information, see <a>CreateSizeConstraintSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <code>UpdateSizeConstraintSet</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSizeConstraintSet</code> request to specify the part of the
        /// request that you want AWS WAF to inspect (for example, the header or the URI) and
        /// the value that you want AWS WAF to watch for.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFStaleDataException">
        /// The operation failed because you tried to create, update, or delete an object by using
        /// a change token that has already been used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateSizeConstraintSet">REST API Reference for UpdateSizeConstraintSet Operation</seealso>
        public virtual UpdateSizeConstraintSetResponse UpdateSizeConstraintSet(UpdateSizeConstraintSetRequest request)
        {
            var marshaller = UpdateSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = UpdateSizeConstraintSetResponseUnmarshaller.Instance;

            return Invoke<UpdateSizeConstraintSetRequest,UpdateSizeConstraintSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSizeConstraintSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSizeConstraintSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateSizeConstraintSet">REST API Reference for UpdateSizeConstraintSet Operation</seealso>
        public virtual Task<UpdateSizeConstraintSetResponse> UpdateSizeConstraintSetAsync(UpdateSizeConstraintSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSizeConstraintSetRequestMarshaller.Instance;
            var unmarshaller = UpdateSizeConstraintSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSizeConstraintSetRequest,UpdateSizeConstraintSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSqlInjectionMatchSet


        /// <summary>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <code>SqlInjectionMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>SqlInjectionMatchTuple</code>, you delete the existing
        /// object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>SqlInjectionMatchSet</code> objects to specify which CloudFront requests
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <code>SqlInjectionMatchSet</code> with the applicable settings, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSqlInjectionMatchSet</code> request to specify the parts of
        /// web requests that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <code>SqlInjectionMatchSet</code> that you want to update. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="updates">An array of <code>SqlInjectionMatchSetUpdate</code> objects that you want to insert into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>SqlInjectionMatchSetUpdate</a>: Contains <code>Action</code> and <code>SqlInjectionMatchTuple</code>  </li> <li>  <a>SqlInjectionMatchTuple</a>: Contains <code>FieldToMatch</code> and <code>TextTransformation</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
        /// <param name="changeToken">The value returned by the most recent call to <a>GetChangeToken</a>.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(string sqlInjectionMatchSetId, List<SqlInjectionMatchSetUpdate> updates, string changeToken)
        {
            var request = new UpdateSqlInjectionMatchSetRequest();
            request.SqlInjectionMatchSetId = sqlInjectionMatchSetId;
            request.Updates = updates;
            request.ChangeToken = changeToken;
            return UpdateSqlInjectionMatchSet(request);
        }


        /// <summary>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <code>SqlInjectionMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>SqlInjectionMatchTuple</code>, you delete the existing
        /// object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>SqlInjectionMatchSet</code> objects to specify which CloudFront requests
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <code>SqlInjectionMatchSet</code> with the applicable settings, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSqlInjectionMatchSet</code> request to specify the parts of
        /// web requests that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateSqlInjectionMatchSetResponse UpdateSqlInjectionMatchSet(UpdateSqlInjectionMatchSetRequest request)
        {
            var marshaller = UpdateSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateSqlInjectionMatchSetRequest,UpdateSqlInjectionMatchSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Inserts or deletes <a>SqlInjectionMatchTuple</a> objects (filters) in a <a>SqlInjectionMatchSet</a>.
        /// For each <code>SqlInjectionMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>SqlInjectionMatchTuple</code>, you delete the existing
        /// object and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for snippets of malicious SQL code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>SqlInjectionMatchSet</code> objects to specify which CloudFront requests
        /// you want to allow, block, or count. For example, if you're receiving requests that
        /// contain snippets of SQL code in the query string and you want to block the requests,
        /// you can create a <code>SqlInjectionMatchSet</code> with the applicable settings, and
        /// then configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure a <code>SqlInjectionMatchSet</code>, perform the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateSqlInjectionMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateSqlInjectionMatchSet</code> request to specify the parts of
        /// web requests that you want AWS WAF to inspect for snippets of SQL code.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="sqlInjectionMatchSetId">The <code>SqlInjectionMatchSetId</code> of the <code>SqlInjectionMatchSet</code> that you want to update. <code>SqlInjectionMatchSetId</code> is returned by <a>CreateSqlInjectionMatchSet</a> and by <a>ListSqlInjectionMatchSets</a>.</param>
        /// <param name="updates">An array of <code>SqlInjectionMatchSetUpdate</code> objects that you want to insert into or delete from a <a>SqlInjectionMatchSet</a>. For more information, see the applicable data types: <ul> <li>  <a>SqlInjectionMatchSetUpdate</a>: Contains <code>Action</code> and <code>SqlInjectionMatchTuple</code>  </li> <li>  <a>SqlInjectionMatchTuple</a>: Contains <code>FieldToMatch</code> and <code>TextTransformation</code>  </li> <li>  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code>  </li> </ul></param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// Initiates the asynchronous execution of the UpdateSqlInjectionMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSqlInjectionMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateSqlInjectionMatchSet">REST API Reference for UpdateSqlInjectionMatchSet Operation</seealso>
        public virtual Task<UpdateSqlInjectionMatchSetResponse> UpdateSqlInjectionMatchSetAsync(UpdateSqlInjectionMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSqlInjectionMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateSqlInjectionMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSqlInjectionMatchSetRequest,UpdateSqlInjectionMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateWebACL


        /// <summary>
        /// Inserts or deletes <a>ActivatedRule</a> objects in a <code>WebACL</code>. Each <code>Rule</code>
        /// identifies web requests that you want to allow, block, or count. When you update a
        /// <code>WebACL</code>, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A default action for the <code>WebACL</code>, either <code>ALLOW</code> or <code>BLOCK</code>.
        /// AWS WAF performs the default action if a request doesn't match the criteria in any
        /// of the <code>Rules</code> in a <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Rules</code> that you want to add and/or delete. If you want to replace
        /// one <code>Rule</code> with another, you delete the existing <code>Rule</code> and
        /// add the new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each <code>Rule</code>, whether you want AWS WAF to allow requests, block requests,
        /// or count requests that match the conditions in the <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order in which you want AWS WAF to evaluate the <code>Rules</code> in a <code>WebACL</code>.
        /// If you add more than one <code>Rule</code> to a <code>WebACL</code>, AWS WAF evaluates
        /// each request against the <code>Rules</code> in order based on the value of <code>Priority</code>.
        /// (The <code>Rule</code> that has the lowest value for <code>Priority</code> is evaluated
        /// first.) When a web request matches all of the predicates (such as <code>ByteMatchSets</code>
        /// and <code>IPSets</code>) in a <code>Rule</code>, AWS WAF immediately takes the corresponding
        /// action, allow or block, and doesn't evaluate the request against the remaining <code>Rules</code>
        /// in the <code>WebACL</code>, if any. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create and configure a <code>WebACL</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create and update the predicates that you want to include in <code>Rules</code>. For
        /// more information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
        /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update the <code>Rules</code> that you want to include in the <code>WebACL</code>.
        /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <code>WebACL</code>. See <a>CreateWebACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateWebACL</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateWebACL</code> request to specify the <code>Rules</code> that
        /// you want to include in the <code>WebACL</code>, to specify the default action, and
        /// to associate the <code>WebACL</code> with a CloudFront distribution. 
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
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        /// You tried to delete a <code>ByteMatchSet</code> that is still referenced by a <code>Rule</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a <code>Rule</code> that is still referenced by a <code>WebACL</code>.
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
        public virtual UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request)
        {
            var marshaller = UpdateWebACLRequestMarshaller.Instance;
            var unmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return Invoke<UpdateWebACLRequest,UpdateWebACLResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual Task<UpdateWebACLResponse> UpdateWebACLAsync(UpdateWebACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateWebACLRequestMarshaller.Instance;
            var unmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWebACLRequest,UpdateWebACLResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateXssMatchSet


        /// <summary>
        /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
        /// For each <code>XssMatchTuple</code> object, you specify the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Action</code>: Whether to insert the object into or delete the object from
        /// the array. To change a <code>XssMatchTuple</code>, you delete the existing object
        /// and add a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldToMatch</code>: The part of web requests that you want AWS WAF to inspect
        /// and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TextTransformation</code>: Which text transformation, if any, to perform on
        /// the web request before inspecting the request for cross-site scripting attacks.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You use <code>XssMatchSet</code> objects to specify which CloudFront requests you
        /// want to allow, block, or count. For example, if you're receiving requests that contain
        /// cross-site scripting attacks in the request body and you want to block the requests,
        /// you can create an <code>XssMatchSet</code> with the applicable settings, and then
        /// configure AWS WAF to block the requests. 
        /// </para>
        ///  
        /// <para>
        /// To create and configure an <code>XssMatchSet</code>, perform the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit a <a>CreateXssMatchSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
        /// parameter of an <a>UpdateIPSet</a> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit an <code>UpdateXssMatchSet</code> request to specify the parts of web requests
        /// that you want AWS WAF to inspect for cross-site scripting attacks.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
        /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
        /// Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet service method.</param>
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
        /// You tried to remove a <code>Rule</code> from a <code>WebACL</code>, but the <code>Rule</code>
        /// isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove an IP address from an <code>IPSet</code>, but the IP address isn't
        /// in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to remove a <code>ByteMatchTuple</code> from a <code>ByteMatchSet</code>,
        /// but the <code>ByteMatchTuple</code> isn't in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to a <code>WebACL</code>, but the <code>Rule</code>
        /// already exists in the specified <code>WebACL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to an <code>IPSet</code>, but the IP address already
        /// exists in the specified <code>IPSet</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to a <code>ByteMatchSet</code>, but
        /// the <code>ByteMatchTuple</code> already exists in the specified <code>WebACL</code>.
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
        /// You tried to update an object (<code>ByteMatchSet</code>, <code>IPSet</code>, <code>Rule</code>,
        /// or <code>WebACL</code>) using an action other than <code>INSERT</code> or <code>DELETE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>WebACL</code> with a <code>DefaultAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to create a <code>RateBasedRule</code> with a <code>RateKey</code> value
        /// other than <code>IP</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>WafAction</code> <code>Type</code>
        /// other than <code>ALLOW</code>, <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>FieldToMatch</code> <code>Type</code>
        /// other than HEADER, METHOD, QUERY_STRING, URI, or BODY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>ByteMatchSet</code> with a <code>Field</code> of <code>HEADER</code>
        /// but no value for <code>Data</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFLimitsExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>WebACL</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFRegional.Model.WAFNonexistentContainerException">
        /// The operation failed because you tried to add an object to or delete an object from
        /// another object that doesn't exist. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You tried to add a <code>Rule</code> to or delete a <code>Rule</code> from a <code>WebACL</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchSet</code> to or delete a <code>ByteMatchSet</code>
        /// from a <code>Rule</code> that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add an IP address to or delete an IP address from an <code>IPSet</code>
        /// that doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to add a <code>ByteMatchTuple</code> to or delete a <code>ByteMatchTuple</code>
        /// from a <code>ByteMatchSet</code> that doesn't exist.
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
        public virtual UpdateXssMatchSetResponse UpdateXssMatchSet(UpdateXssMatchSetRequest request)
        {
            var marshaller = UpdateXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateXssMatchSetResponseUnmarshaller.Instance;

            return Invoke<UpdateXssMatchSetRequest,UpdateXssMatchSetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateXssMatchSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateXssMatchSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/waf-regional-2016-11-28/UpdateXssMatchSet">REST API Reference for UpdateXssMatchSet Operation</seealso>
        public virtual Task<UpdateXssMatchSetResponse> UpdateXssMatchSetAsync(UpdateXssMatchSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateXssMatchSetRequestMarshaller.Instance;
            var unmarshaller = UpdateXssMatchSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateXssMatchSetRequest,UpdateXssMatchSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}