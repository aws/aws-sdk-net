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


using System;
using System.Threading;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Implementation for accessing ElasticLoadBalancing
    ///
    /// Elastic Load Balancing 
    /// <para>
    ///  Elastic Load Balancing is a cost-effective and easy to use web service to help you
    /// improve the availability and scalability of your application running on Amazon Elastic
    /// Cloud Compute (Amazon EC2). It makes it easy for you to distribute application loads
    /// between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic
    /// of your application by enabling availability through redundancy. 
    /// </para>
    ///  
    /// <para>
    /// This guide provides detailed information about Elastic Load Balancing actions, data
    /// types, and parameters that can be used for sending a query request. Query requests
    /// are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query parameter
    /// named Action or Operation. Action is used throughout this documentation, although
    /// Operation is supported for backward compatibility with other AWS Query APIs.
    /// </para>
    ///  
    /// <para>
    /// For detailed information on constructing a query request using the actions, data types,
    /// and parameters mentioned in this guide, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/using-query-api.html">Using
    /// the Query API</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For detailed information about Elastic Load Balancing features and their associated
    /// actions, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenarios.html">Using
    /// Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This reference guide is based on the current WSDL, which is available at: <a href="http://ec2-downloads.s3.amazonaws.com/ElasticLoadBalancing.wsdl"></a>
    /// 
    /// </para>
    ///  
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///  
    /// <para>
    /// The examples in this guide assume that your load balancers are created in the US East
    /// (Northern Virginia) region and use us-east-1 as the endpoint.
    /// </para>
    ///  
    /// <para>
    /// You can create your load balancers in other AWS regions. For information about regions
    /// and endpoints supported by Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference. 
    /// </para>
    /// </summary>
    public partial class AmazonElasticLoadBalancingClient : AmazonWebServiceClient, IAmazonElasticLoadBalancing
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  ApplySecurityGroupsToLoadBalancer


        /// <summary>
        /// Associates one or more security groups with your load balancer in Amazon Virtual
        /// Private Cloud (Amazon VPC). The provided security group IDs will override any currently
        /// applied security groups. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_ApplySG.html">Manage
        /// Security Groups in Amazon VPC</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="InvalidSecurityGroupException">
        /// One or more specified security groups do not exist.
        /// </exception>
        public ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeApplySecurityGroupsToLoadBalancer(request, null, null, true);
            return EndApplySecurityGroupsToLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplySecurityGroupsToLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeApplySecurityGroupsToLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySecurityGroupsToLoadBalancer.</param>
        /// 
        /// <returns>Returns a  ApplySecurityGroupsToLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  ApplySecurityGroupsToLoadBalancerResponse EndApplySecurityGroupsToLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< ApplySecurityGroupsToLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  AttachLoadBalancerToSubnets


        /// <summary>
        /// Adds one or more subnets to the set of configured subnets in the Amazon Virtual Private
        /// Cloud (Amazon VPC) for the load balancer. 
        /// 
        ///  
        /// <para>
        ///  The load balancers evenly distribute requests across all of the registered subnets.
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Deploy
        /// Elastic Load Balancing in Amazon VPC</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The VPC has no Internet gateway.
        /// </exception>
        /// <exception cref="SubnetNotFoundException">
        /// One or more subnets were not found.
        /// </exception>
        public AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request)
        {
            IAsyncResult asyncResult = invokeAttachLoadBalancerToSubnets(request, null, null, true);
            return EndAttachLoadBalancerToSubnets(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachLoadBalancerToSubnets
        ///         operation.</returns>
        public IAsyncResult BeginAttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request, AsyncCallback callback, object state)
        {
            return invokeAttachLoadBalancerToSubnets(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerToSubnets.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancerToSubnetsResult from ElasticLoadBalancing.</returns>
        public  AttachLoadBalancerToSubnetsResponse EndAttachLoadBalancerToSubnets(IAsyncResult asyncResult)
        {
            return endOperation< AttachLoadBalancerToSubnetsResponse>(asyncResult);
        }

        IAsyncResult invokeAttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ConfigureHealthCheck


        /// <summary>
        /// Specifies the health check settings to use for evaluating the health state of your
        /// back-end instances. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#healthcheck">Health
        /// Check</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck service method.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        public ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            IAsyncResult asyncResult = invokeConfigureHealthCheck(request, null, null, true);
            return EndConfigureHealthCheck(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureHealthCheck
        ///         operation.</returns>
        public IAsyncResult BeginConfigureHealthCheck(ConfigureHealthCheckRequest request, AsyncCallback callback, object state)
        {
            return invokeConfigureHealthCheck(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureHealthCheck.</param>
        /// 
        /// <returns>Returns a  ConfigureHealthCheckResult from ElasticLoadBalancing.</returns>
        public  ConfigureHealthCheckResponse EndConfigureHealthCheck(IAsyncResult asyncResult)
        {
            return endOperation< ConfigureHealthCheckResponse>(asyncResult);
        }

        IAsyncResult invokeConfigureHealthCheck(ConfigureHealthCheckRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ConfigureHealthCheckRequestMarshaller();
            var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateAppCookieStickinessPolicy


        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes that follow that of an
        /// application-generated cookie. This policy can be associated only with HTTP/HTTPS listeners.
        /// 
        /// 
        ///  
        /// <para>
        ///  This policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
        /// except that the lifetime of the special Elastic Load Balancing cookie follows the
        /// lifetime of the application-generated cookie specified in the policy configuration.
        /// The load balancer only inserts a new stickiness cookie when the application response
        /// includes a new application cookie. 
        /// </para>
        ///  
        /// <para>
        ///  If the application cookie is explicitly removed or expires, the session stops being
        /// sticky until a new application cookie is issued. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsAppCookies">Enabling
        /// Application-Controlled Session Stickiness</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="DuplicatePolicyNameException">
        /// Policy with the same name exists for this load balancer. Please choose another name.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="TooManyPoliciesException">
        /// Quota for number of policies for this load balancer has already been reached.
        /// </exception>
        public CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeCreateAppCookieStickinessPolicy(request, null, null, true);
            return EndCreateAppCookieStickinessPolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppCookieStickinessPolicy
        ///         operation.</returns>
        public IAsyncResult BeginCreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateAppCookieStickinessPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a  CreateAppCookieStickinessPolicyResult from ElasticLoadBalancing.</returns>
        public  CreateAppCookieStickinessPolicyResponse EndCreateAppCookieStickinessPolicy(IAsyncResult asyncResult)
        {
            return endOperation< CreateAppCookieStickinessPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeCreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateLBCookieStickinessPolicy


        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime
        /// of the browser (user-agent) or a specified expiration period. This policy can be associated
        /// only with HTTP/HTTPS listeners. 
        /// 
        ///  
        /// <para>
        ///  When a load balancer implements this policy, the load balancer uses a special cookie
        /// to track the backend server instance for each request. When the load balancer receives
        /// a request, it first checks to see if this cookie is present in the request. If so,
        /// the load balancer sends the request to the application server specified in the cookie.
        /// If not, the load balancer sends the request to a server that is chosen based on the
        /// existing load balancing algorithm. 
        /// </para>
        ///  
        /// <para>
        ///  A cookie is inserted into the response for binding subsequent requests from the same
        /// user to that server. The validity of the cookie is based on the cookie expiration
        /// time, which is specified in the policy configuration. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsLBCookies">Enabling
        /// Duration-Based Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="DuplicatePolicyNameException">
        /// Policy with the same name exists for this load balancer. Please choose another name.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="TooManyPoliciesException">
        /// Quota for number of policies for this load balancer has already been reached.
        /// </exception>
        public CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLBCookieStickinessPolicy(request, null, null, true);
            return EndCreateLBCookieStickinessPolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLBCookieStickinessPolicy
        ///         operation.</returns>
        public IAsyncResult BeginCreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLBCookieStickinessPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLBCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a  CreateLBCookieStickinessPolicyResult from ElasticLoadBalancing.</returns>
        public  CreateLBCookieStickinessPolicyResponse EndCreateLBCookieStickinessPolicy(IAsyncResult asyncResult)
        {
            return endOperation< CreateLBCookieStickinessPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates a new load balancer. 
        /// 
        ///  
        /// <para>
        ///  After the call has completed successfully, a new load balancer is created with a
        /// unique Domain Name Service (DNS) name. The DNS name includes the name of the AWS region
        /// in which the load balance was created. For example, if your load balancer was created
        /// in the United States, the DNS name might end with either of the following:
        /// </para>
        ///  <ul> <li> <i>us-east-1.elb.amazonaws.com</i> (for the Northern Virginia Region) </li>
        /// <li> <i>us-west-1.elb.amazonaws.com</i> (for the Northern California Region) </li>
        /// </ul> 
        /// <para>
        /// For information about the AWS regions supported by Elastic Load Balancing, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Regions
        /// and Endpoints</a>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 20 load balancers per region per account.
        /// </para>
        ///  
        /// <para>
        /// Elastic Load Balancing supports load balancing your Amazon EC2 instances launched
        /// within any one of the following platforms:
        /// </para>
        ///  <ul> <li> <i>EC2-Classic</i> 
        /// <para>
        /// For information on creating and managing your load balancers in EC2-Classic, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForEC2.html">Deploy
        /// Elastic Load Balancing in Amazon EC2-Classic</a>.
        /// </para>
        ///  </li> <li> <i>EC2-VPC</i> 
        /// <para>
        /// For information on creating and managing your load balancers in EC2-VPC, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Deploy
        /// Elastic Load Balancing in Amazon VPC</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in the AWS Identity
        /// and Access Management Service.
        /// </exception>
        /// <exception cref="DuplicateAccessPointNameException">
        /// Load balancer name already exists for this account. Please choose another name.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="InvalidSchemeException">
        /// Invalid value for scheme. Scheme can only be specified for load balancers in VPC.
        /// </exception>
        /// <exception cref="InvalidSecurityGroupException">
        /// One or more specified security groups do not exist.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The VPC has no Internet gateway.
        /// </exception>
        /// <exception cref="SubnetNotFoundException">
        /// One or more subnets were not found.
        /// </exception>
        /// <exception cref="TooManyAccessPointsException">
        /// The quota for the number of load balancers has already been reached.
        /// </exception>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLoadBalancer(request, null, null, true);
            return EndCreateLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginCreateLoadBalancer(CreateLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancer.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  CreateLoadBalancerResponse EndCreateLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< CreateLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLoadBalancer(CreateLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateLoadBalancerListeners


        /// <summary>
        /// Creates one or more listeners on a load balancer for the specified port. If a listener
        /// with the given port does not already exist, it will be created; otherwise, the properties
        /// of the new listener must match the properties of the existing listener. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/us-add-listener.html">Add
        /// a Listener to Your Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in the AWS Identity
        /// and Access Management Service.
        /// </exception>
        /// <exception cref="DuplicateListenerException">
        /// A <code>Listener</code> already exists for the given <code>LoadBalancerName</code>
        /// and <code>LoadBalancerPort</code>, but with a different <code>InstancePort</code>,
        /// <code>Protocol</code>, or <code>SSLCertificateId</code>.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        public CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLoadBalancerListeners(request, null, null, true);
            return EndCreateLoadBalancerListeners(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancerListeners
        ///         operation.</returns>
        public IAsyncResult BeginCreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLoadBalancerListeners(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerListenersResult from ElasticLoadBalancing.</returns>
        public  CreateLoadBalancerListenersResponse EndCreateLoadBalancerListeners(IAsyncResult asyncResult)
        {
            return endOperation< CreateLoadBalancerListenersResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateLoadBalancerPolicy


        /// <summary>
        /// Creates a new policy that contains the necessary attributes depending on the policy
        /// type. Policies are settings that are saved for your load balancer and that can be
        /// applied to the front-end listener, or the back-end application server, depending on
        /// your policy type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="DuplicatePolicyNameException">
        /// Policy with the same name exists for this load balancer. Please choose another name.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <exception cref="TooManyPoliciesException">
        /// Quota for number of policies for this load balancer has already been reached.
        /// </exception>
        public CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLoadBalancerPolicy(request, null, null, true);
            return EndCreateLoadBalancerPolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancerPolicy
        ///         operation.</returns>
        public IAsyncResult BeginCreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLoadBalancerPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerPolicyResult from ElasticLoadBalancing.</returns>
        public  CreateLoadBalancerPolicyResponse EndCreateLoadBalancerPolicy(IAsyncResult asyncResult)
        {
            return endOperation< CreateLoadBalancerPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes the specified load balancer. 
        /// 
        ///  
        /// <para>
        ///  If attempting to recreate the load balancer, you must reconfigure all the settings.
        /// The DNS name associated with a deleted load balancer will no longer be usable. Once
        /// deleted, the name and associated DNS record of the load balancer no longer exist and
        /// traffic sent to any of its IP addresses will no longer be delivered to back-end instances.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To successfully call this API, you must provide the same account credentials as were
        /// used to create the load balancer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLoadBalancer(request, null, null, true);
            return EndDeleteLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLoadBalancer(DeleteLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  DeleteLoadBalancerResponse EndDeleteLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLoadBalancer(DeleteLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteLoadBalancerListeners


        /// <summary>
        /// Deletes listeners from the load balancer for the specified port.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLoadBalancerListeners(request, null, null, true);
            return EndDeleteLoadBalancerListeners(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancerListeners
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLoadBalancerListeners(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerListenersResult from ElasticLoadBalancing.</returns>
        public  DeleteLoadBalancerListenersResponse EndDeleteLoadBalancerListeners(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLoadBalancerListenersResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteLoadBalancerListenersRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteLoadBalancerPolicy


        /// <summary>
        /// Deletes a policy from the load balancer. The specified policy must not be enabled
        /// for any listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        public DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLoadBalancerPolicy(request, null, null, true);
            return EndDeleteLoadBalancerPolicy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancerPolicy
        ///         operation.</returns>
        public IAsyncResult BeginDeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLoadBalancerPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerPolicyResult from ElasticLoadBalancing.</returns>
        public  DeleteLoadBalancerPolicyResponse EndDeleteLoadBalancerPolicy(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLoadBalancerPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeregisterInstancesFromLoadBalancer


        /// <summary>
        /// Deregisters instances from the load balancer. Once the instance is deregistered,
        /// it will stop receiving traffic from the load balancer. 
        /// 
        ///  
        /// <para>
        ///  In order to successfully call this API, the same account credentials as those used
        /// to create the load balancer must be provided. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">De-register
        /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> to verify if the instance is deregistered
        /// from the load balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidEndPointException">
        /// The specified EndPoint is not valid.
        /// </exception>
        public DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeDeregisterInstancesFromLoadBalancer(request, null, null, true);
            return EndDeregisterInstancesFromLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterInstancesFromLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeDeregisterInstancesFromLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstancesFromLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DeregisterInstancesFromLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  DeregisterInstancesFromLoadBalancerResponse EndDeregisterInstancesFromLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< DeregisterInstancesFromLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
            var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeInstanceHealth


        /// <summary>
        /// Returns the current state of the specified instances registered with the specified
        /// load balancer. If no instances are specified, the state of all the instances registered
        /// with the load balancer is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidEndPointException">
        /// The specified EndPoint is not valid.
        /// </exception>
        public DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeInstanceHealth(request, null, null, true);
            return EndDescribeInstanceHealth(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceHealth
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstanceHealth(DescribeInstanceHealthRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeInstanceHealth(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceHealth.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceHealthResult from ElasticLoadBalancing.</returns>
        public  DescribeInstanceHealthResponse EndDescribeInstanceHealth(IAsyncResult asyncResult)
        {
            return endOperation< DescribeInstanceHealthResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeInstanceHealth(DescribeInstanceHealthRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeInstanceHealthRequestMarshaller();
            var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Returns detailed information about all of the attributes associated with the specified
        /// load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute could not be found.
        /// </exception>
        public DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancerAttributes(request, null, null, true);
            return EndDescribeLoadBalancerAttributes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerAttributes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancerAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerAttributesResult from ElasticLoadBalancing.</returns>
        public  DescribeLoadBalancerAttributesResponse EndDescribeLoadBalancerAttributes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLoadBalancerAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicies

        /// <summary>
        /// Returns detailed descriptions of the policies. If you specify a load balancer name,
        /// the action returns the descriptions of all the policies created for the load balancer.
        /// If you specify a policy name associated with your load balancer, the action returns
        /// the description of that policy. If you don't specify a load balancer name, the action
        /// returns descriptions of the specified sample policies, or descriptions of all the
        /// sample policies. The names of the sample policies have the <code>ELBSample-</code>
        /// prefix.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
        public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
        {
            return DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
        }

        /// <summary>
        /// Returns detailed descriptions of the policies. If you specify a load balancer name,
        /// the action returns the descriptions of all the policies created for the load balancer.
        /// If you specify a policy name associated with your load balancer, the action returns
        /// the description of that policy. If you don't specify a load balancer name, the action
        /// returns descriptions of the specified sample policies, or descriptions of all the
        /// sample policies. The names of the sample policies have the <code>ELBSample-</code>
        /// prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
        public DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancerPolicies(request, null, null, true);
            return EndDescribeLoadBalancerPolicies(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerPolicies
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancerPolicies(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerPoliciesResult from ElasticLoadBalancing.</returns>
        public  DescribeLoadBalancerPoliciesResponse EndDescribeLoadBalancerPolicies(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLoadBalancerPoliciesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicyTypes

        /// <summary>
        /// Returns meta-information on the specified load balancer policies defined by the Elastic
        /// Load Balancing service. The policy types that are returned from this action can be
        /// used in a <a>CreateLoadBalancerPolicy</a> action to instantiate specific policy configurations
        /// that will be applied to a load balancer.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
        {
            return DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
        }

        /// <summary>
        /// Returns meta-information on the specified load balancer policies defined by the Elastic
        /// Load Balancing service. The policy types that are returned from this action can be
        /// used in a <a>CreateLoadBalancerPolicy</a> action to instantiate specific policy configurations
        /// that will be applied to a load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        public DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancerPolicyTypes(request, null, null, true);
            return EndDescribeLoadBalancerPolicyTypes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerPolicyTypes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancerPolicyTypes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicyTypes.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerPolicyTypesResult from ElasticLoadBalancing.</returns>
        public  DescribeLoadBalancerPolicyTypesResponse EndDescribeLoadBalancerPolicyTypes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLoadBalancerPolicyTypesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeLoadBalancerPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        /// <summary>
        /// Returns detailed configuration information for all the load balancers created for
        /// the account. If you specify load balancer names, the action returns configuration
        /// information of the specified load balancers.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        public DescribeLoadBalancersResponse DescribeLoadBalancers()
        {
            return DescribeLoadBalancers(new DescribeLoadBalancersRequest());
        }

        /// <summary>
        /// Returns detailed configuration information for all the load balancers created for
        /// the account. If you specify load balancer names, the action returns configuration
        /// information of the specified load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLoadBalancers(request, null, null, true);
            return EndDescribeLoadBalancers(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancers
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLoadBalancers(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancersResult from ElasticLoadBalancing.</returns>
        public  DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLoadBalancersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLoadBalancers(DescribeLoadBalancersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DetachLoadBalancerFromSubnets


        /// <summary>
        /// Removes subnets from the set of configured subnets in the Amazon Virtual Private
        /// Cloud (Amazon VPC) for the load balancer. 
        /// 
        ///  
        /// <para>
        ///  After a subnet is removed all of the EC2 instances registered with the load balancer
        /// that are in the removed subnet will go into the <i>OutOfService</i> state. When a
        /// subnet is removed, the load balancer will balance the traffic among the remaining
        /// routable subnets for the load balancer. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        public DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request)
        {
            IAsyncResult asyncResult = invokeDetachLoadBalancerFromSubnets(request, null, null, true);
            return EndDetachLoadBalancerFromSubnets(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachLoadBalancerFromSubnets
        ///         operation.</returns>
        public IAsyncResult BeginDetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request, AsyncCallback callback, object state)
        {
            return invokeDetachLoadBalancerFromSubnets(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancerFromSubnets.</param>
        /// 
        /// <returns>Returns a  DetachLoadBalancerFromSubnetsResult from ElasticLoadBalancing.</returns>
        public  DetachLoadBalancerFromSubnetsResponse EndDetachLoadBalancerFromSubnets(IAsyncResult asyncResult)
        {
            return endOperation< DetachLoadBalancerFromSubnetsResponse>(asyncResult);
        }

        IAsyncResult invokeDetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
            var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DisableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Removes the specified EC2 Availability Zones from the set of configured Availability
        /// Zones for the load balancer. 
        /// 
        ///  
        /// <para>
        ///  There must be at least one Availability Zone registered with a load balancer at all
        /// times. Once an Availability Zone is removed, all the instances registered with the
        /// load balancer that are in the removed Availability Zone go into the <i>OutOfService</i>
        /// state. Upon Availability Zone removal, the load balancer attempts to equally balance
        /// the traffic among its remaining usable Availability Zones. Trying to remove an Availability
        /// Zone that was not associated with the load balancer does nothing. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_ShrinkLBApp04.html">Disable
        /// an Availability Zone from a Load-Balanced Application</a> in the <i>Elastic Load Balancing
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        public DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeDisableAvailabilityZonesForLoadBalancer(request, null, null, true);
            return EndDisableAvailabilityZonesForLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAvailabilityZonesForLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeDisableAvailabilityZonesForLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DisableAvailabilityZonesForLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  DisableAvailabilityZonesForLoadBalancerResponse EndDisableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< DisableAvailabilityZonesForLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  EnableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Adds one or more EC2 Availability Zones to the load balancer. 
        /// 
        ///  
        /// <para>
        ///  The load balancer evenly distributes requests across all its registered Availability
        /// Zones that contain instances. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_AddLBAvailabilityZone.html">Expand
        /// a Load Balanced Application to an Additional Availability Zone</a> in the <i>Elastic
        /// Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        public EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeEnableAvailabilityZonesForLoadBalancer(request, null, null, true);
            return EndEnableAvailabilityZonesForLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAvailabilityZonesForLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeEnableAvailabilityZonesForLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a  EnableAvailabilityZonesForLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  EnableAvailabilityZonesForLoadBalancerResponse EndEnableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< EnableAvailabilityZonesForLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Modifies the attributes of a specified load balancer.
        /// 
        ///  
        /// <para>
        /// You can modify the load balancer attributes, such as <code>AccessLogs</code>, <code>ConnectionDraining</code>,
        /// and <code>CrossZoneLoadBalancing</code> by either enabling or disabling them. Or,
        /// you can modify the load balancer attribute <code>ConnectionSettings</code>, by specifying
        /// an idle connection timeout value for your load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.htmll#request-routing">Cross-Zone
        /// Load Balancing</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.htmll##conn-drain">Connection
        /// Draining</a></li> <li> <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/access-log-collection.html">Access
        /// Logs</a>.</li> <li> <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#idle-timeout">Connection
        /// Settings</a>.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute could not be found.
        /// </exception>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeModifyLoadBalancerAttributes(request, null, null, true);
            return EndModifyLoadBalancerAttributes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLoadBalancerAttributes
        ///         operation.</returns>
        public IAsyncResult BeginModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyLoadBalancerAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a  ModifyLoadBalancerAttributesResult from ElasticLoadBalancing.</returns>
        public  ModifyLoadBalancerAttributesResponse EndModifyLoadBalancerAttributes(IAsyncResult asyncResult)
        {
            return endOperation< ModifyLoadBalancerAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RegisterInstancesWithLoadBalancer


        /// <summary>
        /// Adds new instances to the load balancer. 
        /// 
        ///  
        /// <para>
        ///  Once the instance is registered, it starts receiving traffic and requests from the
        /// load balancer. Any instance that is not in any of the Availability Zones registered
        /// for the load balancer will be moved to the <i>OutOfService</i> state. It will move
        /// to the <i>InService</i> state when the Availability Zone is added to the load balancer.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When an instance registered with a load balancer is stopped and then restarted, the
        /// IP addresses associated with the instance changes. Elastic Load Balancing cannot recognize
        /// the new IP address, which prevents it from routing traffic to the instances. We recommend
        /// that you de-register your Amazon EC2 instances from your load balancer after you stop
        /// your instance, and then register the load balancer with your instance after you've
        /// restarted. To de-register your instances from load balancer, use <a>DeregisterInstancesFromLoadBalancer</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">De-register
        /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a> action to
        /// check the state of the newly registered instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidEndPointException">
        /// The specified EndPoint is not valid.
        /// </exception>
        public RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            IAsyncResult asyncResult = invokeRegisterInstancesWithLoadBalancer(request, null, null, true);
            return EndRegisterInstancesWithLoadBalancer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterInstancesWithLoadBalancer
        ///         operation.</returns>
        public IAsyncResult BeginRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request, AsyncCallback callback, object state)
        {
            return invokeRegisterInstancesWithLoadBalancer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstancesWithLoadBalancer.</param>
        /// 
        /// <returns>Returns a  RegisterInstancesWithLoadBalancerResult from ElasticLoadBalancing.</returns>
        public  RegisterInstancesWithLoadBalancerResponse EndRegisterInstancesWithLoadBalancer(IAsyncResult asyncResult)
        {
            return endOperation< RegisterInstancesWithLoadBalancerResponse>(asyncResult);
        }

        IAsyncResult invokeRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
            var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  SetLoadBalancerListenerSSLCertificate


        /// <summary>
        /// Sets the certificate that terminates the specified listener's SSL connections. The
        /// specified certificate replaces any prior certificate that was used on the same load
        /// balancer and port. 
        /// 
        ///  
        /// <para>
        /// For more information on updating your SSL certificate, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html">Updating
        /// an SSL Certificate for a Load Balancer</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in the AWS Identity
        /// and Access Management Service.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="ListenerNotFoundException">
        /// Load balancer does not have a listener configured at the given port.
        /// </exception>
        public SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeSetLoadBalancerListenerSSLCertificate(request, null, null, true);
            return EndSetLoadBalancerListenerSSLCertificate(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBalancerListenerSSLCertificate
        ///         operation.</returns>
        public IAsyncResult BeginSetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeSetLoadBalancerListenerSSLCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerListenerSSLCertificate.</param>
        /// 
        /// <returns>Returns a  SetLoadBalancerListenerSSLCertificateResult from ElasticLoadBalancing.</returns>
        public  SetLoadBalancerListenerSSLCertificateResponse EndSetLoadBalancerListenerSSLCertificate(IAsyncResult asyncResult)
        {
            return endOperation< SetLoadBalancerListenerSSLCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeSetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesForBackendServer


        /// <summary>
        /// Replaces the current set of policies associated with a port on which the back-end
        /// server is listening with a new set of policies. After the policies have been created
        /// using <a>CreateLoadBalancerPolicy</a>, they can be applied here as a list. At this
        /// time, only the back-end server authentication policy type can be applied to the back-end
        /// ports; this policy type is composed of multiple public key policies. 
        /// 
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> action
        /// to verify that the policy has been associated with the back-end server.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
        public SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request)
        {
            IAsyncResult asyncResult = invokeSetLoadBalancerPoliciesForBackendServer(request, null, null, true);
            return EndSetLoadBalancerPoliciesForBackendServer(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBalancerPoliciesForBackendServer
        ///         operation.</returns>
        public IAsyncResult BeginSetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request, AsyncCallback callback, object state)
        {
            return invokeSetLoadBalancerPoliciesForBackendServer(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesForBackendServer.</param>
        /// 
        /// <returns>Returns a  SetLoadBalancerPoliciesForBackendServerResult from ElasticLoadBalancing.</returns>
        public  SetLoadBalancerPoliciesForBackendServerResponse EndSetLoadBalancerPoliciesForBackendServer(IAsyncResult asyncResult)
        {
            return endOperation< SetLoadBalancerPoliciesForBackendServerResponse>(asyncResult);
        }

        IAsyncResult invokeSetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesOfListener


        /// <summary>
        /// Associates, updates, or disables a policy with a listener on the load balancer. You
        /// can associate multiple policies with a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="AccessPointNotFoundException">
        /// The specified load balancer could not be found.
        /// </exception>
        /// <exception cref="InvalidConfigurationRequestException">
        /// Requested configuration change is invalid.
        /// </exception>
        /// <exception cref="ListenerNotFoundException">
        /// Load balancer does not have a listener configured at the given port.
        /// </exception>
        /// <exception cref="PolicyNotFoundException">
        /// One or more specified policies were not found.
        /// </exception>
        public SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request)
        {
            IAsyncResult asyncResult = invokeSetLoadBalancerPoliciesOfListener(request, null, null, true);
            return EndSetLoadBalancerPoliciesOfListener(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBalancerPoliciesOfListener
        ///         operation.</returns>
        public IAsyncResult BeginSetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request, AsyncCallback callback, object state)
        {
            return invokeSetLoadBalancerPoliciesOfListener(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesOfListener.</param>
        /// 
        /// <returns>Returns a  SetLoadBalancerPoliciesOfListenerResult from ElasticLoadBalancing.</returns>
        public  SetLoadBalancerPoliciesOfListenerResponse EndSetLoadBalancerPoliciesOfListener(IAsyncResult asyncResult)
        {
            return endOperation< SetLoadBalancerPoliciesOfListenerResponse>(asyncResult);
        }

        IAsyncResult invokeSetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
    }
}