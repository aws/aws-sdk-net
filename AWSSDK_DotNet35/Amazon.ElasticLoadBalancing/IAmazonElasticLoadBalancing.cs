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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Interface for accessing ElasticLoadBalancing
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// Elastic Load Balancing automatically distributes incoming web traffic across multiple
    /// Amazon EC2 instances.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing actions and commands are <i>idempotent</i>, which means
    /// that they complete no more than one time. If you repeat a request or a command, the
    /// action succeeds with a 200 OK response code.
    /// </para>
    ///  
    /// <para>
    /// For detailed information about the features of Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenarios.html">Managing
    /// Load Balancers</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticLoadBalancing : IDisposable
    {

        
        #region  AddTags

        /// <summary>
        /// Adds the specified tags to the specified load balancer. Each load balancer can have
        /// a maximum of 10 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the load balancer, <code>AddTags</code> updates its value.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#tagging-elb">Tagging</a>
        /// in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from ElasticLoadBalancing.</returns>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ApplySecurityGroupsToLoadBalancer

        /// <summary>
        /// Associates one or more security groups with your load balancer in a virtual private
        /// cloud (VPC). The specified security groups override the previously associated security
        /// groups.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_ApplySG.html">Manage
        /// Security Groups for Amazon VPC</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more of the specified security groups do not exist.
        /// </exception>
        ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplySecurityGroupsToLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ApplySecurityGroupsToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySecurityGroupsToLoadBalancer.</param>
        /// 
        /// <returns>Returns a  ApplySecurityGroupsToLoadBalancerResult from ElasticLoadBalancing.</returns>
        ApplySecurityGroupsToLoadBalancerResponse EndApplySecurityGroupsToLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachLoadBalancerToSubnets

        /// <summary>
        /// Adds one or more subnets to the set of configured subnets for the specified load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer evenly distributes requests across all registered subnets. For more
        /// information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Elastic
        /// Load Balancing in Amazon VPC</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The specified VPC has no associated Internet gateway.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more of the specified subnets do not exist.
        /// </exception>
        AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachLoadBalancerToSubnets
        ///         operation.</returns>
        IAsyncResult BeginAttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancerToSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerToSubnets.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancerToSubnetsResult from ElasticLoadBalancing.</returns>
        AttachLoadBalancerToSubnetsResponse EndAttachLoadBalancerToSubnets(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfigureHealthCheck

        /// <summary>
        /// Specifies the health check settings to use when evaluating the health state of your
        /// back-end instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#healthcheck">Health
        /// Checks</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck service method.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginConfigureHealthCheck(ConfigureHealthCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureHealthCheck.</param>
        /// 
        /// <returns>Returns a  ConfigureHealthCheckResult from ElasticLoadBalancing.</returns>
        ConfigureHealthCheckResponse EndConfigureHealthCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAppCookieStickinessPolicy

        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes that follow that of an
        /// application-generated cookie. This policy can be associated only with HTTP/HTTPS listeners.
        /// 
        ///  
        /// <para>
        /// This policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
        /// except that the lifetime of the special Elastic Load Balancing cookie, <code>AWSELB</code>,
        /// follows the lifetime of the application-generated cookie specified in the policy configuration.
        /// The load balancer only inserts a new stickiness cookie when the application response
        /// includes a new application cookie.
        /// </para>
        ///  
        /// <para>
        /// If the application cookie is explicitly removed or expires, the session stops being
        /// sticky until a new application cookie is issued.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsAppCookies">Application-Controlled
        /// Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppCookieStickinessPolicy
        ///         operation.</returns>
        IAsyncResult BeginCreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a  CreateAppCookieStickinessPolicyResult from ElasticLoadBalancing.</returns>
        CreateAppCookieStickinessPolicyResponse EndCreateAppCookieStickinessPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLBCookieStickinessPolicy

        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime
        /// of the browser (user-agent) or a specified expiration period. This policy can be associated
        /// only with HTTP/HTTPS listeners.
        /// 
        ///  
        /// <para>
        /// When a load balancer implements this policy, the load balancer uses a special cookie
        /// to track the back-end server instance for each request. When the load balancer receives
        /// a request, it first checks to see if this cookie is present in the request. If so,
        /// the load balancer sends the request to the application server specified in the cookie.
        /// If not, the load balancer sends the request to a server that is chosen based on the
        /// existing load-balancing algorithm.
        /// </para>
        ///  
        /// <para>
        /// A cookie is inserted into the response for binding subsequent requests from the same
        /// user to that server. The validity of the cookie is based on the cookie expiration
        /// time, which is specified in the policy configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsLBCookies">Duration-Based
        /// Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLBCookieStickinessPolicy
        ///         operation.</returns>
        IAsyncResult BeginCreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLBCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLBCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a  CreateLBCookieStickinessPolicyResult from ElasticLoadBalancing.</returns>
        CreateLBCookieStickinessPolicyResponse EndCreateLBCookieStickinessPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoadBalancer

        /// <summary>
        /// Creates a load balancer.
        /// 
        ///  
        /// <para>
        /// If the call completes successfully, a new load balancer is created with a unique Domain
        /// Name Service (DNS) name. The DNS name includes the name of the AWS region in which
        /// the load balancer was created. For example, the DNS name might end with either of
        /// the following:
        /// </para>
        ///  <ul> <li> <code>us-east-1.elb.amazonaws.com</code> </li> <li> <code>us-west-2.elb.amazonaws.com</code>
        /// </li> </ul> 
        /// <para>
        /// For information about the AWS regions supported by Elastic Load Balancing, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Regions
        /// and Endpoints</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 20 load balancers per region per account. You can request an
        /// increase for the number of load balancers for your account. For more information,
        /// see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-limits.html">Elastic
        /// Load Balancing Limits</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Elastic Load Balancing supports load balancing your EC2 instances launched in either
        /// the EC2-Classic or EC2-VPC platform. For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForEC2.html">Elastic
        /// Load Balancing in EC2-Classic</a> or <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Elastic
        /// Load Balancing in a VPC</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in AWS Identity and
        /// Access Management (IAM).
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateAccessPointNameException">
        /// The specified load balancer name already exists for this account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSchemeException">
        /// The specified value for the schema is not valid. You can only specify a scheme for
        /// load balancers in a VPC.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more of the specified security groups do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The specified VPC has no associated Internet gateway.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more of the specified subnets do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyAccessPointsException">
        /// The quota for the number of load balancers has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginCreateLoadBalancer(CreateLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancer.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerResult from ElasticLoadBalancing.</returns>
        CreateLoadBalancerResponse EndCreateLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoadBalancerListeners

        /// <summary>
        /// Creates one or more listeners for the specified load balancer. If a listener with
        /// the specified port does not already exist, it is created; otherwise, the properties
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
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in AWS Identity and
        /// Access Management (IAM).
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateListenerException">
        /// A listener already exists for the specified <code>LoadBalancerName</code> and <code>LoadBalancerPort</code>,
        /// but with a different <code>InstancePort</code>, <code>Protocol</code>, or <code>SSLCertificateId</code>.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancerListeners
        ///         operation.</returns>
        IAsyncResult BeginCreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerListenersResult from ElasticLoadBalancing.</returns>
        CreateLoadBalancerListenersResponse EndCreateLoadBalancerListeners(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoadBalancerPolicy

        /// <summary>
        /// Creates a policy with the specified attributes for the specified load balancer.
        /// 
        ///  
        /// <para>
        /// Policies are settings that are saved for your load balancer and that can be applied
        /// to the front-end listener or the back-end application server, depending on the policy
        /// type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancerPolicy
        ///         operation.</returns>
        IAsyncResult BeginCreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerPolicyResult from ElasticLoadBalancing.</returns>
        CreateLoadBalancerPolicyResponse EndCreateLoadBalancerPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoadBalancer

        /// <summary>
        /// Deletes the specified load balancer.
        /// 
        ///  
        /// <para>
        /// If you are attempting to recreate a load balancer, you must reconfigure all settings.
        /// The DNS name associated with a deleted load balancer are no longer usable. The name
        /// and associated DNS record of the deleted load balancer no longer exist and traffic
        /// sent to any of its IP addresses is no longer delivered to back-end instances.
        /// </para>
        ///  
        /// <para>
        /// If the load balancer does not exist or has already been deleted, the call to <code>DeleteLoadBalancer</code>
        /// still succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginDeleteLoadBalancer(DeleteLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerResult from ElasticLoadBalancing.</returns>
        DeleteLoadBalancerResponse EndDeleteLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoadBalancerListeners

        /// <summary>
        /// Deletes the specified listeners from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancerListeners
        ///         operation.</returns>
        IAsyncResult BeginDeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerListenersResult from ElasticLoadBalancing.</returns>
        DeleteLoadBalancerListenersResponse EndDeleteLoadBalancerListeners(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoadBalancerPolicy

        /// <summary>
        /// Deletes the specified policy from the specified load balancer. This policy must not
        /// be enabled for any listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancerPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerPolicyResult from ElasticLoadBalancing.</returns>
        DeleteLoadBalancerPolicyResponse EndDeleteLoadBalancerPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterInstancesFromLoadBalancer

        /// <summary>
        /// Deregisters the specified instances from the specified load balancer. After the instance
        /// is deregistered, it no longer receives traffic from the load balancer.
        /// 
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> to verify that the instance is deregistered
        /// from the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">Deregister
        /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterInstancesFromLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstancesFromLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DeregisterInstancesFromLoadBalancerResult from ElasticLoadBalancing.</returns>
        DeregisterInstancesFromLoadBalancerResponse EndDeregisterInstancesFromLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceHealth

        /// <summary>
        /// Describes the state of the specified instances registered with the specified load
        /// balancer. If no instances are specified, the call describes the state of all instances
        /// registered with the load balancer, not including any terminated instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceHealth
        ///         operation.</returns>
        IAsyncResult BeginDescribeInstanceHealth(DescribeInstanceHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceHealth.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceHealthResult from ElasticLoadBalancing.</returns>
        DescribeInstanceHealthResponse EndDescribeInstanceHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoadBalancerAttributes

        /// <summary>
        /// Describes the attributes for the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute does not exist.
        /// </exception>
        DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerAttributes
        ///         operation.</returns>
        IAsyncResult BeginDescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerAttributesResult from ElasticLoadBalancing.</returns>
        DescribeLoadBalancerAttributesResponse EndDescribeLoadBalancerAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoadBalancerPolicies

        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies();

        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerPolicies
        ///         operation.</returns>
        IAsyncResult BeginDescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerPoliciesResult from ElasticLoadBalancing.</returns>
        DescribeLoadBalancerPoliciesResponse EndDescribeLoadBalancerPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoadBalancerPolicyTypes

        /// <summary>
        /// Describes the specified load balancer policy types.
        /// 
        ///  
        /// <para>
        /// You can use these policy types with <a>CreateLoadBalancerPolicy</a> to create policy
        /// configurations for a load balancer.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes();

        /// <summary>
        /// Describes the specified load balancer policy types.
        /// 
        ///  
        /// <para>
        /// You can use these policy types with <a>CreateLoadBalancerPolicy</a> to create policy
        /// configurations for a load balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerPolicyTypes
        ///         operation.</returns>
        IAsyncResult BeginDescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicyTypes.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerPolicyTypesResult from ElasticLoadBalancing.</returns>
        DescribeLoadBalancerPolicyTypesResponse EndDescribeLoadBalancerPolicyTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoadBalancers

        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DescribeLoadBalancersResponse DescribeLoadBalancers();

        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancers
        ///         operation.</returns>
        IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancersResult from ElasticLoadBalancing.</returns>
        DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Describes the tags associated with the specified load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from ElasticLoadBalancing.</returns>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachLoadBalancerFromSubnets

        /// <summary>
        /// Removes the specified subnets from the set of configured subnets for the load balancer.
        /// 
        ///  
        /// <para>
        /// After a subnet is removed, all EC2 instances registered with the load balancer in
        /// the removed subnet go into the <code>OutOfService</code> state. Then, the load balancer
        /// balances the traffic among the remaining routable subnets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachLoadBalancerFromSubnets
        ///         operation.</returns>
        IAsyncResult BeginDetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachLoadBalancerFromSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancerFromSubnets.</param>
        /// 
        /// <returns>Returns a  DetachLoadBalancerFromSubnetsResult from ElasticLoadBalancing.</returns>
        DetachLoadBalancerFromSubnetsResponse EndDetachLoadBalancerFromSubnets(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableAvailabilityZonesForLoadBalancer

        /// <summary>
        /// Removes the specified Availability Zones from the set of Availability Zones for the
        /// specified load balancer.
        /// 
        ///  
        /// <para>
        /// There must be at least one Availability Zone registered with a load balancer at all
        /// times. After an Availability Zone is removed, all instances registered with the load
        /// balancer that are in the removed Availability Zone go into the <code>OutOfService</code>
        /// state. Then, the load balancer attempts to equally balance the traffic among its remaining
        /// Availability Zones.
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
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAvailabilityZonesForLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DisableAvailabilityZonesForLoadBalancerResult from ElasticLoadBalancing.</returns>
        DisableAvailabilityZonesForLoadBalancerResponse EndDisableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableAvailabilityZonesForLoadBalancer

        /// <summary>
        /// Adds the specified Availability Zones to the set of Availability Zones for the specified
        /// load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer evenly distributes requests across all its registered Availability
        /// Zones that contain instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_AddLBAvailabilityZone.html">Add
        /// Availability Zone</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAvailabilityZonesForLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a  EnableAvailabilityZonesForLoadBalancerResult from ElasticLoadBalancing.</returns>
        EnableAvailabilityZonesForLoadBalancerResponse EndEnableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyLoadBalancerAttributes

        /// <summary>
        /// Modifies the attributes of the specified load balancer.
        /// 
        ///  
        /// <para>
        /// You can modify the load balancer attributes, such as <code>AccessLogs</code>, <code>ConnectionDraining</code>,
        /// and <code>CrossZoneLoadBalancing</code> by either enabling or disabling them. Or,
        /// you can modify the load balancer attribute <code>ConnectionSettings</code> by specifying
        /// an idle connection timeout value for your load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following in the <i>Elastic Load Balancing Developer
        /// Guide</i>:
        /// </para>
        ///  <ul> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#request-routing">Cross-Zone
        /// Load Balancing</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#conn-drain">Connection
        /// Draining</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/access-log-collection.html">Access
        /// Logs</a></li> <li><a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#idle-timeout">Idle
        /// Connection Timeout</a></li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute does not exist.
        /// </exception>
        ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLoadBalancerAttributes
        ///         operation.</returns>
        IAsyncResult BeginModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a  ModifyLoadBalancerAttributesResult from ElasticLoadBalancing.</returns>
        ModifyLoadBalancerAttributesResponse EndModifyLoadBalancerAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterInstancesWithLoadBalancer

        /// <summary>
        /// Adds the specified instances to the specified load balancer.
        /// 
        ///  
        /// <para>
        /// The instance must be a running instance in the same network as the load balancer (EC2-Classic
        /// or the same VPC). If you have EC2-Classic instances and a load balancer in a VPC with
        /// ClassicLink enabled, you can link the EC2-Classic instances to that VPC and then register
        /// the linked EC2-Classic instances with the load balancer in the VPC.
        /// </para>
        ///  
        /// <para>
        /// Note that <code>RegisterInstanceWithLoadBalancer</code> completes when the request
        /// has been registered. Instance registration happens shortly afterwards. To check the
        /// state of the registered instances, use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a>.
        /// </para>
        ///  
        /// <para>
        /// After the instance is registered, it starts receiving traffic and requests from the
        /// load balancer. Any instance that is not in one of the Availability Zones registered
        /// for the load balancer is moved to the <code>OutOfService</code> state. If an Availability
        /// Zone is added to the load balancer later, any instances registered with the load balancer
        /// move to the <code>InService</code> state.
        /// </para>
        ///  
        /// <para>
        /// If you stop an instance registered with a load balancer and then start it, the IP
        /// addresses associated with the instance changes. Elastic Load Balancing cannot recognize
        /// the new IP address, which prevents it from routing traffic to the instances. We recommend
        /// that you use the following sequence: stop the instance, deregister the instance, start
        /// the instance, and then register the instance. To deregister instances from a load
        /// balancer, use <a>DeregisterInstancesFromLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">Deregister
        /// and Register EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterInstancesWithLoadBalancer
        ///         operation.</returns>
        IAsyncResult BeginRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterInstancesWithLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstancesWithLoadBalancer.</param>
        /// 
        /// <returns>Returns a  RegisterInstancesWithLoadBalancerResult from ElasticLoadBalancing.</returns>
        RegisterInstancesWithLoadBalancerResponse EndRegisterInstancesWithLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTags

        /// <summary>
        /// Removes one or more tags from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from ElasticLoadBalancing.</returns>
        RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult);

        #endregion
        
        #region  SetLoadBalancerListenerSSLCertificate

        /// <summary>
        /// Sets the certificate that terminates the specified listener's SSL connections. The
        /// specified certificate replaces any prior certificate that was used on the same load
        /// balancer and port.
        /// 
        ///  
        /// <para>
        /// For more information about updating your SSL certificate, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html">Updating
        /// an SSL Certificate for a Load Balancer</a> in the <i>Elastic Load Balancing Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified SSL ID does not refer to a valid SSL certificate in AWS Identity and
        /// Access Management (IAM).
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// The load balancer does not have a listener configured at the specified port.
        /// </exception>
        SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBalancerListenerSSLCertificate
        ///         operation.</returns>
        IAsyncResult BeginSetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBalancerListenerSSLCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerListenerSSLCertificate.</param>
        /// 
        /// <returns>Returns a  SetLoadBalancerListenerSSLCertificateResult from ElasticLoadBalancing.</returns>
        SetLoadBalancerListenerSSLCertificateResponse EndSetLoadBalancerListenerSSLCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  SetLoadBalancerPoliciesForBackendServer

        /// <summary>
        /// Replaces the set of policies associated with the specified port on which the back-end
        /// server is listening with a new set of policies. At this time, only the back-end server
        /// authentication policy type can be applied to the back-end ports; this policy type
        /// is composed of multiple public key policies.
        /// 
        ///  
        /// <para>
        /// Each time you use <code>SetLoadBalancerPoliciesForBackendServer</code> to enable the
        /// policies, use the <code>PolicyNames</code> parameter to list the policies that you
        /// want to enable.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> to
        /// verify that the policy is associated with the back-end server.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBalancerPoliciesForBackendServer
        ///         operation.</returns>
        IAsyncResult BeginSetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBalancerPoliciesForBackendServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesForBackendServer.</param>
        /// 
        /// <returns>Returns a  SetLoadBalancerPoliciesForBackendServerResult from ElasticLoadBalancing.</returns>
        SetLoadBalancerPoliciesForBackendServerResponse EndSetLoadBalancerPoliciesForBackendServer(IAsyncResult asyncResult);

        #endregion
        
        #region  SetLoadBalancerPoliciesOfListener

        /// <summary>
        /// Associates, updates, or disables a policy with a listener for the specified load balancer.
        /// You can associate multiple policies with a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// The load balancer does not have a listener configured at the specified port.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation on AmazonElasticLoadBalancingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoadBalancerPoliciesOfListener
        ///         operation.</returns>
        IAsyncResult BeginSetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoadBalancerPoliciesOfListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesOfListener.</param>
        /// 
        /// <returns>Returns a  SetLoadBalancerPoliciesOfListenerResult from ElasticLoadBalancing.</returns>
        SetLoadBalancerPoliciesOfListenerResponse EndSetLoadBalancerPoliciesOfListener(IAsyncResult asyncResult);

        #endregion
        
    }
}