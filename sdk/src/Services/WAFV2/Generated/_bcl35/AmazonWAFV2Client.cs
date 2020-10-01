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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.WAFV2.Model;
using Amazon.WAFV2.Model.Internal.MarshallTransformations;
using Amazon.WAFV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WAFV2
{
    /// <summary>
    /// Implementation for accessing WAFV2
    ///
    /// <note> 
    /// <para>
    /// This is the latest version of the <b>AWS WAF</b> API, released in November, 2019.
    /// The names of the entities that you use to access this API, like endpoints and namespaces,
    /// all have the versioning information added, like "V2" or "v2", to distinguish from
    /// the prior version. We recommend migrating your resources to this version, because
    /// it has a number of significant improvements.
    /// </para>
    ///  
    /// <para>
    /// If you used AWS WAF prior to this release, you can't use this AWS WAFV2 API to access
    /// any AWS WAF resources that you created before. You can access your old rules, web
    /// ACLs, and other AWS WAF resources only through the AWS WAF Classic APIs. The AWS WAF
    /// Classic APIs have retained the prior names, endpoints, and namespaces. 
    /// </para>
    ///  
    /// <para>
    /// For information, including how to migrate your AWS WAF resources to this version,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// AWS WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
    /// that are forwarded to Amazon CloudFront, an Amazon API Gateway REST API, an Application
    /// Load Balancer, or an AWS AppSync GraphQL API. AWS WAF also lets you control access
    /// to your content. Based on conditions that you specify, such as the IP addresses that
    /// requests originate from or the values of query strings, the API Gateway REST API,
    /// CloudFront distribution, the Application Load Balancer, or the AWS AppSync GraphQL
    /// API responds to requests either with the requested content or with an HTTP 403 status
    /// code (Forbidden). You also can configure CloudFront to return a custom error page
    /// when a request is blocked.
    /// </para>
    ///  
    /// <para>
    /// This API guide is for developers who need detailed information about AWS WAF API actions,
    /// data types, and errors. For detailed information about AWS WAF features and an overview
    /// of how to use AWS WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS
    /// WAF Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can make calls using the endpoints listed in <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#waf_region">AWS
    /// Service Endpoints for AWS WAF</a>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For regional applications, you can use any of the endpoints in the list. A regional
    /// application can be an Application Load Balancer (ALB), an API Gateway REST API, or
    /// an AppSync GraphQL API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For AWS CloudFront applications, you must use the API endpoint listed for US East
    /// (N. Virginia): us-east-1.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// We currently provide two versions of the AWS WAF API: this API and the prior versions,
    /// the classic AWS WAF APIs. This new API provides the same functionality as the older
    /// versions, with the following major improvements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You use one API for both global and regional applications. Where you need to distinguish
    /// the scope, you specify a <code>Scope</code> parameter and set it to <code>CLOUDFRONT</code>
    /// or <code>REGIONAL</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can define a Web ACL or rule group with a single call, and update it with a single
    /// call. You define all rule specifications in JSON format, and pass them to your rule
    /// group or Web ACL calls.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The limits AWS WAF places on the use of rules more closely reflects the cost of running
    /// each type of rule. Rule groups include capacity settings, so you know the maximum
    /// cost of a rule group when you use it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonWAFV2Client : AmazonServiceClient, IAmazonWAFV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonWAFV2Metadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonWAFV2Client with the credentials loaded from the application's
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
        public AmazonWAFV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWAFV2Config()) { }

        /// <summary>
        /// Constructs AmazonWAFV2Client with the credentials loaded from the application's
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
        public AmazonWAFV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWAFV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWAFV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(AmazonWAFV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWAFV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonWAFV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWAFV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Credentials and an
        /// AmazonWAFV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(AWSCredentials credentials, AmazonWAFV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWAFV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWAFV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWAFV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonWAFV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWAFV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWAFV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWAFV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWAFV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWAFV2Client Configuration Object</param>
        public AmazonWAFV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWAFV2Config clientConfig)
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


        #region  AssociateWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Associates a Web ACL with a regional application resource, to protect the resource.
        /// A regional application can be an Application Load Balancer (ALB), an API Gateway REST
        /// API, or an AppSync GraphQL API. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To associate a Web ACL, in the CloudFront call <code>UpdateDistribution</code>,
        /// set the web ACL ID to the Amazon Resource Name (ARN) of the Web ACL. For information,
        /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return Invoke<AssociateWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual IAsyncResult BeginAssociateWebACL(AssociateWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWebACL.</param>
        /// 
        /// <returns>Returns a  AssociateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual AssociateWebACLResponse EndAssociateWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWebACLResponse>(asyncResult);
        }

        #endregion
        
        #region  CheckCapacity

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// </para>
        ///  
        /// <para>
        /// AWS WAF uses WCUs to calculate and control the operating resources that are used to
        /// run your rules, rule groups, and web ACLs. AWS WAF calculates capacity differently
        /// for each rule type, to reflect the relative cost of each rule. Simple rules that cost
        /// little to run use fewer WCUs than more complex rules that use more processing power.
        /// Rule group capacity is fixed at creation, which helps users plan their web ACL WCU
        /// usage when they use a rule group. The WCU limit for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        public virtual CheckCapacityResponse CheckCapacity(CheckCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckCapacityResponseUnmarshaller.Instance;

            return Invoke<CheckCapacityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        public virtual IAsyncResult BeginCheckCapacity(CheckCapacityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckCapacityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CheckCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckCapacity.</param>
        /// 
        /// <returns>Returns a  CheckCapacityResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        public virtual CheckCapacityResponse EndCheckCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<CheckCapacityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIPSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure AWS WAF to block
        /// them using an IPSet that lists those IP addresses. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return Invoke<CreateIPSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual IAsyncResult BeginCreateIPSet(CreateIPSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIPSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIPSet.</param>
        /// 
        /// <returns>Returns a  CreateIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse EndCreateIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRegexPatternSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RegexPatternSet</a>, which you reference in a <a>RegexPatternSetReferenceStatement</a>,
        /// to have AWS WAF inspect a web request component for the specified patterns.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<CreateRegexPatternSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual IAsyncResult BeginCreateRegexPatternSet(CreateRegexPatternSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegexPatternSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  CreateRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual CreateRegexPatternSetResponse EndCreateRegexPatternSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRegexPatternSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRuleGroup

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateRuleGroup(CreateRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleGroup.</param>
        /// 
        /// <returns>Returns a  CreateRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual CreateRuleGroupResponse EndCreateRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway REST API, an Application
        /// Load Balancer, or an AWS AppSync GraphQL API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual CreateWebACLResponse CreateWebACL(CreateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return Invoke<CreateWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual IAsyncResult BeginCreateWebACL(CreateWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebACL.</param>
        /// 
        /// <returns>Returns a  CreateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual CreateWebACLResponse EndCreateWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWebACLResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFirewallManagerRuleGroups

        /// <summary>
        /// Deletes all rule groups that are managed by AWS Firewall Manager for the specified
        /// web ACL. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups service method.</param>
        /// 
        /// <returns>The response from the DeleteFirewallManagerRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        public virtual DeleteFirewallManagerRuleGroupsResponse DeleteFirewallManagerRuleGroups(DeleteFirewallManagerRuleGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallManagerRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallManagerRuleGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallManagerRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallManagerRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        public virtual IAsyncResult BeginDeleteFirewallManagerRuleGroups(DeleteFirewallManagerRuleGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallManagerRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallManagerRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallManagerRuleGroups.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallManagerRuleGroupsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        public virtual DeleteFirewallManagerRuleGroupsResponse EndDeleteFirewallManagerRuleGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFirewallManagerRuleGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIPSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>IPSet</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return Invoke<DeleteIPSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteIPSet(DeleteIPSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIPSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIPSet.</param>
        /// 
        /// <returns>Returns a  DeleteIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse EndDeleteIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLoggingConfiguration

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLoggingConfigurationResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual DeleteLoggingConfigurationResponse EndDeleteLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePermissionPolicy

        /// <summary>
        /// Permanently deletes an IAM policy from the specified rule group.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        public virtual DeletePermissionPolicyResponse DeletePermissionPolicy(DeletePermissionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionPolicy operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeletePermissionPolicy(DeletePermissionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionPolicy.</param>
        /// 
        /// <returns>Returns a  DeletePermissionPolicyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        public virtual DeletePermissionPolicyResponse EndDeletePermissionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePermissionPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRegexPatternSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRegexPatternSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteRegexPatternSet(DeleteRegexPatternSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegexPatternSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  DeleteRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual DeleteRegexPatternSetResponse EndDeleteRegexPatternSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRegexPatternSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRuleGroup

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteRuleGroup(DeleteRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual DeleteRuleGroupResponse EndDeleteRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only use this if <code>ManagedByFirewallManager</code> is false in the specified
        /// <a>WebACL</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// AWS WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return Invoke<DeleteWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual IAsyncResult BeginDeleteWebACL(DeleteWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebACL.</param>
        /// 
        /// <returns>Returns a  DeleteWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual DeleteWebACLResponse EndDeleteWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWebACLResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeManagedRuleGroup

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        public virtual DescribeManagedRuleGroupResponse DescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeManagedRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeManagedRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeManagedRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedRuleGroup.</param>
        /// 
        /// <returns>Returns a  DescribeManagedRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        public virtual DescribeManagedRuleGroupResponse EndDescribeManagedRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeManagedRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates a Web ACL from a regional application resource. A regional application
        /// can be an Application Load Balancer (ALB), an API Gateway REST API, or an AppSync
        /// GraphQL API. 
        /// </para>
        ///  
        /// <para>
        /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
        /// configuration. To disassociate a Web ACL, provide an empty web ACL ID in the CloudFront
        /// call <code>UpdateDistribution</code>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWebACL(DisassociateWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWebACL.</param>
        /// 
        /// <returns>Returns a  DisassociateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual DisassociateWebACLResponse EndDisassociateWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWebACLResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIPSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return Invoke<GetIPSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual IAsyncResult BeginGetIPSet(GetIPSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIPSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIPSet.</param>
        /// 
        /// <returns>Returns a  GetIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual GetIPSetResponse EndGetIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLoggingConfiguration

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        public virtual GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetLoggingConfiguration(GetLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLoggingConfigurationResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        public virtual GetLoggingConfigurationResponse EndGetLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPermissionPolicy

        /// <summary>
        /// Returns the IAM policy that is attached to the specified rule group.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        public virtual GetPermissionPolicyResponse GetPermissionPolicy(GetPermissionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPermissionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionPolicy operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPermissionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPermissionPolicy(GetPermissionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPermissionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPermissionPolicy.</param>
        /// 
        /// <returns>Returns a  GetPermissionPolicyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        public virtual GetPermissionPolicyResponse EndGetPermissionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPermissionPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRateBasedStatementManagedKeys

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the keys that are currently blocked by a rate-based rule. The maximum number
        /// of managed keys that can be blocked for a single rate-based rule is 10,000. If more
        /// than 10,000 addresses exceed the rate limit, those with the highest rates are blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        public virtual GetRateBasedStatementManagedKeysResponse GetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRateBasedStatementManagedKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance;

            return Invoke<GetRateBasedStatementManagedKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRateBasedStatementManagedKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRateBasedStatementManagedKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        public virtual IAsyncResult BeginGetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRateBasedStatementManagedKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRateBasedStatementManagedKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRateBasedStatementManagedKeys.</param>
        /// 
        /// <returns>Returns a  GetRateBasedStatementManagedKeysResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        public virtual GetRateBasedStatementManagedKeysResponse EndGetRateBasedStatementManagedKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRateBasedStatementManagedKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRegexPatternSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<GetRegexPatternSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual IAsyncResult BeginGetRegexPatternSet(GetRegexPatternSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegexPatternSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  GetRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual GetRegexPatternSetResponse EndGetRegexPatternSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRegexPatternSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRuleGroup

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return Invoke<GetRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginGetRuleGroup(GetRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRuleGroup.</param>
        /// 
        /// <returns>Returns a  GetRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual GetRuleGroupResponse EndGetRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSampledRequests

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
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
        ///  <code>GetSampledRequests</code> returns a time range, which is usually the time range
        /// that you specified. However, if your resource (such as a CloudFront distribution)
        /// received 5,000 requests before the specified time range elapsed, <code>GetSampledRequests</code>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which AWS WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSampledRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return Invoke<GetSampledRequestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSampledRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual IAsyncResult BeginGetSampledRequests(GetSampledRequestsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSampledRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSampledRequestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSampledRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSampledRequests.</param>
        /// 
        /// <returns>Returns a  GetSampledRequestsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual GetSampledRequestsResponse EndGetSampledRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSampledRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the specified <a>WebACL</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual GetWebACLResponse GetWebACL(GetWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return Invoke<GetWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual IAsyncResult BeginGetWebACL(GetWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebACL.</param>
        /// 
        /// <returns>Returns a  GetWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual GetWebACLResponse EndGetWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWebACLResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWebACLForResource

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return Invoke<GetWebACLForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebACLForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual IAsyncResult BeginGetWebACLForResource(GetWebACLForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebACLForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebACLForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebACLForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebACLForResource.</param>
        /// 
        /// <returns>Returns a  GetWebACLForResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual GetWebACLForResourceResponse EndGetWebACLForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWebACLForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableManagedRuleGroups

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all AWS Managed Rules rule groups and the AWS Marketplace managed rule
        /// groups that you're subscribed to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        public virtual ListAvailableManagedRuleGroupsResponse ListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagedRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableManagedRuleGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableManagedRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableManagedRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        public virtual IAsyncResult BeginListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagedRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableManagedRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableManagedRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListAvailableManagedRuleGroupsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        public virtual ListAvailableManagedRuleGroupsResponse EndListAvailableManagedRuleGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableManagedRuleGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIPSets

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return Invoke<ListIPSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIPSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual IAsyncResult BeginListIPSets(ListIPSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIPSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIPSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIPSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIPSets.</param>
        /// 
        /// <returns>Returns a  ListIPSetsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual ListIPSetsResponse EndListIPSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIPSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLoggingConfigurations

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        public virtual ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLoggingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListLoggingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLoggingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoggingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListLoggingConfigurations(ListLoggingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLoggingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoggingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoggingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoggingConfigurations.</param>
        /// 
        /// <returns>Returns a  ListLoggingConfigurationsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        public virtual ListLoggingConfigurationsResponse EndListLoggingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLoggingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRegexPatternSets

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return Invoke<ListRegexPatternSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegexPatternSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegexPatternSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual IAsyncResult BeginListRegexPatternSets(ListRegexPatternSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegexPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegexPatternSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegexPatternSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegexPatternSets.</param>
        /// 
        /// <returns>Returns a  ListRegexPatternSetsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual ListRegexPatternSetsResponse EndListRegexPatternSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRegexPatternSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourcesForWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the regional resources
        /// that are associated with the specified web ACL. If you want the list of AWS CloudFront
        /// resources, use the AWS CloudFront call <code>ListDistributionsByWebACLId</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return Invoke<ListResourcesForWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcesForWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual IAsyncResult BeginListResourcesForWebACL(ListResourcesForWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcesForWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesForWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesForWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesForWebACL.</param>
        /// 
        /// <returns>Returns a  ListResourcesForWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual ListResourcesForWebACLResponse EndListResourcesForWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesForWebACLResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleGroups

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual IAsyncResult BeginListRuleGroups(ListRuleGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListRuleGroupsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual ListRuleGroupsResponse EndListRuleGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// </para>
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
        /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebACLs

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual ListWebACLsResponse ListWebACLs(ListWebACLsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return Invoke<ListWebACLsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebACLs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual IAsyncResult BeginListWebACLs(ListWebACLsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebACLsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebACLsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebACLs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebACLs.</param>
        /// 
        /// <returns>Returns a  ListWebACLsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual ListWebACLsResponse EndListWebACLs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebACLsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLoggingConfiguration

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided.
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
        /// Create the data firehose with a PUT source and in the Region that you are operating.
        /// If you are capturing logs for Amazon CloudFront, always create the firehose in US
        /// East (N. Virginia). 
        /// </para>
        ///  
        /// <para>
        /// Give the data firehose a name that starts with the prefix <code>aws-waf-logs-</code>.
        /// For example, <code>aws-waf-logs-us-east-2-analytics</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not create the data firehose using a <code>Kinesis stream</code> as your source.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Associate that firehose to your web ACL using a <code>PutLoggingConfiguration</code>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
        /// request, AWS WAF will create a service linked role with the necessary permissions
        /// to write logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// AWS WAF is not able to access the service linked role. This can be caused by a previous
        /// <code>PutLoggingConfiguration</code> request, which can lock the service linked role
        /// for about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <code>DeleteServiceLinkedRole</code> request, which can lock
        /// the role for 15 minutes or more. If you recently made a call to <code>DeleteServiceLinkedRole</code>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        public virtual PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutLoggingConfiguration(PutLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutLoggingConfigurationResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        public virtual PutLoggingConfigurationResponse EndPutLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPermissionPolicy

        /// <summary>
        /// Attaches an IAM policy to the specified resource. Use this to share a rule group across
        /// accounts.
        /// 
        ///  
        /// <para>
        /// You must be the owner of the rule group to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// This action is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
        /// must exist in the same region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the rule group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidPermissionPolicyException">
        /// The operation failed because the specified policy isn't in the proper format. 
        /// 
        ///  
        /// <para>
        /// The policy specifications must conform to the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The policy must be composed using IAM Policy version 2012-10-17 or version 2015-01-01.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <code>Effect</code>, <code>Action</code>,
        /// and <code>Principal</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Effect</code> must specify <code>Allow</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Action</code> must specify <code>wafv2:CreateWebACL</code>, <code>wafv2:UpdateWebACL</code>,
        /// and <code>wafv2:PutFirewallManagerRuleGroups</code>. AWS WAF rejects any extra actions
        /// or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <code>Resource</code> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        public virtual PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPermissionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermissionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutPermissionPolicy(PutPermissionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPermissionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPermissionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermissionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermissionPolicy.</param>
        /// 
        /// <returns>Returns a  PutPermissionPolicyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        public virtual PutPermissionPolicyResponse EndPutPermissionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPermissionPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
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
        /// You can tag the AWS resources that you manage through AWS WAF: web ACLs, rule groups,
        /// IP sets, and regex pattern sets. You can't manage or view tags through the AWS WAF
        /// console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Disassociates tags from an AWS resource. Tags are key:value pairs that you can associate
        /// with AWS resources. For example, the tag key might be "customer" and the tag value
        /// might be "companyA." You can specify one or more tags to add to each container. You
        /// can add up to 50 tags to each AWS resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// AWS WAF couldn’t perform your tagging operation because of an internal error. Retry
        /// your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIPSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>IPSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return Invoke<UpdateIPSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIPSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateIPSet(UpdateIPSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIPSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIPSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIPSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIPSet.</param>
        /// 
        /// <returns>Returns a  UpdateIPSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse EndUpdateIPSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIPSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRegexPatternSet

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRegexPatternSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRegexPatternSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateRegexPatternSet(UpdateRegexPatternSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegexPatternSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegexPatternSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRegexPatternSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRegexPatternSet.</param>
        /// 
        /// <returns>Returns a  UpdateRegexPatternSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual UpdateRegexPatternSetResponse EndUpdateRegexPatternSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRegexPatternSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRuleGroup

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>RuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleGroup(UpdateRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRuleGroupResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual UpdateRuleGroupResponse EndUpdateRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWebACL

        /// <summary>
        /// <note> 
        /// <para>
        /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
        /// 2019. For information, including how to migrate your AWS WAF resources from the prior
        /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the specified <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        ///  A Web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has an action defined (allow, block, or count) for requests that match the
        /// statement of the rule. In the Web ACL, you assign a default action to take (allow,
        /// block) for any request that does not match any of the rules. The rules in a Web ACL
        /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
        /// group. You can associate a Web ACL with one or more AWS resources to protect. The
        /// resources can be Amazon CloudFront, an Amazon API Gateway REST API, an Application
        /// Load Balancer, or an AWS AppSync GraphQL API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// AWS WAF couldn’t perform the operation because the resource that you tried to save
        /// is a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but AWS WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because AWS WAF didn't recognize a parameter in the request.
        /// For example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an invalid parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <code>WebACL</code> with a <code>DefaultAction</code> that isn't
        /// among the types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a Web ACL cannot be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// AWS WAF couldn’t perform the operation because the resource that you requested isn’t
        /// valid. Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// AWS WAF couldn’t perform the operation because you exceeded your resource limit. For
        /// example, the maximum number of <code>WebACL</code> objects that you can create for
        /// an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// AWS WAF couldn’t perform the operation because your resource doesn’t exist.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// AWS WAF couldn’t save your changes because you tried to update or delete a resource
        /// that has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// AWS WAF couldn’t retrieve the resource that you requested. Retry your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return Invoke<UpdateWebACLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual IAsyncResult BeginUpdateWebACL(UpdateWebACLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebACLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebACL.</param>
        /// 
        /// <returns>Returns a  UpdateWebACLResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual UpdateWebACLResponse EndUpdateWebACL(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWebACLResponse>(asyncResult);
        }

        #endregion
        
    }
}