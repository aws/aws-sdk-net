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

#pragma warning disable CS1570
namespace Amazon.WAFV2
{
    /// <summary>
    /// <para>Implementation for accessing WAFV2</para>
    ///
    /// WAF  <note> 
    /// <para>
    /// This is the latest version of the <b>WAF</b> API, released in November, 2019. The
    /// names of the entities that you use to access this API, like endpoints and namespaces,
    /// all have the versioning information added, like "V2" or "v2", to distinguish from
    /// the prior version. We recommend migrating your resources to this version, because
    /// it has a number of significant improvements.
    /// </para>
    ///  
    /// <para>
    /// If you used WAF prior to this release, you can't use this WAFV2 API to access any
    /// WAF resources that you created before. WAF Classic support will end on September 30,
    /// 2025. 
    /// </para>
    ///  
    /// <para>
    /// For information about WAF, including how to migrate your WAF Classic resources to
    /// this version, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
    /// Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
    /// that are forwarded to a protected resource. Protected resource types include Amazon
    /// CloudFront distribution, Amazon API Gateway REST API, Application Load Balancer, AppSync
    /// GraphQL API, Amazon Cognito user pool, App Runner service, Amplify application, and
    /// Amazon Web Services Verified Access instance. WAF also lets you control access to
    /// your content, to protect the Amazon Web Services resource that WAF is monitoring.
    /// Based on conditions that you specify, such as the IP addresses that requests originate
    /// from or the values of query strings, the protected resource responds to requests with
    /// either the requested content, an HTTP 403 status code (Forbidden), or with a custom
    /// response. 
    /// </para>
    ///  
    /// <para>
    /// This API guide is for developers who need detailed information about WAF API actions,
    /// data types, and errors. For detailed information about WAF features and guidance for
    /// configuring and using WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/what-is-aws-waf.html">WAF
    /// Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can make calls using the endpoints listed in <a href="https://docs.aws.amazon.com/general/latest/gr/waf.html">WAF
    /// endpoints and quotas</a>. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For regional resources, you can use any of the endpoints in the list. A regional application
    /// can be an Application Load Balancer (ALB), an Amazon API Gateway REST API, an AppSync
    /// GraphQL API, an Amazon Cognito user pool, an App Runner service, or an Amazon Web
    /// Services Verified Access instance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Amazon CloudFront and Amplify, you must use the API endpoint listed for US East
    /// (N. Virginia): us-east-1.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Alternatively, you can use one of the Amazon Web Services SDKs to access an API that's
    /// tailored to the programming language or platform that you're using. For more information,
    /// see <a href="http://aws.amazon.com/tools/#SDKs">Amazon Web Services SDKs</a>.
    /// </para>
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWAFV2EndpointResolver());
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
        /// Associates a web ACL with a resource, to protect the resource. 
        /// 
        ///  
        /// <para>
        /// Use this for all resource types except for Amazon CloudFront distributions. For Amazon
        /// CloudFront, call <c>UpdateDistribution</c> for the distribution and provide the Amazon
        /// Resource Name (ARN) of the web ACL in the web ACL ID. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-AssociateWebACL">Permissions
        /// for AssociateWebACL</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebACL service method.</param>
        /// 
        /// <returns>The response from the AssociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/AssociateWebACL">REST API Reference for AssociateWebACL Operation</seealso>
        public virtual AssociateWebACLResponse AssociateWebACL(AssociateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
        /// of rules. You can use this to check the capacity requirements for the rules you want
        /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// WAF uses WCUs to calculate and control the operating resources that are used to run
        /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
        /// rule type, to reflect the relative cost of each rule. Simple rules that cost little
        /// to run use fewer WCUs than more complex rules that use more processing power. Rule
        /// group capacity is fixed at creation, which helps users plan their web ACL WCU usage
        /// when they use a rule group. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-waf-capacity-units.html">WAF
        /// web ACL capacity units (WCU)</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckCapacity service method.</param>
        /// 
        /// <returns>The response from the CheckCapacity service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CheckCapacity">REST API Reference for CheckCapacity Operation</seealso>
        public virtual CheckCapacityResponse CheckCapacity(CheckCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  CreateAPIKey

        /// <summary>
        /// Creates an API key that contains a set of token domains.
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use a single key for up to 5 domains. After you generate a key, you can copy
        /// it for use in your JavaScript integration. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAPIKey service method.</param>
        /// 
        /// <returns>The response from the CreateAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateAPIKey">REST API Reference for CreateAPIKey Operation</seealso>
        public virtual CreateAPIKeyResponse CreateAPIKey(CreateAPIKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAPIKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAPIKeyResponseUnmarshaller.Instance;

            return Invoke<CreateAPIKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAPIKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAPIKey operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAPIKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateAPIKey">REST API Reference for CreateAPIKey Operation</seealso>
        public virtual IAsyncResult BeginCreateAPIKey(CreateAPIKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAPIKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAPIKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAPIKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAPIKey.</param>
        /// 
        /// <returns>Returns a  CreateAPIKeyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateAPIKey">REST API Reference for CreateAPIKey Operation</seealso>
        public virtual CreateAPIKeyResponse EndCreateAPIKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAPIKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIPSet

        /// <summary>
        /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
        /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
        /// a lot of requests from a ranges of IP addresses, you can configure WAF to block them
        /// using an IPSet that lists those IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        public virtual CreateIPSetResponse CreateIPSet(CreateIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Creates a <a>RegexPatternSet</a>, which you reference in a <a>RegexPatternSetReferenceStatement</a>,
        /// to have WAF inspect a web request component for the specified patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the CreateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRegexPatternSet">REST API Reference for CreateRegexPatternSet Operation</seealso>
        public virtual CreateRegexPatternSetResponse CreateRegexPatternSet(CreateRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Creates a <a>RuleGroup</a> per the specifications provided. 
        /// 
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
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Creates a <a>WebACL</a> per the specifications provided.
        /// 
        ///  
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has a statement that defines what to look for in web requests and an action
        /// that WAF applies to requests that match the statement. In the web ACL, you assign
        /// a default action to take (allow, block) for any request that does not match any of
        /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
        /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
        /// resources to protect. The resource types include Amazon CloudFront distribution, Amazon
        /// API Gateway REST API, Application Load Balancer, AppSync GraphQL API, Amazon Cognito
        /// user pool, App Runner service, Amplify application, and Amazon Web Services Verified
        /// Access instance. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebACL service method.</param>
        /// 
        /// <returns>The response from the CreateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/CreateWebACL">REST API Reference for CreateWebACL Operation</seealso>
        public virtual CreateWebACLResponse CreateWebACL(CreateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  DeleteAPIKey

        /// <summary>
        /// Deletes the specified API key. 
        /// 
        ///  
        /// <para>
        /// After you delete a key, it can take up to 24 hours for WAF to disallow use of the
        /// key in all regions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAPIKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteAPIKey">REST API Reference for DeleteAPIKey Operation</seealso>
        public virtual DeleteAPIKeyResponse DeleteAPIKey(DeleteAPIKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAPIKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAPIKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteAPIKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAPIKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAPIKey operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAPIKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteAPIKey">REST API Reference for DeleteAPIKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteAPIKey(DeleteAPIKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAPIKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAPIKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAPIKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAPIKey.</param>
        /// 
        /// <returns>Returns a  DeleteAPIKeyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteAPIKey">REST API Reference for DeleteAPIKey Operation</seealso>
        public virtual DeleteAPIKeyResponse EndDeleteAPIKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAPIKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFirewallManagerRuleGroups

        /// <summary>
        /// Deletes all rule groups that are managed by Firewall Manager from the specified <a>WebACL</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// You can only use this if <c>ManagedByFirewallManager</c> and <c>RetrofittedByFirewallManager</c>
        /// are both false in the web ACL. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallManagerRuleGroups service method.</param>
        /// 
        /// <returns>The response from the DeleteFirewallManagerRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteFirewallManagerRuleGroups">REST API Reference for DeleteFirewallManagerRuleGroups Operation</seealso>
        public virtual DeleteFirewallManagerRuleGroupsResponse DeleteFirewallManagerRuleGroups(DeleteFirewallManagerRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Deletes the specified <a>IPSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        public virtual DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeletePermissionPolicy">REST API Reference for DeletePermissionPolicy Operation</seealso>
        public virtual DeletePermissionPolicyResponse DeletePermissionPolicy(DeletePermissionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Deletes the specified <a>RegexPatternSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRegexPatternSet">REST API Reference for DeleteRegexPatternSet Operation</seealso>
        public virtual DeleteRegexPatternSetResponse DeleteRegexPatternSet(DeleteRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Deletes the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Deletes the specified <a>WebACL</a>. 
        /// 
        ///  
        /// <para>
        /// You can only use this if <c>ManagedByFirewallManager</c> is false in the web ACL.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Before deleting any web ACL, first disassociate it from all resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve a list of the resources that are associated with a web ACL, use the following
        /// calls:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Amazon CloudFront distributions, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For all other resources, call <a>ListResourcesForWebACL</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To disassociate a resource from a web ACL, use the following calls:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Amazon CloudFront distributions, provide an empty web ACL ID in the CloudFront
        /// call <c>UpdateDistribution</c>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For all other resources, call <a>DisassociateWebACL</a>.
        /// </para>
        ///  </li> </ul> </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebACL service method.</param>
        /// 
        /// <returns>The response from the DeleteWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFAssociatedItemException">
        /// WAF couldn’t perform the operation because your resource is being used by another
        /// resource or it’s associated with another resource.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DeleteWebACL">REST API Reference for DeleteWebACL Operation</seealso>
        public virtual DeleteWebACLResponse DeleteWebACL(DeleteWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  DescribeAllManagedProducts

        /// <summary>
        /// Provides high-level information for the Amazon Web Services Managed Rules rule groups
        /// and Amazon Web Services Marketplace managed rule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAllManagedProducts service method.</param>
        /// 
        /// <returns>The response from the DescribeAllManagedProducts service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeAllManagedProducts">REST API Reference for DescribeAllManagedProducts Operation</seealso>
        public virtual DescribeAllManagedProductsResponse DescribeAllManagedProducts(DescribeAllManagedProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAllManagedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAllManagedProductsResponseUnmarshaller.Instance;

            return Invoke<DescribeAllManagedProductsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAllManagedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAllManagedProducts operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAllManagedProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeAllManagedProducts">REST API Reference for DescribeAllManagedProducts Operation</seealso>
        public virtual IAsyncResult BeginDescribeAllManagedProducts(DescribeAllManagedProductsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAllManagedProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAllManagedProductsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAllManagedProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAllManagedProducts.</param>
        /// 
        /// <returns>Returns a  DescribeAllManagedProductsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeAllManagedProducts">REST API Reference for DescribeAllManagedProducts Operation</seealso>
        public virtual DescribeAllManagedProductsResponse EndDescribeAllManagedProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAllManagedProductsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeManagedProductsByVendor

        /// <summary>
        /// Provides high-level information for the managed rule groups owned by a specific vendor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedProductsByVendor service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedProductsByVendor service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedProductsByVendor">REST API Reference for DescribeManagedProductsByVendor Operation</seealso>
        public virtual DescribeManagedProductsByVendorResponse DescribeManagedProductsByVendor(DescribeManagedProductsByVendorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeManagedProductsByVendorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedProductsByVendorResponseUnmarshaller.Instance;

            return Invoke<DescribeManagedProductsByVendorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeManagedProductsByVendor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedProductsByVendor operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedProductsByVendor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedProductsByVendor">REST API Reference for DescribeManagedProductsByVendor Operation</seealso>
        public virtual IAsyncResult BeginDescribeManagedProductsByVendor(DescribeManagedProductsByVendorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeManagedProductsByVendorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeManagedProductsByVendorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedProductsByVendor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedProductsByVendor.</param>
        /// 
        /// <returns>Returns a  DescribeManagedProductsByVendorResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedProductsByVendor">REST API Reference for DescribeManagedProductsByVendor Operation</seealso>
        public virtual DescribeManagedProductsByVendorResponse EndDescribeManagedProductsByVendor(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeManagedProductsByVendorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeManagedRuleGroup

        /// <summary>
        /// Provides high-level information for a managed rule group, including descriptions of
        /// the rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DescribeManagedRuleGroup">REST API Reference for DescribeManagedRuleGroup Operation</seealso>
        public virtual DescribeManagedRuleGroupResponse DescribeManagedRuleGroup(DescribeManagedRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Disassociates the specified resource from its web ACL association, if it has one.
        /// 
        /// 
        ///  
        /// <para>
        /// Use this for all resource types except for Amazon CloudFront distributions. For Amazon
        /// CloudFront, call <c>UpdateDistribution</c> for the distribution and provide an empty
        /// web ACL ID. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-DisassociateWebACL">Permissions
        /// for DisassociateWebACL</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebACL service method.</param>
        /// 
        /// <returns>The response from the DisassociateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/DisassociateWebACL">REST API Reference for DisassociateWebACL Operation</seealso>
        public virtual DisassociateWebACLResponse DisassociateWebACL(DisassociateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GenerateMobileSdkReleaseUrl

        /// <summary>
        /// Generates a presigned download URL for the specified release of the mobile SDK.
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMobileSdkReleaseUrl service method.</param>
        /// 
        /// <returns>The response from the GenerateMobileSdkReleaseUrl service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        public virtual GenerateMobileSdkReleaseUrlResponse GenerateMobileSdkReleaseUrl(GenerateMobileSdkReleaseUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMobileSdkReleaseUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance;

            return Invoke<GenerateMobileSdkReleaseUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateMobileSdkReleaseUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMobileSdkReleaseUrl operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMobileSdkReleaseUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        public virtual IAsyncResult BeginGenerateMobileSdkReleaseUrl(GenerateMobileSdkReleaseUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMobileSdkReleaseUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMobileSdkReleaseUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMobileSdkReleaseUrl.</param>
        /// 
        /// <returns>Returns a  GenerateMobileSdkReleaseUrlResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GenerateMobileSdkReleaseUrl">REST API Reference for GenerateMobileSdkReleaseUrl Operation</seealso>
        public virtual GenerateMobileSdkReleaseUrlResponse EndGenerateMobileSdkReleaseUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateMobileSdkReleaseUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDecryptedAPIKey

        /// <summary>
        /// Returns your API key in decrypted form. Use this to check the token domains that you
        /// have defined for the key. 
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecryptedAPIKey service method.</param>
        /// 
        /// <returns>The response from the GetDecryptedAPIKey service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetDecryptedAPIKey">REST API Reference for GetDecryptedAPIKey Operation</seealso>
        public virtual GetDecryptedAPIKeyResponse GetDecryptedAPIKey(GetDecryptedAPIKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDecryptedAPIKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDecryptedAPIKeyResponseUnmarshaller.Instance;

            return Invoke<GetDecryptedAPIKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDecryptedAPIKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDecryptedAPIKey operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDecryptedAPIKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetDecryptedAPIKey">REST API Reference for GetDecryptedAPIKey Operation</seealso>
        public virtual IAsyncResult BeginGetDecryptedAPIKey(GetDecryptedAPIKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDecryptedAPIKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDecryptedAPIKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDecryptedAPIKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDecryptedAPIKey.</param>
        /// 
        /// <returns>Returns a  GetDecryptedAPIKeyResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetDecryptedAPIKey">REST API Reference for GetDecryptedAPIKey Operation</seealso>
        public virtual GetDecryptedAPIKeyResponse EndGetDecryptedAPIKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDecryptedAPIKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIPSet

        /// <summary>
        /// Retrieves the specified <a>IPSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        public virtual GetIPSetResponse GetIPSet(GetIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Returns the <a>LoggingConfiguration</a> for the specified web ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetLoggingConfiguration">REST API Reference for GetLoggingConfiguration Operation</seealso>
        public virtual GetLoggingConfigurationResponse GetLoggingConfiguration(GetLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GetManagedRuleSet

        /// <summary>
        /// Retrieves the specified managed rule set. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedRuleSet service method.</param>
        /// 
        /// <returns>The response from the GetManagedRuleSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        public virtual GetManagedRuleSetResponse GetManagedRuleSet(GetManagedRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedRuleSetResponseUnmarshaller.Instance;

            return Invoke<GetManagedRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetManagedRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetManagedRuleSet operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetManagedRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        public virtual IAsyncResult BeginGetManagedRuleSet(GetManagedRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetManagedRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetManagedRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetManagedRuleSet.</param>
        /// 
        /// <returns>Returns a  GetManagedRuleSetResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetManagedRuleSet">REST API Reference for GetManagedRuleSet Operation</seealso>
        public virtual GetManagedRuleSetResponse EndGetManagedRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetManagedRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMobileSdkRelease

        /// <summary>
        /// Retrieves information for the specified mobile SDK release, including release notes
        /// and tags.
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMobileSdkRelease service method.</param>
        /// 
        /// <returns>The response from the GetMobileSdkRelease service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        public virtual GetMobileSdkReleaseResponse GetMobileSdkRelease(GetMobileSdkReleaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMobileSdkReleaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMobileSdkReleaseResponseUnmarshaller.Instance;

            return Invoke<GetMobileSdkReleaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMobileSdkRelease operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMobileSdkRelease operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMobileSdkRelease
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        public virtual IAsyncResult BeginGetMobileSdkRelease(GetMobileSdkReleaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMobileSdkReleaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMobileSdkReleaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMobileSdkRelease operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMobileSdkRelease.</param>
        /// 
        /// <returns>Returns a  GetMobileSdkReleaseResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetMobileSdkRelease">REST API Reference for GetMobileSdkRelease Operation</seealso>
        public virtual GetMobileSdkReleaseResponse EndGetMobileSdkRelease(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMobileSdkReleaseResponse>(asyncResult);
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
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetPermissionPolicy">REST API Reference for GetPermissionPolicy Operation</seealso>
        public virtual GetPermissionPolicyResponse GetPermissionPolicy(GetPermissionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves the IP addresses that are currently blocked by a rate-based rule instance.
        /// This is only available for rate-based rules that aggregate solely on the IP address
        /// or on the forwarded IP address. 
        /// 
        ///  
        /// <para>
        /// The maximum number of addresses that can be blocked for a single rate-based rule instance
        /// is 10,000. If more than 10,000 addresses exceed the rate limit, those with the highest
        /// rates are blocked.
        /// </para>
        ///  
        /// <para>
        /// For a rate-based rule that you've defined inside a rule group, provide the name of
        /// the rule group reference statement in your request, in addition to the rate-based
        /// rule name and the web ACL name. 
        /// </para>
        ///  
        /// <para>
        /// WAF monitors web requests and manages keys independently for each unique combination
        /// of web ACL, optional rule group, and rate-based rule. For example, if you define a
        /// rate-based rule inside a rule group, and then use the rule group in a web ACL, WAF
        /// monitors web requests and manages keys for that web ACL, rule group reference statement,
        /// and rate-based rule instance. If you use the same rule group in a second web ACL,
        /// WAF monitors web requests and manages keys for this second usage completely independent
        /// of your first. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRateBasedStatementManagedKeys service method.</param>
        /// 
        /// <returns>The response from the GetRateBasedStatementManagedKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnsupportedAggregateKeyTypeException">
        /// The rule that you've named doesn't aggregate solely on the IP address or solely on
        /// the forwarded IP address. This call is only available for rate-based rules with an
        /// <c>AggregateKeyType</c> setting of <c>IP</c> or <c>FORWARDED_IP</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRateBasedStatementManagedKeys">REST API Reference for GetRateBasedStatementManagedKeys Operation</seealso>
        public virtual GetRateBasedStatementManagedKeysResponse GetRateBasedStatementManagedKeys(GetRateBasedStatementManagedKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves the specified <a>RegexPatternSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the GetRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRegexPatternSet">REST API Reference for GetRegexPatternSet Operation</seealso>
        public virtual GetRegexPatternSetResponse GetRegexPatternSet(GetRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleGroup service method.</param>
        /// 
        /// <returns>The response from the GetRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetRuleGroup">REST API Reference for GetRuleGroup Operation</seealso>
        public virtual GetRuleGroupResponse GetRuleGroup(GetRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Gets detailed information about a specified number of requests--a sample--that WAF
        /// randomly selects from among the first 5,000 requests that your Amazon Web Services
        /// resource received during a time range that you choose. You can specify a sample size
        /// of up to 500 requests, and you can specify any time range in the previous three hours.
        /// 
        ///  
        /// <para>
        ///  <c>GetSampledRequests</c> returns a time range, which is usually the time range that
        /// you specified. However, if your resource (such as a CloudFront distribution) received
        /// 5,000 requests before the specified time range elapsed, <c>GetSampledRequests</c>
        /// returns an updated time range. This new time range indicates the actual period during
        /// which WAF selected the requests in the sample.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampledRequests service method.</param>
        /// 
        /// <returns>The response from the GetSampledRequests service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetSampledRequests">REST API Reference for GetSampledRequests Operation</seealso>
        public virtual GetSampledRequestsResponse GetSampledRequests(GetSampledRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves the specified <a>WebACL</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACL service method.</param>
        /// 
        /// <returns>The response from the GetWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACL">REST API Reference for GetWebACL Operation</seealso>
        public virtual GetWebACLResponse GetWebACL(GetWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves the <a>WebACL</a> for the specified resource. 
        /// 
        ///  
        /// <para>
        /// This call uses <c>GetWebACL</c>, to verify that your account has permission to access
        /// the retrieved web ACL. If you get an error that indicates that your account isn't
        /// authorized to perform <c>wafv2:GetWebACL</c> on the resource, that error won't be
        /// included in your CloudTrail event history. 
        /// </para>
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, call the CloudFront action <c>GetDistributionConfig</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistributionConfig.html">GetDistributionConfig</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-GetWebACLForResource">Permissions
        /// for GetWebACLForResource</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebACLForResource service method.</param>
        /// 
        /// <returns>The response from the GetWebACLForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/GetWebACLForResource">REST API Reference for GetWebACLForResource Operation</seealso>
        public virtual GetWebACLForResourceResponse GetWebACLForResource(GetWebACLForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  ListAPIKeys

        /// <summary>
        /// Retrieves a list of the API keys that you've defined for the specified scope. 
        /// 
        ///  
        /// <para>
        /// API keys are required for the integration of the CAPTCHA API in your JavaScript client
        /// applications. The API lets you customize the placement and characteristics of the
        /// CAPTCHA puzzle for your end users. For more information about the CAPTCHA JavaScript
        /// integration, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAPIKeys service method.</param>
        /// 
        /// <returns>The response from the ListAPIKeys service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAPIKeys">REST API Reference for ListAPIKeys Operation</seealso>
        public virtual ListAPIKeysResponse ListAPIKeys(ListAPIKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAPIKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAPIKeysResponseUnmarshaller.Instance;

            return Invoke<ListAPIKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAPIKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAPIKeys operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAPIKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAPIKeys">REST API Reference for ListAPIKeys Operation</seealso>
        public virtual IAsyncResult BeginListAPIKeys(ListAPIKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAPIKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAPIKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAPIKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAPIKeys.</param>
        /// 
        /// <returns>Returns a  ListAPIKeysResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAPIKeys">REST API Reference for ListAPIKeys Operation</seealso>
        public virtual ListAPIKeysResponse EndListAPIKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAPIKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableManagedRuleGroups

        /// <summary>
        /// Retrieves an array of managed rule groups that are available for you to use. This
        /// list includes all Amazon Web Services Managed Rules rule groups and all of the Amazon
        /// Web Services Marketplace managed rule groups that you're subscribed to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroups">REST API Reference for ListAvailableManagedRuleGroups Operation</seealso>
        public virtual ListAvailableManagedRuleGroupsResponse ListAvailableManagedRuleGroups(ListAvailableManagedRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  ListAvailableManagedRuleGroupVersions

        /// <summary>
        /// Returns a list of the available versions for the specified managed rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroupVersions service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagedRuleGroupVersions service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        public virtual ListAvailableManagedRuleGroupVersionsResponse ListAvailableManagedRuleGroupVersions(ListAvailableManagedRuleGroupVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableManagedRuleGroupVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableManagedRuleGroupVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableManagedRuleGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagedRuleGroupVersions operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableManagedRuleGroupVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        public virtual IAsyncResult BeginListAvailableManagedRuleGroupVersions(ListAvailableManagedRuleGroupVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableManagedRuleGroupVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableManagedRuleGroupVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableManagedRuleGroupVersions.</param>
        /// 
        /// <returns>Returns a  ListAvailableManagedRuleGroupVersionsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListAvailableManagedRuleGroupVersions">REST API Reference for ListAvailableManagedRuleGroupVersions Operation</seealso>
        public virtual ListAvailableManagedRuleGroupVersionsResponse EndListAvailableManagedRuleGroupVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableManagedRuleGroupVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIPSets

        /// <summary>
        /// Retrieves an array of <a>IPSetSummary</a> objects for the IP sets that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        public virtual ListIPSetsResponse ListIPSets(ListIPSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves an array of your <a>LoggingConfiguration</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoggingConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLoggingConfigurations service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListLoggingConfigurations">REST API Reference for ListLoggingConfigurations Operation</seealso>
        public virtual ListLoggingConfigurationsResponse ListLoggingConfigurations(ListLoggingConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  ListManagedRuleSets

        /// <summary>
        /// Retrieves the managed rule sets that you own. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedRuleSets service method.</param>
        /// 
        /// <returns>The response from the ListManagedRuleSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        public virtual ListManagedRuleSetsResponse ListManagedRuleSets(ListManagedRuleSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedRuleSetsResponseUnmarshaller.Instance;

            return Invoke<ListManagedRuleSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedRuleSets operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        public virtual IAsyncResult BeginListManagedRuleSets(ListManagedRuleSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListManagedRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedRuleSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedRuleSets.</param>
        /// 
        /// <returns>Returns a  ListManagedRuleSetsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListManagedRuleSets">REST API Reference for ListManagedRuleSets Operation</seealso>
        public virtual ListManagedRuleSetsResponse EndListManagedRuleSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedRuleSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMobileSdkReleases

        /// <summary>
        /// Retrieves a list of the available releases for the mobile SDK and the specified device
        /// platform. 
        /// 
        ///  
        /// <para>
        /// The mobile SDK is not generally available. Customers who have access to the mobile
        /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
        /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
        /// client application integration</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMobileSdkReleases service method.</param>
        /// 
        /// <returns>The response from the ListMobileSdkReleases service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        public virtual ListMobileSdkReleasesResponse ListMobileSdkReleases(ListMobileSdkReleasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMobileSdkReleasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMobileSdkReleasesResponseUnmarshaller.Instance;

            return Invoke<ListMobileSdkReleasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMobileSdkReleases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMobileSdkReleases operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMobileSdkReleases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        public virtual IAsyncResult BeginListMobileSdkReleases(ListMobileSdkReleasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMobileSdkReleasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMobileSdkReleasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMobileSdkReleases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMobileSdkReleases.</param>
        /// 
        /// <returns>Returns a  ListMobileSdkReleasesResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListMobileSdkReleases">REST API Reference for ListMobileSdkReleases Operation</seealso>
        public virtual ListMobileSdkReleasesResponse EndListMobileSdkReleases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMobileSdkReleasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRegexPatternSets

        /// <summary>
        /// Retrieves an array of <a>RegexPatternSetSummary</a> objects for the regex pattern
        /// sets that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegexPatternSets service method.</param>
        /// 
        /// <returns>The response from the ListRegexPatternSets service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRegexPatternSets">REST API Reference for ListRegexPatternSets Operation</seealso>
        public virtual ListRegexPatternSetsResponse ListRegexPatternSets(ListRegexPatternSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves an array of the Amazon Resource Names (ARNs) for the resources that are
        /// associated with the specified web ACL. 
        /// 
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions for customer-managed IAM policies</b> 
        /// </para>
        ///  
        /// <para>
        /// This call requires permissions that are specific to the protected resource type. For
        /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-ListResourcesForWebACL">Permissions
        /// for ListResourcesForWebACL</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForWebACL service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListResourcesForWebACL">REST API Reference for ListResourcesForWebACL Operation</seealso>
        public virtual ListResourcesForWebACLResponse ListResourcesForWebACL(ListResourcesForWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves an array of <a>RuleGroupSummary</a> objects for the rule groups that you
        /// manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Retrieves the <a>TagInfoForResource</a> for the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
        /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
        /// the WAF console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebACLs

        /// <summary>
        /// Retrieves an array of <a>WebACLSummary</a> objects for the web ACLs that you manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebACLs service method.</param>
        /// 
        /// <returns>The response from the ListWebACLs service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/ListWebACLs">REST API Reference for ListWebACLs Operation</seealso>
        public virtual ListWebACLsResponse ListWebACLs(ListWebACLsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
        /// according to the configuration provided. 
        /// 
        ///  
        /// <para>
        /// If you configure data protection for the web ACL, the protection applies to the data
        /// that WAF sends to the logs. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation completely replaces any mutable specifications that you already have
        /// for a logging configuration with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify an existing logging configuration, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetLoggingConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete logging configuration specification to this call
        /// </para>
        ///  </li> </ol> </note> <note> 
        /// <para>
        /// You can define one logging destination per web ACL.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can access information about the traffic that WAF inspects using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create your logging destination. You can use an Amazon CloudWatch Logs log group,
        /// an Amazon Simple Storage Service (Amazon S3) bucket, or an Amazon Kinesis Data Firehose.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The name that you give the destination must start with <c>aws-waf-logs-</c>. Depending
        /// on the type of destination, you might need to configure additional settings or permissions.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For configuration requirements and pricing information for each destination type,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Associate your logging destination to your web ACL using a <c>PutLoggingConfiguration</c>
        /// request.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
        /// WAF creates an additional role or policy that is required to write logs to the logging
        /// destination. For an Amazon CloudWatch Logs log group, WAF creates a resource policy
        /// on the log group. For an Amazon S3 bucket, WAF creates a bucket policy. For an Amazon
        /// Kinesis Data Firehose, WAF creates a service-linked role.
        /// </para>
        ///  
        /// <para>
        /// For additional information about web ACL logging, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutLoggingConfiguration service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLogDestinationPermissionIssueException">
        /// The operation failed because you don't have the permissions that your logging configuration
        /// requires. For information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
        /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFServiceLinkedRoleErrorException">
        /// WAF is not able to access the service linked role. This can be caused by a previous
        /// <c>PutLoggingConfiguration</c> request, which can lock the service linked role for
        /// about 20 seconds. Please try your request again. The service linked role can also
        /// be locked by a previous <c>DeleteServiceLinkedRole</c> request, which can lock the
        /// role for 15 minutes or more. If you recently made a call to <c>DeleteServiceLinkedRole</c>,
        /// wait at least 15 minutes and try the request again. If you receive this same exception
        /// again, you will have to wait additional time until the role is unlocked.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutLoggingConfiguration">REST API Reference for PutLoggingConfiguration Operation</seealso>
        public virtual PutLoggingConfigurationResponse PutLoggingConfiguration(PutLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  PutManagedRuleSetVersions

        /// <summary>
        /// Defines the versions of your managed rule set that you are offering to the customers.
        /// Customers see your offerings as managed rule groups with versioning.
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Customers retrieve their managed rule group list by calling <a>ListAvailableManagedRuleGroups</a>.
        /// The name that you provide here for your managed rule set is the name the customer
        /// sees for the corresponding managed rule group. Customers can retrieve the available
        /// versions for a managed rule group by calling <a>ListAvailableManagedRuleGroupVersions</a>.
        /// You provide a rule group specification for each version. For each managed rule set,
        /// you must specify a version that you recommend using. 
        /// </para>
        ///  
        /// <para>
        /// To initiate the expiration of a managed rule group version, use <a>UpdateManagedRuleSetVersionExpiryDate</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedRuleSetVersions service method.</param>
        /// 
        /// <returns>The response from the PutManagedRuleSetVersions service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        public virtual PutManagedRuleSetVersionsResponse PutManagedRuleSetVersions(PutManagedRuleSetVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutManagedRuleSetVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedRuleSetVersionsResponseUnmarshaller.Instance;

            return Invoke<PutManagedRuleSetVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutManagedRuleSetVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutManagedRuleSetVersions operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutManagedRuleSetVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        public virtual IAsyncResult BeginPutManagedRuleSetVersions(PutManagedRuleSetVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutManagedRuleSetVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedRuleSetVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutManagedRuleSetVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutManagedRuleSetVersions.</param>
        /// 
        /// <returns>Returns a  PutManagedRuleSetVersionsResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutManagedRuleSetVersions">REST API Reference for PutManagedRuleSetVersions Operation</seealso>
        public virtual PutManagedRuleSetVersionsResponse EndPutManagedRuleSetVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<PutManagedRuleSetVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPermissionPolicy

        /// <summary>
        /// Use this to share a rule group with other accounts.
        /// 
        ///  
        /// <para>
        /// This action attaches an IAM policy to the specified resource. You must be the owner
        /// of the rule group to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// This action is subject to the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can attach only one policy with each <c>PutPermissionPolicy</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN in the request must be a valid WAF <a>RuleGroup</a> ARN and the rule group
        /// must exist in the same Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user making the request must be the owner of the rule group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a rule group has been shared with your account, you can access it through the call
        /// <c>GetRuleGroup</c>, and you can reference it in <c>CreateWebACL</c> and <c>UpdateWebACL</c>.
        /// Rule groups that are shared with you don't appear in your WAF console rule groups
        /// listing. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPermissionPolicy service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
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
        /// The policy must be composed using IAM Policy version 2012-10-17.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must include specifications for <c>Effect</c>, <c>Action</c>, and <c>Principal</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Effect</c> must specify <c>Allow</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Action</c> must specify <c>wafv2:CreateWebACL</c>, <c>wafv2:UpdateWebACL</c>,
        /// and <c>wafv2:PutFirewallManagerRuleGroups</c> and may optionally specify <c>wafv2:GetRuleGroup</c>.
        /// WAF rejects any extra actions or wildcard actions in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The policy must not include a <c>Resource</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/PutPermissionPolicy">REST API Reference for PutPermissionPolicy Operation</seealso>
        public virtual PutPermissionPolicyResponse PutPermissionPolicy(PutPermissionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Associates tags with the specified Amazon Web Services resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
        /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
        /// the WAF console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Disassociates tags from an Amazon Web Services resource. Tags are key:value pairs
        /// that you can associate with Amazon Web Services resources. For example, the tag key
        /// might be "customer" and the tag value might be "companyA." You can specify one or
        /// more tags to add to each container. You can add up to 50 tags to each Amazon Web Services
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationException">
        /// An error occurred during the tagging operation. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFTagOperationInternalErrorException">
        /// WAF couldn’t perform your tagging operation because of an internal error. Retry your
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIPSet

        /// <summary>
        /// Updates the specified <a>IPSet</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the IP set with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify an IP set, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetIPSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete IP set specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        public virtual UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  UpdateManagedRuleSetVersionExpiryDate

        /// <summary>
        /// Updates the expiration information for your managed rule set. Use this to initiate
        /// the expiration of a managed rule group version. After you initiate expiration for
        /// a version, WAF excludes it from the response to <a>ListAvailableManagedRuleGroupVersions</a>
        /// for the managed rule group. 
        /// 
        ///  <note> 
        /// <para>
        /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
        /// Web Services and Amazon Web Services Marketplace sellers. 
        /// </para>
        ///  
        /// <para>
        /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
        /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
        /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedRuleSetVersionExpiryDate service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedRuleSetVersionExpiryDate service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        public virtual UpdateManagedRuleSetVersionExpiryDateResponse UpdateManagedRuleSetVersionExpiryDate(UpdateManagedRuleSetVersionExpiryDateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateManagedRuleSetVersionExpiryDateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedRuleSetVersionExpiryDateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateManagedRuleSetVersionExpiryDate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedRuleSetVersionExpiryDate operation on AmazonWAFV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateManagedRuleSetVersionExpiryDate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        public virtual IAsyncResult BeginUpdateManagedRuleSetVersionExpiryDate(UpdateManagedRuleSetVersionExpiryDateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateManagedRuleSetVersionExpiryDateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedRuleSetVersionExpiryDate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedRuleSetVersionExpiryDate.</param>
        /// 
        /// <returns>Returns a  UpdateManagedRuleSetVersionExpiryDateResult from WAFV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateManagedRuleSetVersionExpiryDate">REST API Reference for UpdateManagedRuleSetVersionExpiryDate Operation</seealso>
        public virtual UpdateManagedRuleSetVersionExpiryDateResponse EndUpdateManagedRuleSetVersionExpiryDate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateManagedRuleSetVersionExpiryDateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRegexPatternSet

        /// <summary>
        /// Updates the specified <a>RegexPatternSet</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the regex pattern set with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a regex pattern set, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetRegexPatternSet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete regex pattern set specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegexPatternSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRegexPatternSet service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRegexPatternSet">REST API Reference for UpdateRegexPatternSet Operation</seealso>
        public virtual UpdateRegexPatternSetResponse UpdateRegexPatternSet(UpdateRegexPatternSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Updates the specified <a>RuleGroup</a>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the rule group with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a rule group, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetRuleGroup</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete rule group specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  A rule group defines a collection of rules to inspect and control web requests that
        /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
        /// capacity limit. If you update a rule group, you must stay within the capacity. This
        /// allows others to reuse the rule group with confidence in its capacity requirements.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Updates the specified <a>WebACL</a>. While updating a web ACL, WAF provides continuous
        /// coverage to the resources that you have associated with the web ACL. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation completely replaces the mutable specifications that you already have
        /// for the web ACL with the ones that you provide to this call. 
        /// </para>
        ///  
        /// <para>
        /// To modify a web ACL, do the following: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Retrieve it by calling <a>GetWebACL</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update its settings as needed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the complete web ACL specification to this call
        /// </para>
        ///  </li> </ol> </note> 
        /// <para>
        ///  A web ACL defines a collection of rules to use to inspect and control web requests.
        /// Each rule has a statement that defines what to look for in web requests and an action
        /// that WAF applies to requests that match the statement. In the web ACL, you assign
        /// a default action to take (allow, block) for any request that does not match any of
        /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
        /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
        /// resources to protect. The resource types include Amazon CloudFront distribution, Amazon
        /// API Gateway REST API, Application Load Balancer, AppSync GraphQL API, Amazon Cognito
        /// user pool, App Runner service, Amplify application, and Amazon Web Services Verified
        /// Access instance. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Temporary inconsistencies during updates</b> 
        /// </para>
        ///  
        /// <para>
        /// When you create or change a web ACL or other WAF resources, the changes take a small
        /// amount of time to propagate to all areas where the resources are stored. The propagation
        /// time can be from a few seconds to a number of minutes. 
        /// </para>
        ///  
        /// <para>
        /// The following are examples of the temporary inconsistencies that you might notice
        /// during change propagation: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// After you create a web ACL, if you try to associate it with a resource, you might
        /// get an exception indicating that the web ACL is unavailable. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add a rule group to a web ACL, the new rule group rules might be in effect
        /// in one area where the web ACL is used and not in another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you change a rule action setting, you might see the old action in some places
        /// and the new action in others. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you add an IP address to an IP set that is in use in a blocking rule, the new
        /// address might be blocked in one area while still allowed in another.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebACL service method.</param>
        /// 
        /// <returns>The response from the UpdateWebACL service method, as returned by WAFV2.</returns>
        /// <exception cref="Amazon.WAFV2.Model.WAFConfigurationWarningException">
        /// The operation failed because you are inspecting the web request body, headers, or
        /// cookies without specifying how to handle oversize components. Rules that inspect the
        /// body must either provide an <c>OversizeHandling</c> configuration or they must be
        /// preceded by a <c>SizeConstraintStatement</c> that blocks the body content from being
        /// too large. Rules that inspect the headers or cookies must provide an <c>OversizeHandling</c>
        /// configuration. 
        /// 
        ///  
        /// <para>
        /// Provide the handling configuration and retry your operation.
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can suppress this warning by adding the following tag to the resource
        /// that you provide to this operation: <c>Tag</c> (key:<c>WAF:OversizeFieldsHandlingConstraintOptOut</c>,
        /// value:<c>true</c>).
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFDuplicateItemException">
        /// WAF couldn’t perform the operation because the resource that you tried to save is
        /// a duplicate of an existing one.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFExpiredManagedRuleGroupVersionException">
        /// The operation failed because the specified version for the managed rule group has
        /// expired. You can retrieve the available versions for the managed rule group by calling
        /// <a>ListAvailableManagedRuleGroupVersions</a>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInternalErrorException">
        /// Your request is valid, but WAF couldn’t perform the operation because of a system
        /// problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidOperationException">
        /// The operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidParameterException">
        /// The operation failed because WAF didn't recognize a parameter in the request. For
        /// example: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified a parameter name or value that isn't valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your nested statement isn't valid. You might have tried to nest a statement that can’t
        /// be nested. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a <c>WebACL</c> with a <c>DefaultAction</c> that isn't among the
        /// types available at <a>DefaultAction</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource with
        /// which a web ACL can't be associated.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFInvalidResourceException">
        /// WAF couldn’t perform the operation because the resource that you requested isn’t valid.
        /// Check the resource, and try again.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFLimitsExceededException">
        /// WAF couldn’t perform the operation because you exceeded your resource limit. For example,
        /// the maximum number of <c>WebACL</c> objects that you can create for an Amazon Web
        /// Services account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFNonexistentItemException">
        /// WAF couldn’t perform the operation because your resource doesn't exist. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFOptimisticLockException">
        /// WAF couldn’t save your changes because you tried to update or delete a resource that
        /// has changed since you last retrieved it. Get the resource again, make any changes
        /// you need to make to the new copy, and retry your operation.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFSubscriptionNotFoundException">
        /// You tried to use a managed rule group that's available by subscription, but you aren't
        /// subscribed to it yet.
        /// </exception>
        /// <exception cref="Amazon.WAFV2.Model.WAFUnavailableEntityException">
        /// WAF couldn’t retrieve a resource that you specified for this operation. If you've
        /// just created a resource that you're using in this operation, you might just need to
        /// wait a few minutes. It can take from a few seconds to a number of minutes for changes
        /// to propagate. Verify the resource specifications in your request parameters and then
        /// retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wafv2-2019-07-29/UpdateWebACL">REST API Reference for UpdateWebACL Operation</seealso>
        public virtual UpdateWebACLResponse UpdateWebACL(UpdateWebACLRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var resolver = new AmazonWAFV2EndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}