/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Interface for accessing AmazonElasticLoadBalancing.
    ///  
    ///  Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve the availability
    /// and scalability of your application running on Amazon Elastic Cloud Compute (Amazon EC2). It makes it easy for you to distribute application
    /// loads between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic of your application by enabling availability
    /// through redundancy. </para> <para>This guide provides detailed information about Elastic Load Balancing actions, data types, and parameters
    /// that can be used for sending a query request. Query requests are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query
    /// parameter named Action or Operation. Action is used throughout this documentation, although Operation is supported for backward
    /// compatibility with other AWS Query APIs.</para> <para>For detailed information on constructing a query request using the actions, data
    /// types, and parameters mentioned in this guide, go to <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/using-query-api.html" >Using the Query API</a> in the <i>Elastic
    /// Load Balancing Developer Guide</i> .</para> <para>For detailed information about Elastic Load Balancing features and their associated
    /// actions, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenarios.html" >Using Elastic Load
    /// Balancing</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>This reference guide is based on the current WSDL, which
    /// is available at: <a href="http://elasticloadbalancing.amazonaws.com/doc/2012-06-01/ElasticLoadBalancing.wsdl"
    /// >http://elasticloadbalancing.amazonaws.com/doc/2012-06-01/ElasticLoadBalancing.wsdl</a> </para> <para> <b>Endpoints</b> </para> <para>The
    /// examples in this guide assume that your load balancers are created in the US East (Northern Virginia) region and use us-east-1 as the
    /// endpoint.</para> <para>You can create your load balancers in other AWS regions. For information about regions and endpoints supported by
    /// Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html" >Regions and Endpoints</a> in the
    /// Amazon Web Services General Reference. </para>
    /// </summary>
    public interface AmazonElasticLoadBalancing : IDisposable
    {
        

        #region DescribeLoadBalancerPolicyTypes

        /// <summary>
        /// <para> Returns meta-information on the specified load balancer policies defined by the Elastic Load Balancing service. The policy types
        /// that are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will
        /// be applied to a load balancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyTypeNotFoundException"/>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancerPolicyTypes operation.</returns>
        IAsyncResult BeginDescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicyTypes.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancerPolicyTypesResult from AmazonElasticLoadBalancing.</returns>
        DescribeLoadBalancerPolicyTypesResponse EndDescribeLoadBalancerPolicyTypes(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns meta-information on the specified load balancer policies defined by the Elastic Load Balancing service. The policy types
        /// that are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will
        /// be applied to a load balancer. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyTypeNotFoundException"/>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes();
        
        #endregion
        
    

        #region ConfigureHealthCheck

        /// <summary>
        /// <para> Specifies the health check settings to use for evaluating the health state of your back-end instances. </para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#healthcheck"
        /// >Health Check</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest configureHealthCheckRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ConfigureHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfigureHealthCheck operation.</returns>
        IAsyncResult BeginConfigureHealthCheck(ConfigureHealthCheckRequest configureHealthCheckRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ConfigureHealthCheck"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureHealthCheck.</param>
        /// 
        /// <returns>Returns a ConfigureHealthCheckResult from AmazonElasticLoadBalancing.</returns>
        ConfigureHealthCheckResponse EndConfigureHealthCheck(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DetachLoadBalancerFromSubnets

        /// <summary>
        /// <para> Removes subnets from the set of configured subnets in the Amazon Virtual Private Cloud (Amazon VPC) for the load balancer. </para>
        /// <para> After a subnet is removed all of the EC2 instances registered with the load balancer that are in the removed subnet will go into the
        /// <i>OutOfService</i> state. When a subnet is removed, the load balancer will balance the traffic among the remaining routable subnets for the
        /// load balancer. </para>
        /// </summary>
        /// 
        /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DetachLoadBalancerFromSubnets"/>
        /// </summary>
        /// 
        /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDetachLoadBalancerFromSubnets operation.</returns>
        IAsyncResult BeginDetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DetachLoadBalancerFromSubnets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancerFromSubnets.</param>
        /// 
        /// <returns>Returns a DetachLoadBalancerFromSubnetsResult from AmazonElasticLoadBalancing.</returns>
        DetachLoadBalancerFromSubnetsResponse EndDetachLoadBalancerFromSubnets(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyLoadBalancerAttributes

        /// <summary>
        /// <para>Modifies the attributes of a specified load balancer.</para>
        /// </summary>
        /// 
        /// <param name="modifyLoadBalancerAttributesRequest">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerAttributeNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest modifyLoadBalancerAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ModifyLoadBalancerAttributes"/>
        /// </summary>
        /// 
        /// <param name="modifyLoadBalancerAttributesRequest">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyLoadBalancerAttributes operation.</returns>
        IAsyncResult BeginModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest modifyLoadBalancerAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ModifyLoadBalancerAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a ModifyLoadBalancerAttributesResult from AmazonElasticLoadBalancing.</returns>
        ModifyLoadBalancerAttributesResponse EndModifyLoadBalancerAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLoadBalancerListeners

        /// <summary>
        /// <para> Creates one or more listeners on a load balancer for the specified port. If a listener with the given port does not already exist, it
        /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/us-add-listener.html" >Add a Listener to
        /// Your Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicateListenerException"/>
        /// <exception cref="CertificateNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation
        ///          on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoadBalancerListeners operation.</returns>
        IAsyncResult BeginCreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a CreateLoadBalancerListenersResult from AmazonElasticLoadBalancing.</returns>
        CreateLoadBalancerListenersResponse EndCreateLoadBalancerListeners(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteLoadBalancerListeners

        /// <summary>
        /// <para> Deletes listeners from the load balancer for the specified port. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation
        ///          on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteLoadBalancerListeners operation.</returns>
        IAsyncResult BeginDeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerListeners"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerListeners.</param>
        /// 
        /// <returns>Returns a DeleteLoadBalancerListenersResult from AmazonElasticLoadBalancing.</returns>
        DeleteLoadBalancerListenersResponse EndDeleteLoadBalancerListeners(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateAppCookieStickinessPolicy

        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
        /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
        /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
        /// the policy configuration. The load balancer only inserts a new stickiness cookie when the application response includes a new application
        /// cookie. </para> <para> If the application cookie is explicitly removed or expires, the session stops being sticky until a new application
        /// cookie is issued. </para> <para><b>NOTE:</b> An application client must receive and send two cookies: the application-generated cookie and
        /// the special Elastic Load Balancing cookie named AWSELB. This is the default behavior for many common web browsers. </para> <para>For more
        /// information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsAppCookies"
        /// >Enabling Application-Controlled Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicatePolicyNameException"/>
        /// <exception cref="TooManyPoliciesException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateAppCookieStickinessPolicy operation.</returns>
        IAsyncResult BeginCreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a CreateAppCookieStickinessPolicyResult from AmazonElasticLoadBalancing.</returns>
        CreateAppCookieStickinessPolicyResponse EndCreateAppCookieStickinessPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ApplySecurityGroupsToLoadBalancer

        /// <summary>
        /// <para> Associates one or more security groups with your load balancer in Amazon Virtual Private Cloud (Amazon VPC). The provided security
        /// group IDs will override any currently applied security groups. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_ApplySG.html" >Manage Security Groups in Amazon VPC</a> in
        /// the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          ApplySecurityGroupsToLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="InvalidSecurityGroupException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          ApplySecurityGroupsToLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndApplySecurityGroupsToLoadBalancer operation.</returns>
        IAsyncResult BeginApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ApplySecurityGroupsToLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplySecurityGroupsToLoadBalancer.</param>
        /// 
        /// <returns>Returns a ApplySecurityGroupsToLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        ApplySecurityGroupsToLoadBalancerResponse EndApplySecurityGroupsToLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeLoadBalancerPolicies

        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a load balancer name, the action returns the descriptions of all the
        /// policies created for the load balancer. If you specify a policy name associated with your load balancer, the action returns the description
        /// of that policy. If you don't specify a load balancer name, the action returns descriptions of the specified sample policies, or descriptions
        /// of all the sample policies. The names of the sample policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicies"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancerPolicies operation.</returns>
        IAsyncResult BeginDescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerPolicies.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancerPoliciesResult from AmazonElasticLoadBalancing.</returns>
        DescribeLoadBalancerPoliciesResponse EndDescribeLoadBalancerPolicies(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a load balancer name, the action returns the descriptions of all the
        /// policies created for the load balancer. If you specify a policy name associated with your load balancer, the action returns the description
        /// of that policy. If you don't specify a load balancer name, the action returns descriptions of the specified sample policies, or descriptions
        /// of all the sample policies. The names of the sample policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies();
        
        #endregion
        
    

        #region SetLoadBalancerPoliciesOfListener

        /// <summary>
        /// <para> Associates, updates, or disables a policy with a listener on the load balancer. You can associate multiple policies with a listener.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesOfListener service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="ListenerNotFoundException"/>
        SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesOfListener operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetLoadBalancerPoliciesOfListener operation.</returns>
        IAsyncResult BeginSetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesOfListener.</param>
        /// 
        /// <returns>Returns a SetLoadBalancerPoliciesOfListenerResult from AmazonElasticLoadBalancing.</returns>
        SetLoadBalancerPoliciesOfListenerResponse EndSetLoadBalancerPoliciesOfListener(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisableAvailabilityZonesForLoadBalancer

        /// <summary>
        /// <para> Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the load balancer. </para> <para>
        /// There must be at least one Availability Zone registered with a load balancer at all times. Once an Availability Zone is removed, all the
        /// instances registered with the load balancer that are in the removed Availability Zone go into the <i>OutOfService</i> state. Upon
        /// Availability Zone removal, the load balancer attempts to equally balance the traffic among its remaining usable Availability Zones. Trying
        /// to remove an Availability Zone that was not associated with the load balancer does nothing. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_ShrinkLBApp04.html" >Disable an Availability Zone from a
        /// Load-Balanced Application</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DisableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DisableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DisableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDisableAvailabilityZonesForLoadBalancer operation.</returns>
        IAsyncResult BeginDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DisableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a DisableAvailabilityZonesForLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        DisableAvailabilityZonesForLoadBalancerResponse EndDisableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeInstanceHealth

        /// <summary>
        /// <para> Returns the current state of the specified instances registered with the specified load balancer. If no instances are specified, the
        /// state of all the instances registered with the load balancer is returned. </para> <para><b>NOTE:</b> You must provide the same account
        /// credentials as those that were used to create the load balancer. </para>
        /// </summary>
        /// 
        /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="InvalidInstanceException"/>
        DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest describeInstanceHealthRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInstanceHealth operation.</returns>
        IAsyncResult BeginDescribeInstanceHealth(DescribeInstanceHealthRequest describeInstanceHealthRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceHealth.</param>
        /// 
        /// <returns>Returns a DescribeInstanceHealthResult from AmazonElasticLoadBalancing.</returns>
        DescribeInstanceHealthResponse EndDescribeInstanceHealth(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteLoadBalancerPolicy

        /// <summary>
        /// <para> Deletes a policy from the load balancer. The specified policy must not be enabled for any listeners. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method
        ///          on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteLoadBalancerPolicy operation.</returns>
        IAsyncResult BeginDeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a DeleteLoadBalancerPolicyResult from AmazonElasticLoadBalancing.</returns>
        DeleteLoadBalancerPolicyResponse EndDeleteLoadBalancerPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLoadBalancerPolicy

        /// <summary>
        /// <para> Creates a new policy that contains the necessary attributes depending on the policy type. Policies are settings that are saved for
        /// your load balancer and that can be applied to the front-end listener, or the back-end application server, depending on your policy type.
        /// </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method
        ///          on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyTypeNotFoundException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicatePolicyNameException"/>
        /// <exception cref="TooManyPoliciesException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoadBalancerPolicy operation.</returns>
        IAsyncResult BeginCreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancerPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerPolicy.</param>
        /// 
        /// <returns>Returns a CreateLoadBalancerPolicyResult from AmazonElasticLoadBalancing.</returns>
        CreateLoadBalancerPolicyResponse EndCreateLoadBalancerPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableAvailabilityZonesForLoadBalancer

        /// <summary>
        /// <para> Adds one or more EC2 Availability Zones to the load balancer. </para> <para> The load balancer evenly distributes requests across all
        /// its registered Availability Zones that contain instances. </para> <para><b>NOTE:</b> The new EC2 Availability Zones to be added must be in
        /// the same EC2 Region as the Availability Zones for which the load balancer was created. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_AddLBAvailabilityZone.html" >Expand a Load Balanced
        /// Application to an Additional Availability Zone</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          EnableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.EnableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          EnableAvailabilityZonesForLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndEnableAvailabilityZonesForLoadBalancer operation.</returns>
        IAsyncResult BeginEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.EnableAvailabilityZonesForLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAvailabilityZonesForLoadBalancer.</param>
        /// 
        /// <returns>Returns a EnableAvailabilityZonesForLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        EnableAvailabilityZonesForLoadBalancerResponse EndEnableAvailabilityZonesForLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteLoadBalancer

        /// <summary>
        /// <para> Deletes the specified load balancer. </para> <para> If attempting to recreate the load balancer, you must reconfigure all the
        /// settings. The DNS name associated with a deleted load balancer will no longer be usable. Once deleted, the name and associated DNS record of
        /// the load balancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to back-end instances. </para>
        /// <para> To successfully call this API, you must provide the same account credentials as were used to create the load balancer. </para>
        /// <para><b>NOTE:</b> By design, if the load balancer does not exist or has already been deleted, a call to DeleteLoadBalancer action still
        /// succeeds. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteLoadBalancer operation.</returns>
        IAsyncResult BeginDeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeleteLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancer.</param>
        /// 
        /// <returns>Returns a DeleteLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        DeleteLoadBalancerResponse EndDeleteLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLoadBalancer

        /// <summary>
        /// <para> Creates a new load balancer. </para> <para> After the call has completed successfully, a new load balancer is created with a unique
        /// Domain Name Service (DNS) name. The DNS name includes the name of the AWS region in which the load balance was created. For example, if your
        /// load balancer was created in the United States, the DNS name might end with either of the following:</para>
        /// <ul>
        /// <li> <i>us-east-1.elb.amazonaws.com</i> (for the Northern Virginia Region) </li>
        /// <li> <i>us-west-1.elb.amazonaws.com</i> (for the Northern California Region) </li>
        /// 
        /// </ul>
        /// <para>For information about the AWS regions supported by Elastic Load Balancing, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region" >Regions and Endpoints</a> .</para> <para>You can create up to 10
        /// load balancers per region per account.</para> <para>Elastic Load Balancing supports load balancing your Amazon EC2 instances launched within
        /// any one of the following platforms:</para>
        /// <ul>
        /// <li> <i>EC2-Classic</i> <para>For information on creating and managing your load balancers in EC2-Classic, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForEC2.html" >Deploy Elastic Load Balancing in
        /// Amazon EC2-Classic</a> .</para> </li>
        /// <li> <i>EC2-VPC</i> <para>For information on creating and managing your load balancers in EC2-VPC, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html" >Deploy Elastic Load Balancing in
        /// Amazon VPC</a> .</para> </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="InvalidSecurityGroupException"/>
        /// <exception cref="CertificateNotFoundException"/>
        /// <exception cref="InvalidSchemeException"/>
        /// <exception cref="DuplicateLoadBalancerNameException"/>
        /// <exception cref="TooManyLoadBalancersException"/>
        /// <exception cref="SubnetNotFoundException"/>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoadBalancer operation.</returns>
        IAsyncResult BeginCreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancer.</param>
        /// 
        /// <returns>Returns a CreateLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        CreateLoadBalancerResponse EndCreateLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetLoadBalancerPoliciesForBackendServer

        /// <summary>
        /// <para> Replaces the current set of policies associated with a port on which the back-end server is listening with a new set of policies.
        /// After the policies have been created using CreateLoadBalancerPolicy, they can be applied here as a list. At this time, only the back-end
        /// server authentication policy type can be applied to the back-end ports; this policy type is composed of multiple public key policies.
        /// </para> <para><b>NOTE:</b> The SetLoadBalancerPoliciesForBackendServer replaces the current set of policies associated with the specified
        /// instance port. Every time you use this action to enable the policies, use the PolicyNames parameter to list all the policies you want to
        /// enable. </para> <para>You can use DescribeLoadBalancers or DescribeLoadBalancerPolicies action to verify that the policy has been associated
        /// with the back-end server.</para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesForBackendServer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="PolicyNotFoundException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesForBackendServer"/>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerPoliciesForBackendServer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetLoadBalancerPoliciesForBackendServer operation.</returns>
        IAsyncResult BeginSetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesForBackendServer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerPoliciesForBackendServer.</param>
        /// 
        /// <returns>Returns a SetLoadBalancerPoliciesForBackendServerResult from AmazonElasticLoadBalancing.</returns>
        SetLoadBalancerPoliciesForBackendServerResponse EndSetLoadBalancerPoliciesForBackendServer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeregisterInstancesFromLoadBalancer

        /// <summary>
        /// <para> Deregisters instances from the load balancer. Once the instance is deregistered, it will stop receiving traffic from the load
        /// balancer. </para> <para> In order to successfully call this API, the same account credentials as those used to create the load balancer must
        /// be provided. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html" >De-register and Register Amazon
        /// EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>You can use DescribeLoadBalancers to verify if the
        /// instance is deregistered from the load balancer.</para>
        /// </summary>
        /// 
        /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DeregisterInstancesFromLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="InvalidInstanceException"/>
        DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeregisterInstancesFromLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          DeregisterInstancesFromLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeregisterInstancesFromLoadBalancer operation.</returns>
        IAsyncResult BeginDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DeregisterInstancesFromLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterInstancesFromLoadBalancer.</param>
        /// 
        /// <returns>Returns a DeregisterInstancesFromLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        DeregisterInstancesFromLoadBalancerResponse EndDeregisterInstancesFromLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetLoadBalancerListenerSSLCertificate

        /// <summary>
        /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
        /// certificate that was used on the same load balancer and port. </para> <para>For more information on updating your SSL certificate, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html" >Updating an SSL Certificate
        /// for a Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerListenerSSLCertificate service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="CertificateNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="ListenerNotFoundException"/>
        SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
        ///          SetLoadBalancerListenerSSLCertificate operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndSetLoadBalancerListenerSSLCertificate operation.</returns>
        IAsyncResult BeginSetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoadBalancerListenerSSLCertificate.</param>
        /// 
        /// <returns>Returns a SetLoadBalancerListenerSSLCertificateResult from AmazonElasticLoadBalancing.</returns>
        SetLoadBalancerListenerSSLCertificateResponse EndSetLoadBalancerListenerSSLCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeLoadBalancerAttributes

        /// <summary>
        /// <para>Returns detailed information about all of the attributes associated with the specified load balancer.</para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerAttributesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerAttributeNotFoundException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest describeLoadBalancerAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerAttributes"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerAttributesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancerAttributes operation.</returns>
        IAsyncResult BeginDescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest describeLoadBalancerAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancerAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancerAttributesResult from AmazonElasticLoadBalancing.</returns>
        DescribeLoadBalancerAttributesResponse EndDescribeLoadBalancerAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLBCookieStickinessPolicy

        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
        /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a load balancer implements this policy,
        /// the load balancer uses a special cookie to track the backend server instance for each request. When the load balancer receives a request, it
        /// first checks to see if this cookie is present in the request. If so, the load balancer sends the request to the application server specified
        /// in the cookie. If not, the load balancer sends the request to a server that is chosen based on the existing load balancing algorithm.
        /// </para> <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the
        /// cookie is based on the cookie expiration time, which is specified in the policy configuration. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsLBCookies"
        /// >Enabling Duration-Based Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
        ///          service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="DuplicatePolicyNameException"/>
        /// <exception cref="TooManyPoliciesException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLBCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
        ///          operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLBCookieStickinessPolicy operation.</returns>
        IAsyncResult BeginCreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateLBCookieStickinessPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLBCookieStickinessPolicy.</param>
        /// 
        /// <returns>Returns a CreateLBCookieStickinessPolicyResult from AmazonElasticLoadBalancing.</returns>
        CreateLBCookieStickinessPolicyResponse EndCreateLBCookieStickinessPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AttachLoadBalancerToSubnets

        /// <summary>
        /// <para> Adds one or more subnets to the set of configured subnets in the Amazon Virtual Private Cloud (Amazon VPC) for the load balancer.
        /// </para> <para> The load balancers evenly distribute requests across all of the registered subnets. For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html" >Deploy Elastic Load Balancing in
        /// Amazon VPC</a> in the <i>Elastic Load Balancing Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service
        ///          method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="InvalidConfigurationRequestException"/>
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="SubnetNotFoundException"/>
        AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.AttachLoadBalancerToSubnets"/>
        /// </summary>
        /// 
        /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation
        ///          on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAttachLoadBalancerToSubnets operation.</returns>
        IAsyncResult BeginAttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.AttachLoadBalancerToSubnets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerToSubnets.</param>
        /// 
        /// <returns>Returns a AttachLoadBalancerToSubnetsResult from AmazonElasticLoadBalancing.</returns>
        AttachLoadBalancerToSubnetsResponse EndAttachLoadBalancerToSubnets(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RegisterInstancesWithLoadBalancer

        /// <summary>
        /// <para> Adds new instances to the load balancer. </para> <para> Once the instance is registered, it starts receiving traffic and requests
        /// from the load balancer. Any instance that is not in any of the Availability Zones registered for the load balancer will be moved to the
        /// <i>OutOfService</i> state. It will move to the <i>InService</i> state when the Availability Zone is added to the load balancer. </para>
        /// <para>When an instance registered with a load balancer is stopped and then restarted, the IP addresses associated with the instance changes.
        /// Elastic Load Balancing cannot recognize the new IP address, which prevents it from routing traffic to the instances. We recommend that you
        /// de-register your Amazon EC2 instances from your load balancer after you stop your instance, and then register the load balancer with your
        /// instance after you've restarted. To de-register your instances from load balancer, use DeregisterInstancesFromLoadBalancer action.</para>
        /// <para>For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html"
        /// >De-register and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para> <para><b>NOTE:</b> In order
        /// for this call to be successful, you must provide the same account credentials as those that were used to create the load balancer. </para>
        /// <para><b>NOTE:</b> Completion of this API does not guarantee that operation has completed. Rather, it means that the request has been
        /// registered and the changes will happen shortly. </para> <para>You can use DescribeLoadBalancers or DescribeInstanceHealth action to check
        /// the state of the newly registered instances.</para>
        /// </summary>
        /// 
        /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          RegisterInstancesWithLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        /// <exception cref="InvalidInstanceException"/>
        RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
        ///          RegisterInstancesWithLoadBalancer operation on AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRegisterInstancesWithLoadBalancer operation.</returns>
        IAsyncResult BeginRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.RegisterInstancesWithLoadBalancer"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterInstancesWithLoadBalancer.</param>
        /// 
        /// <returns>Returns a RegisterInstancesWithLoadBalancerResult from AmazonElasticLoadBalancing.</returns>
        RegisterInstancesWithLoadBalancerResponse EndRegisterInstancesWithLoadBalancer(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeLoadBalancers

        /// <summary>
        /// <para> Returns detailed configuration information for all the load balancers created for the account. If you specify load balancer names,
        /// the action returns configuration information of the specified load balancers. </para> <para><b>NOTE:</b> In order to retrieve this
        /// information, you must provide the same account credentials that was used to create the load balancer.</para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers service method on
        ///          AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest describeLoadBalancersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers operation on
        ///          AmazonElasticLoadBalancing.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoadBalancers operation.</returns>
        IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest describeLoadBalancersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeLoadBalancers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a DescribeLoadBalancersResult from AmazonElasticLoadBalancing.</returns>
        DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns detailed configuration information for all the load balancers created for the account. If you specify load balancer names,
        /// the action returns configuration information of the specified load balancers. </para> <para><b>NOTE:</b> In order to retrieve this
        /// information, you must provide the same account credentials that was used to create the load balancer.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancersResponse DescribeLoadBalancers();
        
        #endregion
        
    
    }
}
    
