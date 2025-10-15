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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticLoadBalancingV2.Model;

#pragma warning disable CS1570
namespace Amazon.ElasticLoadBalancingV2
{
    /// <summary>
    /// <para>Interface for accessing ElasticLoadBalancingV2</para>
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// A load balancer distributes incoming traffic across targets, such as your EC2 instances.
    /// This enables you to increase the availability of your application. The load balancer
    /// also monitors the health of its registered targets and ensures that it routes traffic
    /// only to healthy targets. You configure your load balancer to accept incoming traffic
    /// by specifying one or more listeners, which are configured with a protocol and port
    /// number for connections from clients to the load balancer. You configure a target group
    /// with a protocol and port number for connections from the load balancer to the targets,
    /// and with health check settings to be used when checking the health status of the targets.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports the following types of load balancers: Application
    /// Load Balancers, Network Load Balancers, Gateway Load Balancers, and Classic Load Balancers.
    /// This reference covers the following load balancer types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Application Load Balancer - Operates at the application layer (layer 7) and supports
    /// HTTP and HTTPS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
    /// TLS, and UDP.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Gateway Load Balancer - Operates at the network layer (layer 3).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are idempotent, which means that they complete
    /// at most one time. If you repeat an operation, it succeeds.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticLoadBalancingV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElasticLoadBalancingV2PaginatorFactory Paginators { get; }
#endif


        
        #region  AddListenerCertificates


        /// <summary>
        /// Adds the specified SSL server certificate to the certificate list for the specified
        /// HTTPS or TLS listener.
        /// 
        ///  
        /// <para>
        /// If the certificate in already in the certificate list, the call is successful but
        /// the certificate is not added again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/https-listener-certificates.html">SSL
        /// certificates</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/tls-listener-certificates.html">Server
        /// certificates</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddListenerCertificates service method.</param>
        /// 
        /// <returns>The response from the AddListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddListenerCertificates">REST API Reference for AddListenerCertificates Operation</seealso>
        AddListenerCertificatesResponse AddListenerCertificates(AddListenerCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddListenerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddListenerCertificates operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddListenerCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddListenerCertificates">REST API Reference for AddListenerCertificates Operation</seealso>
        IAsyncResult BeginAddListenerCertificates(AddListenerCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddListenerCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddListenerCertificates.</param>
        /// 
        /// <returns>Returns a  AddListenerCertificatesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddListenerCertificates">REST API Reference for AddListenerCertificates Operation</seealso>
        AddListenerCertificatesResponse EndAddListenerCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  AddTags


        /// <summary>
        /// Adds the specified tags to the specified Elastic Load Balancing resource. You can
        /// tag your Application Load Balancers, Network Load Balancers, Gateway Load Balancers,
        /// target groups, trust stores, listeners, and rules.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, <c>AddTags</c> updates its value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  AddTrustStoreRevocations


        /// <summary>
        /// Adds the specified revocation file to the specified trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTrustStoreRevocations service method.</param>
        /// 
        /// <returns>The response from the AddTrustStoreRevocations service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidRevocationContentException">
        /// The provided revocation file is an invalid format, or uses an incorrect algorithm.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RevocationContentNotFoundException">
        /// The specified revocation file does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTrustStoreRevocationEntriesException">
        /// The specified trust store has too many revocation entries.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTrustStoreRevocations">REST API Reference for AddTrustStoreRevocations Operation</seealso>
        AddTrustStoreRevocationsResponse AddTrustStoreRevocations(AddTrustStoreRevocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTrustStoreRevocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTrustStoreRevocations operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTrustStoreRevocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTrustStoreRevocations">REST API Reference for AddTrustStoreRevocations Operation</seealso>
        IAsyncResult BeginAddTrustStoreRevocations(AddTrustStoreRevocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTrustStoreRevocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTrustStoreRevocations.</param>
        /// 
        /// <returns>Returns a  AddTrustStoreRevocationsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTrustStoreRevocations">REST API Reference for AddTrustStoreRevocations Operation</seealso>
        AddTrustStoreRevocationsResponse EndAddTrustStoreRevocations(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateListener


        /// <summary>
        /// Creates a listener for the specified Application Load Balancer, Network Load Balancer,
        /// or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html">Listeners
        /// for your Application Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-listeners.html">Listeners
        /// for your Network Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-listeners.html">Listeners
        /// for your Gateway Load Balancers</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple listeners with the same settings, each call succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ALPNPolicyNotSupportedException">
        /// The specified ALPN policy is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateListenerException">
        /// A listener with the specified port already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotReadyException">
        /// The specified trust store is not active.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        CreateListenerResponse CreateListener(CreateListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        IAsyncResult BeginCreateListener(CreateListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateListener.</param>
        /// 
        /// <returns>Returns a  CreateListenerResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        CreateListenerResponse EndCreateListener(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html">Application
        /// Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html">Network
        /// Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-load-balancers.html">Gateway
        /// Load Balancers</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple load balancers with the same settings, each call succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AllocationIdNotFoundException">
        /// The specified allocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AvailabilityZoneNotSupportedException">
        /// The specified Availability Zone is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateLoadBalancerNameException">
        /// A load balancer with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSchemeException">
        /// The requested scheme is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSecurityGroupException">
        /// The specified security group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyLoadBalancersException">
        /// You've reached the limit on the number of load balancers for your Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        IAsyncResult BeginCreateLoadBalancer(CreateLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancer.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        CreateLoadBalancerResponse EndCreateLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a rule for the specified listener. The listener must be associated with an
        /// Application Load Balancer.
        /// 
        ///  
        /// <para>
        /// Each rule consists of a priority, one or more actions, one or more conditions, and
        /// up to two optional transforms. Rules are evaluated in priority order, from the lowest
        /// value to the highest value. When the conditions for a rule are met, its actions are
        /// performed. If the conditions for no rules are met, the actions for the default rule
        /// are performed. For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorityInUseException">
        /// The specified priority is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRulesException">
        /// You've reached the limit on the number of rules per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(CreateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse EndCreateRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTargetGroup


        /// <summary>
        /// Creates a target group.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html">Target
        /// groups for your Application Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html">Target
        /// groups for your Network Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/target-groups.html">Target
        /// groups for your Gateway Load Balancers</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple target groups with the same settings, each call succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTargetGroupNameException">
        /// A target group with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your Amazon Web Services
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        IAsyncResult BeginCreateTargetGroup(CreateTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTargetGroup.</param>
        /// 
        /// <returns>Returns a  CreateTargetGroupResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        CreateTargetGroupResponse EndCreateTargetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrustStore


        /// <summary>
        /// Creates a trust store.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/mutual-authentication.html">Mutual
        /// TLS for Application Load Balancers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore service method.</param>
        /// 
        /// <returns>The response from the CreateTrustStore service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CaCertificatesBundleNotFoundException">
        /// The specified ca certificate bundle does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTrustStoreNameException">
        /// A trust store with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidCaCertificatesBundleException">
        /// The specified ca certificate bundle is in an invalid format, or corrupt.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTrustStoresException">
        /// You've reached the limit on the number of trust stores for your Amazon Web Services
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse CreateTrustStore(CreateTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustStore operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        IAsyncResult BeginCreateTrustStore(CreateTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustStore.</param>
        /// 
        /// <returns>Returns a  CreateTrustStoreResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTrustStore">REST API Reference for CreateTrustStore Operation</seealso>
        CreateTrustStoreResponse EndCreateTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteListener


        /// <summary>
        /// Deletes the specified listener.
        /// 
        ///  
        /// <para>
        /// Alternatively, your listener is deleted when you delete the load balancer to which
        /// it is attached.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        DeleteListenerResponse DeleteListener(DeleteListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        IAsyncResult BeginDeleteListener(DeleteListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteListener.</param>
        /// 
        /// <returns>Returns a  DeleteListenerResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        DeleteListenerResponse EndDeleteListener(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes the specified Application Load Balancer, Network Load Balancer, or Gateway
        /// Load Balancer. Deleting a load balancer also deletes its listeners.
        /// 
        ///  
        /// <para>
        /// You can't delete a load balancer if deletion protection is enabled. If the load balancer
        /// does not exist or has already been deleted, the call succeeds.
        /// </para>
        ///  
        /// <para>
        /// Deleting a load balancer does not affect its registered targets. For example, your
        /// EC2 instances continue to run and are still registered to their target groups. If
        /// you no longer need these EC2 instances, you can stop or terminate them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        IAsyncResult BeginDeleteLoadBalancer(DeleteLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        DeleteLoadBalancerResponse EndDeleteLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// You can't delete the default rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSharedTrustStoreAssociation


        /// <summary>
        /// Deletes a shared trust store association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSharedTrustStoreAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteSharedTrustStoreAssociation service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DeleteAssociationSameAccountException">
        /// The specified association can't be within the same account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreAssociationNotFoundException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteSharedTrustStoreAssociation">REST API Reference for DeleteSharedTrustStoreAssociation Operation</seealso>
        DeleteSharedTrustStoreAssociationResponse DeleteSharedTrustStoreAssociation(DeleteSharedTrustStoreAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSharedTrustStoreAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSharedTrustStoreAssociation operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSharedTrustStoreAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteSharedTrustStoreAssociation">REST API Reference for DeleteSharedTrustStoreAssociation Operation</seealso>
        IAsyncResult BeginDeleteSharedTrustStoreAssociation(DeleteSharedTrustStoreAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSharedTrustStoreAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSharedTrustStoreAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteSharedTrustStoreAssociationResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteSharedTrustStoreAssociation">REST API Reference for DeleteSharedTrustStoreAssociation Operation</seealso>
        DeleteSharedTrustStoreAssociationResponse EndDeleteSharedTrustStoreAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTargetGroup


        /// <summary>
        /// Deletes the specified target group.
        /// 
        ///  
        /// <para>
        /// You can delete a target group if it is not referenced by any actions. Deleting a target
        /// group also deletes any associated health checks. Deleting a target group does not
        /// affect its registered targets. For example, any EC2 instances continue to run until
        /// you stop or terminate them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        IAsyncResult BeginDeleteTargetGroup(DeleteTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTargetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteTargetGroupResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        DeleteTargetGroupResponse EndDeleteTargetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrustStore


        /// <summary>
        /// Deletes a trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustStore service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreInUseException">
        /// The specified trust store is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse DeleteTrustStore(DeleteTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustStore operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        IAsyncResult BeginDeleteTrustStore(DeleteTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustStore.</param>
        /// 
        /// <returns>Returns a  DeleteTrustStoreResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTrustStore">REST API Reference for DeleteTrustStore Operation</seealso>
        DeleteTrustStoreResponse EndDeleteTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterTargets


        /// <summary>
        /// Deregisters the specified targets from the specified target group. After the targets
        /// are deregistered, they no longer receive traffic from the load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer stops sending requests to targets that are deregistering, but uses
        /// connection draining to ensure that in-flight traffic completes on the existing connections.
        /// This deregistration delay is configured by default but can be updated for each target
        /// group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/edit-target-group-attributes.html#deregistration-delay">
        /// Deregistration delay</a> in the <i>Application Load Balancers User Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/edit-target-group-attributes.html#deregistration-delay">
        /// Deregistration delay</a> in the <i>Network Load Balancers User Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/edit-target-group-attributes.html#deregistration-delay">
        /// Deregistration delay</a> in the <i>Gateway Load Balancers User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note: If the specified target does not exist, the action returns successfully.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// 
        /// <returns>The response from the DeregisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        IAsyncResult BeginDeregisterTargets(DeregisterTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTargets.</param>
        /// 
        /// <returns>Returns a  DeregisterTargetsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        DeregisterTargetsResponse EndDeregisterTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Describes the current Elastic Load Balancing resource limits for your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Quotas
        /// for your Application Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-limits.html">Quotas
        /// for your Network Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/quotas-limits.html">Quotas
        /// for your Gateway Load Balancers</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCapacityReservation


        /// <summary>
        /// Describes the capacity reservation status for the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityReservation service method.</param>
        /// 
        /// <returns>The response from the DescribeCapacityReservation service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeCapacityReservation">REST API Reference for DescribeCapacityReservation Operation</seealso>
        DescribeCapacityReservationResponse DescribeCapacityReservation(DescribeCapacityReservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityReservation operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCapacityReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeCapacityReservation">REST API Reference for DescribeCapacityReservation Operation</seealso>
        IAsyncResult BeginDescribeCapacityReservation(DescribeCapacityReservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCapacityReservation.</param>
        /// 
        /// <returns>Returns a  DescribeCapacityReservationResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeCapacityReservation">REST API Reference for DescribeCapacityReservation Operation</seealso>
        DescribeCapacityReservationResponse EndDescribeCapacityReservation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeListenerAttributes


        /// <summary>
        /// Describes the attributes for the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListenerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeListenerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerAttributes">REST API Reference for DescribeListenerAttributes Operation</seealso>
        DescribeListenerAttributesResponse DescribeListenerAttributes(DescribeListenerAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListenerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListenerAttributes operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeListenerAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerAttributes">REST API Reference for DescribeListenerAttributes Operation</seealso>
        IAsyncResult BeginDescribeListenerAttributes(DescribeListenerAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeListenerAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeListenerAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeListenerAttributesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerAttributes">REST API Reference for DescribeListenerAttributes Operation</seealso>
        DescribeListenerAttributesResponse EndDescribeListenerAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeListenerCertificates


        /// <summary>
        /// Describes the default certificate and the certificate list for the specified HTTPS
        /// or TLS listener.
        /// 
        ///  
        /// <para>
        /// If the default certificate is also in the certificate list, it appears twice in the
        /// results (once with <c>IsDefault</c> set to true and once with <c>IsDefault</c> set
        /// to false).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/https-listener-certificates.html">SSL
        /// certificates</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/tls-listener-certificates.html">Server
        /// certificates</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListenerCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerCertificates">REST API Reference for DescribeListenerCertificates Operation</seealso>
        DescribeListenerCertificatesResponse DescribeListenerCertificates(DescribeListenerCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListenerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListenerCertificates operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeListenerCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerCertificates">REST API Reference for DescribeListenerCertificates Operation</seealso>
        IAsyncResult BeginDescribeListenerCertificates(DescribeListenerCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeListenerCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeListenerCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeListenerCertificatesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerCertificates">REST API Reference for DescribeListenerCertificates Operation</seealso>
        DescribeListenerCertificatesResponse EndDescribeListenerCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeListeners


        /// <summary>
        /// Describes the specified listeners or the listeners for the specified Application Load
        /// Balancer, Network Load Balancer, or Gateway Load Balancer. You must specify either
        /// a load balancer or one or more listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners service method.</param>
        /// 
        /// <returns>The response from the DescribeListeners service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        DescribeListenersResponse DescribeListeners(DescribeListenersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeListeners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        IAsyncResult BeginDescribeListeners(DescribeListenersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeListeners.</param>
        /// 
        /// <returns>Returns a  DescribeListenersResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        DescribeListenersResponse EndDescribeListeners(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Describes the attributes for the specified Application Load Balancer, Network Load
        /// Balancer, or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html#load-balancer-attributes">Load
        /// balancer attributes</a> in the <i>Application Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html#load-balancer-attributes">Load
        /// balancer attributes</a> in the <i>Network Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-load-balancers.html#load-balancer-attributes">Load
        /// balancer attributes</a> in the <i>Gateway Load Balancers Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        IAsyncResult BeginDescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerAttributesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        DescribeLoadBalancerAttributesResponse EndDescribeLoadBalancerAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// Describes the specified load balancers or all of your load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancersResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRules


        /// <summary>
        /// Describes the specified rules or the rules for the specified listener. You must specify
        /// either a listener or one or more rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules service method.</param>
        /// 
        /// <returns>The response from the DescribeRules service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        DescribeRulesResponse DescribeRules(DescribeRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        IAsyncResult BeginDescribeRules(DescribeRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRules.</param>
        /// 
        /// <returns>Returns a  DescribeRulesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        DescribeRulesResponse EndDescribeRules(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSSLPolicies


        /// <summary>
        /// Describes the specified policies or all policies used for SSL negotiation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/describe-ssl-policies.html">Security
        /// policies</a> in the <i>Application Load Balancers Guide</i> and <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/describe-ssl-policies.html">Security
        /// policies</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeSSLPolicies service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        DescribeSSLPoliciesResponse DescribeSSLPolicies(DescribeSSLPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSSLPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSSLPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        IAsyncResult BeginDescribeSSLPolicies(DescribeSSLPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSSLPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSSLPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeSSLPoliciesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        DescribeSSLPoliciesResponse EndDescribeSSLPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags for the specified Elastic Load Balancing resources. You can describe
        /// the tags for one or more Application Load Balancers, Network Load Balancers, Gateway
        /// Load Balancers, target groups, listeners, or rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTargetGroupAttributes


        /// <summary>
        /// Describes the attributes for the specified target group.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html#target-group-attributes">Target
        /// group attributes</a> in the <i>Application Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#target-group-attributes">Target
        /// group attributes</a> in the <i>Network Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/target-groups.html#target-group-attributes">Target
        /// group attributes</a> in the <i>Gateway Load Balancers Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        DescribeTargetGroupAttributesResponse DescribeTargetGroupAttributes(DescribeTargetGroupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTargetGroupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        IAsyncResult BeginDescribeTargetGroupAttributes(DescribeTargetGroupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTargetGroupAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeTargetGroupAttributesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        DescribeTargetGroupAttributesResponse EndDescribeTargetGroupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTargetGroups


        /// <summary>
        /// Describes the specified target groups or all of your target groups. By default, all
        /// target groups are described. Alternatively, you can specify one of the following to
        /// filter the results: the ARN of the load balancer, the names of one or more target
        /// groups, or the ARNs of one or more target groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeTargetGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        DescribeTargetGroupsResponse DescribeTargetGroups(DescribeTargetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTargetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        IAsyncResult BeginDescribeTargetGroups(DescribeTargetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTargetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeTargetGroupsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        DescribeTargetGroupsResponse EndDescribeTargetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTargetHealth


        /// <summary>
        /// Describes the health of the specified targets or all of your targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeTargetHealth service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.HealthUnavailableException">
        /// The health of the specified targets could not be retrieved due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        DescribeTargetHealthResponse DescribeTargetHealth(DescribeTargetHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTargetHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        IAsyncResult BeginDescribeTargetHealth(DescribeTargetHealthRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTargetHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTargetHealth.</param>
        /// 
        /// <returns>Returns a  DescribeTargetHealthResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        DescribeTargetHealthResponse EndDescribeTargetHealth(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustStoreAssociations


        /// <summary>
        /// Describes all resources associated with the specified trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustStoreAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustStoreAssociations service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStoreAssociations">REST API Reference for DescribeTrustStoreAssociations Operation</seealso>
        DescribeTrustStoreAssociationsResponse DescribeTrustStoreAssociations(DescribeTrustStoreAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustStoreAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustStoreAssociations operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustStoreAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStoreAssociations">REST API Reference for DescribeTrustStoreAssociations Operation</seealso>
        IAsyncResult BeginDescribeTrustStoreAssociations(DescribeTrustStoreAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustStoreAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustStoreAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeTrustStoreAssociationsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStoreAssociations">REST API Reference for DescribeTrustStoreAssociations Operation</seealso>
        DescribeTrustStoreAssociationsResponse EndDescribeTrustStoreAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustStoreRevocations


        /// <summary>
        /// Describes the revocation files in use by the specified trust store or revocation files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustStoreRevocations service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustStoreRevocations service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RevocationIdNotFoundException">
        /// The specified revocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStoreRevocations">REST API Reference for DescribeTrustStoreRevocations Operation</seealso>
        DescribeTrustStoreRevocationsResponse DescribeTrustStoreRevocations(DescribeTrustStoreRevocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustStoreRevocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustStoreRevocations operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustStoreRevocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStoreRevocations">REST API Reference for DescribeTrustStoreRevocations Operation</seealso>
        IAsyncResult BeginDescribeTrustStoreRevocations(DescribeTrustStoreRevocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustStoreRevocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustStoreRevocations.</param>
        /// 
        /// <returns>Returns a  DescribeTrustStoreRevocationsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStoreRevocations">REST API Reference for DescribeTrustStoreRevocations Operation</seealso>
        DescribeTrustStoreRevocationsResponse EndDescribeTrustStoreRevocations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustStores


        /// <summary>
        /// Describes all trust stores for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustStores service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustStores service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStores">REST API Reference for DescribeTrustStores Operation</seealso>
        DescribeTrustStoresResponse DescribeTrustStores(DescribeTrustStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustStores operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStores">REST API Reference for DescribeTrustStores Operation</seealso>
        IAsyncResult BeginDescribeTrustStores(DescribeTrustStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustStores.</param>
        /// 
        /// <returns>Returns a  DescribeTrustStoresResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTrustStores">REST API Reference for DescribeTrustStores Operation</seealso>
        DescribeTrustStoresResponse EndDescribeTrustStores(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource policy for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrustStoreCaCertificatesBundle


        /// <summary>
        /// Retrieves the ca certificate bundle.
        /// 
        ///  
        /// <para>
        /// This action returns a pre-signed S3 URI which is active for ten minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCaCertificatesBundle service method.</param>
        /// 
        /// <returns>The response from the GetTrustStoreCaCertificatesBundle service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetTrustStoreCaCertificatesBundle">REST API Reference for GetTrustStoreCaCertificatesBundle Operation</seealso>
        GetTrustStoreCaCertificatesBundleResponse GetTrustStoreCaCertificatesBundle(GetTrustStoreCaCertificatesBundleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStoreCaCertificatesBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreCaCertificatesBundle operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStoreCaCertificatesBundle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetTrustStoreCaCertificatesBundle">REST API Reference for GetTrustStoreCaCertificatesBundle Operation</seealso>
        IAsyncResult BeginGetTrustStoreCaCertificatesBundle(GetTrustStoreCaCertificatesBundleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStoreCaCertificatesBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStoreCaCertificatesBundle.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreCaCertificatesBundleResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetTrustStoreCaCertificatesBundle">REST API Reference for GetTrustStoreCaCertificatesBundle Operation</seealso>
        GetTrustStoreCaCertificatesBundleResponse EndGetTrustStoreCaCertificatesBundle(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrustStoreRevocationContent


        /// <summary>
        /// Retrieves the specified revocation file.
        /// 
        ///  
        /// <para>
        /// This action returns a pre-signed S3 URI which is active for ten minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreRevocationContent service method.</param>
        /// 
        /// <returns>The response from the GetTrustStoreRevocationContent service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RevocationIdNotFoundException">
        /// The specified revocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetTrustStoreRevocationContent">REST API Reference for GetTrustStoreRevocationContent Operation</seealso>
        GetTrustStoreRevocationContentResponse GetTrustStoreRevocationContent(GetTrustStoreRevocationContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustStoreRevocationContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustStoreRevocationContent operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustStoreRevocationContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetTrustStoreRevocationContent">REST API Reference for GetTrustStoreRevocationContent Operation</seealso>
        IAsyncResult BeginGetTrustStoreRevocationContent(GetTrustStoreRevocationContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustStoreRevocationContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustStoreRevocationContent.</param>
        /// 
        /// <returns>Returns a  GetTrustStoreRevocationContentResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/GetTrustStoreRevocationContent">REST API Reference for GetTrustStoreRevocationContent Operation</seealso>
        GetTrustStoreRevocationContentResponse EndGetTrustStoreRevocationContent(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyCapacityReservation


        /// <summary>
        /// Modifies the capacity reservation of the specified load balancer.
        /// 
        ///  
        /// <para>
        /// When modifying capacity reservation, you must include at least one <c>MinimumLoadBalancerCapacity</c>
        /// or <c>ResetCapacityReservation</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCapacityReservation service method.</param>
        /// 
        /// <returns>The response from the ModifyCapacityReservation service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CapacityDecreaseRequestsLimitExceededException">
        /// You've exceeded the daily capacity decrease limit for this reservation.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CapacityReservationPendingException">
        /// There is a pending capacity reservation.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CapacityUnitsLimitExceededException">
        /// You've exceeded the capacity units limit.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InsufficientCapacityException">
        /// There is insufficient capacity to reserve.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorRequestNotCompleteException">
        /// This operation is not allowed while a prior request has not been completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyCapacityReservation">REST API Reference for ModifyCapacityReservation Operation</seealso>
        ModifyCapacityReservationResponse ModifyCapacityReservation(ModifyCapacityReservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCapacityReservation operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCapacityReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyCapacityReservation">REST API Reference for ModifyCapacityReservation Operation</seealso>
        IAsyncResult BeginModifyCapacityReservation(ModifyCapacityReservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCapacityReservation.</param>
        /// 
        /// <returns>Returns a  ModifyCapacityReservationResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyCapacityReservation">REST API Reference for ModifyCapacityReservation Operation</seealso>
        ModifyCapacityReservationResponse EndModifyCapacityReservation(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyIpPools


        /// <summary>
        /// [Application Load Balancers] Modify the IP pool associated to a load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIpPools service method.</param>
        /// 
        /// <returns>The response from the ModifyIpPools service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyIpPools">REST API Reference for ModifyIpPools Operation</seealso>
        ModifyIpPoolsResponse ModifyIpPools(ModifyIpPoolsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIpPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIpPools operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyIpPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyIpPools">REST API Reference for ModifyIpPools Operation</seealso>
        IAsyncResult BeginModifyIpPools(ModifyIpPoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyIpPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyIpPools.</param>
        /// 
        /// <returns>Returns a  ModifyIpPoolsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyIpPools">REST API Reference for ModifyIpPools Operation</seealso>
        ModifyIpPoolsResponse EndModifyIpPools(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyListener


        /// <summary>
        /// Replaces the specified properties of the specified listener. Any properties that you
        /// do not specify remain unchanged.
        /// 
        ///  
        /// <para>
        /// Changing the protocol from HTTPS to HTTP, or from TLS to TCP, removes the security
        /// policy and default certificate properties. If you change the protocol from HTTP to
        /// HTTPS, or from TCP to TLS, you must add the security policy and default certificate
        /// properties.
        /// </para>
        ///  
        /// <para>
        /// To add an item to a list, remove an item from a list, or update an item in a list,
        /// you must provide the entire list. For example, to add an action, specify a list with
        /// the current actions plus the new action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener service method.</param>
        /// 
        /// <returns>The response from the ModifyListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ALPNPolicyNotSupportedException">
        /// The specified ALPN policy is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateListenerException">
        /// A listener with the specified port already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotReadyException">
        /// The specified trust store is not active.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        ModifyListenerResponse ModifyListener(ModifyListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        IAsyncResult BeginModifyListener(ModifyListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyListener.</param>
        /// 
        /// <returns>Returns a  ModifyListenerResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        ModifyListenerResponse EndModifyListener(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyListenerAttributes


        /// <summary>
        /// Modifies the specified attributes of the specified listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyListenerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyListenerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListenerAttributes">REST API Reference for ModifyListenerAttributes Operation</seealso>
        ModifyListenerAttributesResponse ModifyListenerAttributes(ModifyListenerAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyListenerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyListenerAttributes operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyListenerAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListenerAttributes">REST API Reference for ModifyListenerAttributes Operation</seealso>
        IAsyncResult BeginModifyListenerAttributes(ModifyListenerAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyListenerAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyListenerAttributes.</param>
        /// 
        /// <returns>Returns a  ModifyListenerAttributesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListenerAttributes">REST API Reference for ModifyListenerAttributes Operation</seealso>
        ModifyListenerAttributesResponse EndModifyListenerAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Modifies the specified attributes of the specified Application Load Balancer, Network
        /// Load Balancer, or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// If any of the specified attributes can't be modified as requested, the call fails.
        /// Any existing attributes that you do not modify retain their current values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLoadBalancerAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        IAsyncResult BeginModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLoadBalancerAttributes.</param>
        /// 
        /// <returns>Returns a  ModifyLoadBalancerAttributesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        ModifyLoadBalancerAttributesResponse EndModifyLoadBalancerAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyRule


        /// <summary>
        /// Replaces the specified properties of the specified rule. Any properties that you do
        /// not specify are unchanged.
        /// 
        ///  
        /// <para>
        /// To add an item to a list, remove an item from a list, or update an item in a list,
        /// you must provide the entire list. For example, to add an action, specify a list with
        /// the current actions plus the new action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule service method.</param>
        /// 
        /// <returns>The response from the ModifyRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        ModifyRuleResponse ModifyRule(ModifyRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        IAsyncResult BeginModifyRule(ModifyRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyRule.</param>
        /// 
        /// <returns>Returns a  ModifyRuleResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        ModifyRuleResponse EndModifyRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyTargetGroup


        /// <summary>
        /// Modifies the health checks used when evaluating the health state of the targets in
        /// the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        ModifyTargetGroupResponse ModifyTargetGroup(ModifyTargetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        IAsyncResult BeginModifyTargetGroup(ModifyTargetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyTargetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyTargetGroupResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        ModifyTargetGroupResponse EndModifyTargetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyTargetGroupAttributes


        /// <summary>
        /// Modifies the specified attributes of the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyTargetGroupAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        IAsyncResult BeginModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyTargetGroupAttributes.</param>
        /// 
        /// <returns>Returns a  ModifyTargetGroupAttributesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        ModifyTargetGroupAttributesResponse EndModifyTargetGroupAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyTrustStore


        /// <summary>
        /// Update the ca certificate bundle for the specified trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTrustStore service method.</param>
        /// 
        /// <returns>The response from the ModifyTrustStore service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CaCertificatesBundleNotFoundException">
        /// The specified ca certificate bundle does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidCaCertificatesBundleException">
        /// The specified ca certificate bundle is in an invalid format, or corrupt.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTrustStore">REST API Reference for ModifyTrustStore Operation</seealso>
        ModifyTrustStoreResponse ModifyTrustStore(ModifyTrustStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTrustStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTrustStore operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyTrustStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTrustStore">REST API Reference for ModifyTrustStore Operation</seealso>
        IAsyncResult BeginModifyTrustStore(ModifyTrustStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyTrustStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyTrustStore.</param>
        /// 
        /// <returns>Returns a  ModifyTrustStoreResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTrustStore">REST API Reference for ModifyTrustStore Operation</seealso>
        ModifyTrustStoreResponse EndModifyTrustStore(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterTargets


        /// <summary>
        /// Registers the specified targets with the specified target group.
        /// 
        ///  
        /// <para>
        /// If the target is an EC2 instance, it must be in the <c>running</c> state when you
        /// register it.
        /// </para>
        ///  
        /// <para>
        /// By default, the load balancer routes requests to registered targets using the protocol
        /// and port for the target group. Alternatively, you can override the port for a target
        /// when you register it. You can register each EC2 instance or IP address with the same
        /// target group multiple times using different ports.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/target-group-register-targets.html">Register
        /// targets for your Application Load Balancer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/target-group-register-targets.html">Register
        /// targets for your Network Load Balancer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/target-group-register-targets.html">Register
        /// targets for your Gateway Load Balancer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// 
        /// <returns>The response from the RegisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        IAsyncResult BeginRegisterTargets(RegisterTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTargets.</param>
        /// 
        /// <returns>Returns a  RegisterTargetsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        RegisterTargetsResponse EndRegisterTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveListenerCertificates


        /// <summary>
        /// Removes the specified certificate from the certificate list for the specified HTTPS
        /// or TLS listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveListenerCertificates service method.</param>
        /// 
        /// <returns>The response from the RemoveListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveListenerCertificates">REST API Reference for RemoveListenerCertificates Operation</seealso>
        RemoveListenerCertificatesResponse RemoveListenerCertificates(RemoveListenerCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveListenerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveListenerCertificates operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveListenerCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveListenerCertificates">REST API Reference for RemoveListenerCertificates Operation</seealso>
        IAsyncResult BeginRemoveListenerCertificates(RemoveListenerCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveListenerCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveListenerCertificates.</param>
        /// 
        /// <returns>Returns a  RemoveListenerCertificatesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveListenerCertificates">REST API Reference for RemoveListenerCertificates Operation</seealso>
        RemoveListenerCertificatesResponse EndRemoveListenerCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified tags from the specified Elastic Load Balancing resources. You
        /// can remove the tags for one or more Application Load Balancers, Network Load Balancers,
        /// Gateway Load Balancers, target groups, listeners, or rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags for this resource.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTrustStoreRevocations


        /// <summary>
        /// Removes the specified revocation file from the specified trust store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTrustStoreRevocations service method.</param>
        /// 
        /// <returns>The response from the RemoveTrustStoreRevocations service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RevocationIdNotFoundException">
        /// The specified revocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TrustStoreNotFoundException">
        /// The specified trust store does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTrustStoreRevocations">REST API Reference for RemoveTrustStoreRevocations Operation</seealso>
        RemoveTrustStoreRevocationsResponse RemoveTrustStoreRevocations(RemoveTrustStoreRevocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTrustStoreRevocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTrustStoreRevocations operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTrustStoreRevocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTrustStoreRevocations">REST API Reference for RemoveTrustStoreRevocations Operation</seealso>
        IAsyncResult BeginRemoveTrustStoreRevocations(RemoveTrustStoreRevocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTrustStoreRevocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTrustStoreRevocations.</param>
        /// 
        /// <returns>Returns a  RemoveTrustStoreRevocationsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTrustStoreRevocations">REST API Reference for RemoveTrustStoreRevocations Operation</seealso>
        RemoveTrustStoreRevocationsResponse EndRemoveTrustStoreRevocations(IAsyncResult asyncResult);

        #endregion
        
        #region  SetIpAddressType


        /// <summary>
        /// Sets the type of IP addresses used by the subnets of the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType service method.</param>
        /// 
        /// <returns>The response from the SetIpAddressType service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        SetIpAddressTypeResponse SetIpAddressType(SetIpAddressTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIpAddressType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIpAddressType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        IAsyncResult BeginSetIpAddressType(SetIpAddressTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetIpAddressType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIpAddressType.</param>
        /// 
        /// <returns>Returns a  SetIpAddressTypeResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        SetIpAddressTypeResponse EndSetIpAddressType(IAsyncResult asyncResult);

        #endregion
        
        #region  SetRulePriorities


        /// <summary>
        /// Sets the priorities of the specified rules.
        /// 
        ///  
        /// <para>
        /// You can reorder the rules as long as there are no priority conflicts in the new order.
        /// Any existing rules that you do not specify retain their current priority.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRulePriorities service method.</param>
        /// 
        /// <returns>The response from the SetRulePriorities service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorityInUseException">
        /// The specified priority is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetRulePriorities">REST API Reference for SetRulePriorities Operation</seealso>
        SetRulePrioritiesResponse SetRulePriorities(SetRulePrioritiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetRulePriorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRulePriorities operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetRulePriorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetRulePriorities">REST API Reference for SetRulePriorities Operation</seealso>
        IAsyncResult BeginSetRulePriorities(SetRulePrioritiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetRulePriorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetRulePriorities.</param>
        /// 
        /// <returns>Returns a  SetRulePrioritiesResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetRulePriorities">REST API Reference for SetRulePriorities Operation</seealso>
        SetRulePrioritiesResponse EndSetRulePriorities(IAsyncResult asyncResult);

        #endregion
        
        #region  SetSecurityGroups


        /// <summary>
        /// Associates the specified security groups with the specified Application Load Balancer
        /// or Network Load Balancer. The specified security groups override the previously associated
        /// security groups.
        /// 
        ///  
        /// <para>
        /// You can't perform this operation on a Network Load Balancer unless you specified a
        /// security group for the load balancer when you created it.
        /// </para>
        ///  
        /// <para>
        /// You can't associate a security group with a Gateway Load Balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the SetSecurityGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSecurityGroupException">
        /// The specified security group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSecurityGroups">REST API Reference for SetSecurityGroups Operation</seealso>
        SetSecurityGroupsResponse SetSecurityGroups(SetSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSecurityGroups">REST API Reference for SetSecurityGroups Operation</seealso>
        IAsyncResult BeginSetSecurityGroups(SetSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSecurityGroups.</param>
        /// 
        /// <returns>Returns a  SetSecurityGroupsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSecurityGroups">REST API Reference for SetSecurityGroups Operation</seealso>
        SetSecurityGroupsResponse EndSetSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  SetSubnets


        /// <summary>
        /// Enables the Availability Zones for the specified public subnets for the specified
        /// Application Load Balancer, Network Load Balancer or Gateway Load Balancer. The specified
        /// subnets replace the previously enabled subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets service method.</param>
        /// 
        /// <returns>The response from the SetSubnets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AllocationIdNotFoundException">
        /// The specified allocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AvailabilityZoneNotSupportedException">
        /// The specified Availability Zone is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CapacityReservationPendingException">
        /// There is a pending capacity reservation.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSubnets">REST API Reference for SetSubnets Operation</seealso>
        SetSubnetsResponse SetSubnets(SetSubnetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets operation on AmazonElasticLoadBalancingV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetSubnets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSubnets">REST API Reference for SetSubnets Operation</seealso>
        IAsyncResult BeginSetSubnets(SetSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSubnets.</param>
        /// 
        /// <returns>Returns a  SetSubnetsResult from ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSubnets">REST API Reference for SetSubnets Operation</seealso>
        SetSubnetsResponse EndSetSubnets(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}