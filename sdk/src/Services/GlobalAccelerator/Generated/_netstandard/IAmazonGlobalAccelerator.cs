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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GlobalAccelerator.Model;

namespace Amazon.GlobalAccelerator
{
    /// <summary>
    /// Interface for accessing GlobalAccelerator
    ///
    /// AWS Global Accelerator 
    /// <para>
    /// This is the <i>AWS Global Accelerator API Reference</i>. This guide is for developers
    /// who need detailed information about AWS Global Accelerator API actions, data types,
    /// and errors. For more information about Global Accelerator features, see the <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/Welcome.html">AWS
    /// Global Accelerator Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// AWS Global Accelerator is a service in which you create <i>accelerators</i> to improve
    /// the performance of your applications for local and global users. Depending on the
    /// type of accelerator you choose, you can gain additional benefits. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// By using a standard accelerator, you can improve availability of your internet applications
    /// that are used by a global audience. With a standard accelerator, Global Accelerator
    /// directs traffic to optimal endpoints over the AWS global network. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For other scenarios, you might choose a custom routing accelerator. With a custom
    /// routing accelerator, you can use application logic to directly map one or more users
    /// to a specific endpoint among many endpoints.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// Global Accelerator is a global service that supports endpoints in multiple AWS Regions
    /// but you must specify the US West (Oregon) Region to create or update accelerators.
    /// </para>
    ///  </important> 
    /// <para>
    /// By default, Global Accelerator provides you with two static IP addresses that you
    /// associate with your accelerator. With a standard accelerator, instead of using the
    /// IP addresses that Global Accelerator provides, you can configure these entry points
    /// to be IPv4 addresses from your own IP address ranges that you bring to Global Accelerator.
    /// The static IP addresses are anycast from the AWS edge network. For a standard accelerator,
    /// they distribute incoming application traffic across multiple endpoint resources in
    /// multiple AWS Regions, which increases the availability of your applications. Endpoints
    /// for standard accelerators can be Network Load Balancers, Application Load Balancers,
    /// Amazon EC2 instances, or Elastic IP addresses that are located in one AWS Region or
    /// multiple Regions. For custom routing accelerators, you map traffic that arrives to
    /// the static IP addresses to specific Amazon EC2 servers in endpoints that are virtual
    /// private cloud (VPC) subnets.
    /// </para>
    ///  <important> 
    /// <para>
    /// The static IP addresses remain assigned to your accelerator for as long as it exists,
    /// even if you disable the accelerator and it no longer accepts or routes traffic. However,
    /// when you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
    /// to it, so you can no longer route traffic by using them. You can use IAM policies
    /// like tag-based permissions with Global Accelerator to limit the users who have permissions
    /// to delete an accelerator. For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/access-control-manage-access-tag-policies.html">Tag-based
    /// policies</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// For standard accelerators, Global Accelerator uses the AWS global network to route
    /// traffic to the optimal regional endpoint based on health, client location, and policies
    /// that you configure. The service reacts instantly to changes in health or configuration
    /// to ensure that internet traffic from clients is always directed to healthy endpoints.
    /// </para>
    ///  
    /// <para>
    /// For a list of the AWS Regions where Global Accelerator and other services are currently
    /// supported, see the <a href="https://docs.aws.amazon.com/about-aws/global-infrastructure/regional-product-services/">AWS
    /// Region Table</a>.
    /// </para>
    ///  
    /// <para>
    /// AWS Global Accelerator includes the following components:
    /// </para>
    ///  <dl> <dt>Static IP addresses</dt> <dd> 
    /// <para>
    /// Global Accelerator provides you with a set of two static IP addresses that are anycast
    /// from the AWS edge network. If you bring your own IP address range to AWS (BYOIP) to
    /// use with a standard accelerator, you can instead assign IP addresses from your own
    /// pool to use with your accelerator. For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">
    /// Bring your own IP addresses (BYOIP) in AWS Global Accelerator</a>.
    /// </para>
    ///  
    /// <para>
    /// The IP addresses serve as single fixed entry points for your clients. If you already
    /// have Elastic Load Balancing load balancers, Amazon EC2 instances, or Elastic IP address
    /// resources set up for your applications, you can easily add those to a standard accelerator
    /// in Global Accelerator. This allows Global Accelerator to use static IP addresses to
    /// access the resources.
    /// </para>
    ///  
    /// <para>
    /// The static IP addresses remain assigned to your accelerator for as long as it exists,
    /// even if you disable the accelerator and it no longer accepts or routes traffic. However,
    /// when you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
    /// to it, so you can no longer route traffic by using them. You can use IAM policies
    /// like tag-based permissions with Global Accelerator to delete an accelerator. For more
    /// information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/access-control-manage-access-tag-policies.html">Tag-based
    /// policies</a>.
    /// </para>
    ///  </dd> <dt>Accelerator</dt> <dd> 
    /// <para>
    /// An accelerator directs traffic to endpoints over the AWS global network to improve
    /// the performance of your internet applications. Each accelerator includes one or more
    /// listeners.
    /// </para>
    ///  
    /// <para>
    /// There are two types of accelerators:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <i>standard</i> accelerator directs traffic to the optimal AWS endpoint based on
    /// several factors, including the user’s location, the health of the endpoint, and the
    /// endpoint weights that you configure. This improves the availability and performance
    /// of your applications. Endpoints can be Network Load Balancers, Application Load Balancers,
    /// Amazon EC2 instances, or Elastic IP addresses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>custom routing</i> accelerator directs traffic to one of possibly thousands of
    /// Amazon EC2 instances running in a single or multiple virtual private clouds (VPCs).
    /// With custom routing, listener ports are mapped to statically associate port ranges
    /// with VPC subnets, which allows Global Accelerator to determine an EC2 instance IP
    /// address at the time of connection. By default, all port mapping destinations in a
    /// VPC subnet can't receive traffic. You can choose to configure all destinations in
    /// the subnet to receive traffic, or to specify individual port mappings that can receive
    /// traffic.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/introduction-accelerator-types.html">Types
    /// of accelerators</a>.
    /// </para>
    ///  </dd> <dt>DNS name</dt> <dd> 
    /// <para>
    /// Global Accelerator assigns each accelerator a default Domain Name System (DNS) name,
    /// similar to <code>a1234567890abcdef.awsglobalaccelerator.com</code>, that points to
    /// the static IP addresses that Global Accelerator assigns to you or that you choose
    /// from your own IP address range. Depending on the use case, you can use your accelerator's
    /// static IP addresses or DNS name to route traffic to your accelerator, or set up DNS
    /// records to route traffic using your own custom domain name.
    /// </para>
    ///  </dd> <dt>Network zone</dt> <dd> 
    /// <para>
    /// A network zone services the static IP addresses for your accelerator from a unique
    /// IP subnet. Similar to an AWS Availability Zone, a network zone is an isolated unit
    /// with its own set of physical infrastructure. When you configure an accelerator, by
    /// default, Global Accelerator allocates two IPv4 addresses for it. If one IP address
    /// from a network zone becomes unavailable due to IP address blocking by certain client
    /// networks, or network disruptions, then client applications can retry on the healthy
    /// static IP address from the other isolated network zone.
    /// </para>
    ///  </dd> <dt>Listener</dt> <dd> 
    /// <para>
    /// A listener processes inbound connections from clients to Global Accelerator, based
    /// on the port (or port range) and protocol (or protocols) that you configure. A listener
    /// can be configured for TCP, UDP, or both TCP and UDP protocols. Each listener has one
    /// or more endpoint groups associated with it, and traffic is forwarded to endpoints
    /// in one of the groups. You associate endpoint groups with listeners by specifying the
    /// Regions that you want to distribute traffic to. With a standard accelerator, traffic
    /// is distributed to optimal endpoints within the endpoint groups associated with a listener.
    /// </para>
    ///  </dd> <dt>Endpoint group</dt> <dd> 
    /// <para>
    /// Each endpoint group is associated with a specific AWS Region. Endpoint groups include
    /// one or more endpoints in the Region. With a standard accelerator, you can increase
    /// or reduce the percentage of traffic that would be otherwise directed to an endpoint
    /// group by adjusting a setting called a <i>traffic dial</i>. The traffic dial lets you
    /// easily do performance testing or blue/green deployment testing, for example, for new
    /// releases across different AWS Regions. 
    /// </para>
    ///  </dd> <dt>Endpoint</dt> <dd> 
    /// <para>
    /// An endpoint is a resource that Global Accelerator directs traffic to.
    /// </para>
    ///  
    /// <para>
    /// Endpoints for standard accelerators can be Network Load Balancers, Application Load
    /// Balancers, Amazon EC2 instances, or Elastic IP addresses. An Application Load Balancer
    /// endpoint can be internet-facing or internal. Traffic for standard accelerators is
    /// routed to endpoints based on the health of the endpoint along with configuration options
    /// that you choose, such as endpoint weights. For each endpoint, you can configure weights,
    /// which are numbers that you can use to specify the proportion of traffic to route to
    /// each one. This can be useful, for example, to do performance testing within a Region.
    /// </para>
    ///  
    /// <para>
    /// Endpoints for custom routing accelerators are virtual private cloud (VPC) subnets
    /// with one or many EC2 instances.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonGlobalAccelerator : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGlobalAcceleratorPaginatorFactory Paginators { get; }
#endif
                
        #region  AddCustomRoutingEndpoints



        /// <summary>
        /// Associate a virtual private cloud (VPC) subnet endpoint with your custom routing accelerator.
        /// 
        ///  
        /// <para>
        /// The listener port range must be large enough to support the number of IP addresses
        /// that can be specified in your subnet. The number of ports required is: subnet size
        /// times the number of ports per destination EC2 instances. For example, a subnet defined
        /// as /24 requires a listener port range of at least 255 ports. 
        /// </para>
        ///  
        /// <para>
        /// Note: You must have enough remaining listener ports available to map to the subnet
        /// ports, or the call will fail with a LimitExceededException.
        /// </para>
        ///  
        /// <para>
        /// By default, all destinations in a subnet in a custom routing accelerator cannot receive
        /// traffic. To enable all destinations to receive traffic, or to specify individual port
        /// mappings that can receive traffic, see the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_AllowCustomRoutingTraffic.html">
        /// AllowCustomRoutingTraffic</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddCustomRoutingEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddCustomRoutingEndpoints service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ConflictException">
        /// You can't use both of those options.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointAlreadyExistsException">
        /// The endpoint that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AddCustomRoutingEndpoints">REST API Reference for AddCustomRoutingEndpoints Operation</seealso>
        Task<AddCustomRoutingEndpointsResponse> AddCustomRoutingEndpointsAsync(AddCustomRoutingEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AdvertiseByoipCidr



        /// <summary>
        /// Advertises an IPv4 address range that is provisioned for use with your AWS resources
        /// through bring your own IP addresses (BYOIP). It can take a few minutes before traffic
        /// to the specified addresses starts routing to AWS because of propagation delays. 
        /// 
        ///  
        /// <para>
        /// To stop advertising the BYOIP address range, use <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/WithdrawByoipCidr.html">
        /// WithdrawByoipCidr</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AdvertiseByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ByoipCidrNotFoundException">
        /// The CIDR that you specified was not found or is incorrect.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        Task<AdvertiseByoipCidrResponse> AdvertiseByoipCidrAsync(AdvertiseByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AllowCustomRoutingTraffic



        /// <summary>
        /// Specify the Amazon EC2 instance (destination) IP addresses and ports for a VPC subnet
        /// endpoint that can receive traffic for a custom routing accelerator. You can allow
        /// traffic to all destinations in the subnet endpoint, or allow traffic to a specified
        /// list of destination IP addresses and ports in the subnet. Note that you cannot specify
        /// IP addresses or ports outside of the range that you configured for the endpoint group.
        /// 
        ///  
        /// <para>
        /// After you make changes, you can verify that the updates are complete by checking the
        /// status of your accelerator: the status changes from IN_PROGRESS to DEPLOYED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllowCustomRoutingTraffic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllowCustomRoutingTraffic service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AllowCustomRoutingTraffic">REST API Reference for AllowCustomRoutingTraffic Operation</seealso>
        Task<AllowCustomRoutingTrafficResponse> AllowCustomRoutingTrafficAsync(AllowCustomRoutingTrafficRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccelerator



        /// <summary>
        /// Create an accelerator. An accelerator includes one or more listeners that process
        /// inbound connections and direct traffic to one or more endpoint groups, each of which
        /// includes endpoints, such as Network Load Balancers. 
        /// 
        ///  <important> 
        /// <para>
        /// Global Accelerator is a global service that supports endpoints in multiple AWS Regions
        /// but you must specify the US West (Oregon) Region to create or update accelerators.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        Task<CreateAcceleratorResponse> CreateAcceleratorAsync(CreateAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomRoutingAccelerator



        /// <summary>
        /// Create a custom routing accelerator. A custom routing accelerator directs traffic
        /// to one of possibly thousands of Amazon EC2 instance destinations running in a single
        /// or multiple virtual private clouds (VPC) subnet endpoints.
        /// 
        ///  
        /// <para>
        /// Be aware that, by default, all destination EC2 instances in a VPC subnet endpoint
        /// cannot receive traffic. To enable all destinations to receive traffic, or to specify
        /// individual port mappings that can receive traffic, see the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_AllowCustomRoutingTraffic.html">
        /// AllowCustomRoutingTraffic</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomRoutingAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingAccelerator">REST API Reference for CreateCustomRoutingAccelerator Operation</seealso>
        Task<CreateCustomRoutingAcceleratorResponse> CreateCustomRoutingAcceleratorAsync(CreateCustomRoutingAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomRoutingEndpointGroup



        /// <summary>
        /// Create an endpoint group for the specified listener for a custom routing accelerator.
        /// An endpoint group is a collection of endpoints in one AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomRoutingEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupAlreadyExistsException">
        /// The endpoint group that you specified already exists.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingEndpointGroup">REST API Reference for CreateCustomRoutingEndpointGroup Operation</seealso>
        Task<CreateCustomRoutingEndpointGroupResponse> CreateCustomRoutingEndpointGroupAsync(CreateCustomRoutingEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomRoutingListener



        /// <summary>
        /// Create a listener to process inbound connections from clients to a custom routing
        /// accelerator. Connections arrive to assigned static IP addresses on the port range
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomRoutingListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingListener">REST API Reference for CreateCustomRoutingListener Operation</seealso>
        Task<CreateCustomRoutingListenerResponse> CreateCustomRoutingListenerAsync(CreateCustomRoutingListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpointGroup



        /// <summary>
        /// Create an endpoint group for the specified listener. An endpoint group is a collection
        /// of endpoints in one AWS Region. A resource must be valid and active when you add it
        /// as an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupAlreadyExistsException">
        /// The endpoint group that you specified already exists.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        Task<CreateEndpointGroupResponse> CreateEndpointGroupAsync(CreateEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateListener



        /// <summary>
        /// Create a listener to process inbound connections from clients to an accelerator. Connections
        /// arrive to assigned static IP addresses on a port, port range, or list of port ranges
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccelerator



        /// <summary>
        /// Delete an accelerator. Before you can delete an accelerator, you must disable it and
        /// remove all dependent resources (listeners and endpoint groups). To disable the accelerator,
        /// update the accelerator to set <code>Enabled</code> to false.
        /// 
        ///  <important> 
        /// <para>
        /// When you create an accelerator, by default, Global Accelerator provides you with a
        /// set of two static IP addresses. Alternatively, you can bring your own IP address ranges
        /// to Global Accelerator and assign IP addresses from those ranges. 
        /// </para>
        ///  
        /// <para>
        /// The IP addresses are assigned to your accelerator for as long as it exists, even if
        /// you disable the accelerator and it no longer accepts or routes traffic. However, when
        /// you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
        /// to the accelerator, so you can no longer route traffic by using them. As a best practice,
        /// ensure that you have permissions in place to avoid inadvertently deleting accelerators.
        /// You can use IAM policies with Global Accelerator to limit the users who have permissions
        /// to delete an accelerator. For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/auth-and-access-control.html">Authentication
        /// and Access Control</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotDisabledException">
        /// The accelerator that you specified could not be disabled.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AssociatedListenerFoundException">
        /// The accelerator that you specified has a listener associated with it. You must remove
        /// all dependent resources from an accelerator before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        Task<DeleteAcceleratorResponse> DeleteAcceleratorAsync(DeleteAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomRoutingAccelerator



        /// <summary>
        /// Delete a custom routing accelerator. Before you can delete an accelerator, you must
        /// disable it and remove all dependent resources (listeners and endpoint groups). To
        /// disable the accelerator, update the accelerator to set <code>Enabled</code> to false.
        /// 
        ///  <important> 
        /// <para>
        /// When you create a custom routing accelerator, by default, Global Accelerator provides
        /// you with a set of two static IP addresses. 
        /// </para>
        ///  
        /// <para>
        /// The IP addresses are assigned to your accelerator for as long as it exists, even if
        /// you disable the accelerator and it no longer accepts or routes traffic. However, when
        /// you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
        /// to the accelerator, so you can no longer route traffic by using them. As a best practice,
        /// ensure that you have permissions in place to avoid inadvertently deleting accelerators.
        /// You can use IAM policies with Global Accelerator to limit the users who have permissions
        /// to delete an accelerator. For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/auth-and-access-control.html">Authentication
        /// and Access Control</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomRoutingAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotDisabledException">
        /// The accelerator that you specified could not be disabled.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AssociatedListenerFoundException">
        /// The accelerator that you specified has a listener associated with it. You must remove
        /// all dependent resources from an accelerator before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingAccelerator">REST API Reference for DeleteCustomRoutingAccelerator Operation</seealso>
        Task<DeleteCustomRoutingAcceleratorResponse> DeleteCustomRoutingAcceleratorAsync(DeleteCustomRoutingAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomRoutingEndpointGroup



        /// <summary>
        /// Delete an endpoint group from a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomRoutingEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingEndpointGroup">REST API Reference for DeleteCustomRoutingEndpointGroup Operation</seealso>
        Task<DeleteCustomRoutingEndpointGroupResponse> DeleteCustomRoutingEndpointGroupAsync(DeleteCustomRoutingEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomRoutingListener



        /// <summary>
        /// Delete a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomRoutingListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AssociatedEndpointGroupFoundException">
        /// The listener that you specified has an endpoint group associated with it. You must
        /// remove all dependent resources from a listener before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingListener">REST API Reference for DeleteCustomRoutingListener Operation</seealso>
        Task<DeleteCustomRoutingListenerResponse> DeleteCustomRoutingListenerAsync(DeleteCustomRoutingListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpointGroup



        /// <summary>
        /// Delete an endpoint group from a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        Task<DeleteEndpointGroupResponse> DeleteEndpointGroupAsync(DeleteEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteListener



        /// <summary>
        /// Delete a listener from an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AssociatedEndpointGroupFoundException">
        /// The listener that you specified has an endpoint group associated with it. You must
        /// remove all dependent resources from a listener before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DenyCustomRoutingTraffic



        /// <summary>
        /// Specify the Amazon EC2 instance (destination) IP addresses and ports for a VPC subnet
        /// endpoint that cannot receive traffic for a custom routing accelerator. You can deny
        /// traffic to all destinations in the VPC endpoint, or deny traffic to a specified list
        /// of destination IP addresses and ports. Note that you cannot specify IP addresses or
        /// ports outside of the range that you configured for the endpoint group.
        /// 
        ///  
        /// <para>
        /// After you make changes, you can verify that the updates are complete by checking the
        /// status of your accelerator: the status changes from IN_PROGRESS to DEPLOYED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DenyCustomRoutingTraffic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DenyCustomRoutingTraffic service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DenyCustomRoutingTraffic">REST API Reference for DenyCustomRoutingTraffic Operation</seealso>
        Task<DenyCustomRoutingTrafficResponse> DenyCustomRoutingTrafficAsync(DenyCustomRoutingTrafficRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprovisionByoipCidr



        /// <summary>
        /// Releases the specified address range that you provisioned to use with your AWS resources
        /// through bring your own IP addresses (BYOIP) and deletes the corresponding address
        /// pool. 
        /// 
        ///  
        /// <para>
        /// Before you can release an address range, you must stop advertising it by using <a
        /// href="https://docs.aws.amazon.com/global-accelerator/latest/api/WithdrawByoipCidr.html">WithdrawByoipCidr</a>
        /// and you must not have any accelerators that are using static IP addresses allocated
        /// from its address range. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprovisionByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ByoipCidrNotFoundException">
        /// The CIDR that you specified was not found or is incorrect.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        Task<DeprovisionByoipCidrResponse> DeprovisionByoipCidrAsync(DeprovisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccelerator



        /// <summary>
        /// Describe an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        Task<DescribeAcceleratorResponse> DescribeAcceleratorAsync(DescribeAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAcceleratorAttributes



        /// <summary>
        /// Describe the attributes of an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcceleratorAttributes service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        Task<DescribeAcceleratorAttributesResponse> DescribeAcceleratorAttributesAsync(DescribeAcceleratorAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomRoutingAccelerator



        /// <summary>
        /// Describe a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomRoutingAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingAccelerator">REST API Reference for DescribeCustomRoutingAccelerator Operation</seealso>
        Task<DescribeCustomRoutingAcceleratorResponse> DescribeCustomRoutingAcceleratorAsync(DescribeCustomRoutingAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomRoutingAcceleratorAttributes



        /// <summary>
        /// Describe the attributes of a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingAcceleratorAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomRoutingAcceleratorAttributes service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingAcceleratorAttributes">REST API Reference for DescribeCustomRoutingAcceleratorAttributes Operation</seealso>
        Task<DescribeCustomRoutingAcceleratorAttributesResponse> DescribeCustomRoutingAcceleratorAttributesAsync(DescribeCustomRoutingAcceleratorAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomRoutingEndpointGroup



        /// <summary>
        /// Describe an endpoint group for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomRoutingEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingEndpointGroup">REST API Reference for DescribeCustomRoutingEndpointGroup Operation</seealso>
        Task<DescribeCustomRoutingEndpointGroupResponse> DescribeCustomRoutingEndpointGroupAsync(DescribeCustomRoutingEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomRoutingListener



        /// <summary>
        /// The description of a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomRoutingListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingListener">REST API Reference for DescribeCustomRoutingListener Operation</seealso>
        Task<DescribeCustomRoutingListenerResponse> DescribeCustomRoutingListenerAsync(DescribeCustomRoutingListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpointGroup



        /// <summary>
        /// Describe an endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        Task<DescribeEndpointGroupResponse> DescribeEndpointGroupAsync(DescribeEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeListener



        /// <summary>
        /// Describe a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        Task<DescribeListenerResponse> DescribeListenerAsync(DescribeListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccelerators



        /// <summary>
        /// List the accelerators for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccelerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccelerators service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        Task<ListAcceleratorsResponse> ListAcceleratorsAsync(ListAcceleratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListByoipCidrs



        /// <summary>
        /// Lists the IP address ranges that were specified in calls to <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/ProvisionByoipCidr.html">ProvisionByoipCidr</a>,
        /// including the current state and a history of state changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByoipCidrs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListByoipCidrs service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListByoipCidrs">REST API Reference for ListByoipCidrs Operation</seealso>
        Task<ListByoipCidrsResponse> ListByoipCidrsAsync(ListByoipCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomRoutingAccelerators



        /// <summary>
        /// List the custom routing accelerators for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingAccelerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomRoutingAccelerators service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingAccelerators">REST API Reference for ListCustomRoutingAccelerators Operation</seealso>
        Task<ListCustomRoutingAcceleratorsResponse> ListCustomRoutingAcceleratorsAsync(ListCustomRoutingAcceleratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomRoutingEndpointGroups



        /// <summary>
        /// List the endpoint groups that are associated with a listener for a custom routing
        /// accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingEndpointGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomRoutingEndpointGroups service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingEndpointGroups">REST API Reference for ListCustomRoutingEndpointGroups Operation</seealso>
        Task<ListCustomRoutingEndpointGroupsResponse> ListCustomRoutingEndpointGroupsAsync(ListCustomRoutingEndpointGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomRoutingListeners



        /// <summary>
        /// List the listeners for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomRoutingListeners service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingListeners">REST API Reference for ListCustomRoutingListeners Operation</seealso>
        Task<ListCustomRoutingListenersResponse> ListCustomRoutingListenersAsync(ListCustomRoutingListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomRoutingPortMappings



        /// <summary>
        /// Provides a complete mapping from the public accelerator IP address and port to destination
        /// EC2 instance IP addresses and ports in the virtual public cloud (VPC) subnet endpoint
        /// for a custom routing accelerator. For each subnet endpoint that you add, Global Accelerator
        /// creates a new static port mapping for the accelerator. The port mappings don't change
        /// after Global Accelerator generates them, so you can retrieve and cache the full mapping
        /// on your servers. 
        /// 
        ///  
        /// <para>
        /// If you remove a subnet from your accelerator, Global Accelerator removes (reclaims)
        /// the port mappings. If you add a subnet to your accelerator, Global Accelerator creates
        /// new port mappings (the existing ones don't change). If you add or remove EC2 instances
        /// in your subnet, the port mappings don't change, because the mappings are created when
        /// you add the subnet to Global Accelerator.
        /// </para>
        ///  
        /// <para>
        /// The mappings also include a flag for each destination denoting which destination IP
        /// addresses and ports are allowed or denied traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingPortMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomRoutingPortMappings service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingPortMappings">REST API Reference for ListCustomRoutingPortMappings Operation</seealso>
        Task<ListCustomRoutingPortMappingsResponse> ListCustomRoutingPortMappingsAsync(ListCustomRoutingPortMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomRoutingPortMappingsByDestination



        /// <summary>
        /// List the port mappings for a specific EC2 instance (destination) in a VPC subnet endpoint.
        /// The response is the mappings for one destination IP address. This is useful when your
        /// subnet endpoint has mappings that span multiple custom routing accelerators in your
        /// account, or for scenarios where you only want to list the port mappings for a specific
        /// destination instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingPortMappingsByDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomRoutingPortMappingsByDestination service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointNotFoundException">
        /// The endpoint that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingPortMappingsByDestination">REST API Reference for ListCustomRoutingPortMappingsByDestination Operation</seealso>
        Task<ListCustomRoutingPortMappingsByDestinationResponse> ListCustomRoutingPortMappingsByDestinationAsync(ListCustomRoutingPortMappingsByDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEndpointGroups



        /// <summary>
        /// List the endpoint groups that are associated with a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpointGroups service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        Task<ListEndpointGroupsResponse> ListEndpointGroupsAsync(ListEndpointGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListListeners



        /// <summary>
        /// List the listeners for an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListListeners service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List all tags for an accelerator. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ProvisionByoipCidr



        /// <summary>
        /// Provisions an IP address range to use with your AWS resources through bring your own
        /// IP addresses (BYOIP) and creates a corresponding address pool. After the address range
        /// is provisioned, it is ready to be advertised using <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/AdvertiseByoipCidr.html">
        /// AdvertiseByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        Task<ProvisionByoipCidrResponse> ProvisionByoipCidrAsync(ProvisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveCustomRoutingEndpoints



        /// <summary>
        /// Remove endpoints from a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveCustomRoutingEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveCustomRoutingEndpoints service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ConflictException">
        /// You can't use both of those options.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointNotFoundException">
        /// The endpoint that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/RemoveCustomRoutingEndpoints">REST API Reference for RemoveCustomRoutingEndpoints Operation</seealso>
        Task<RemoveCustomRoutingEndpointsResponse> RemoveCustomRoutingEndpointsAsync(RemoveCustomRoutingEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Add tags to an accelerator resource. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Remove tags from a Global Accelerator resource. When you specify a tag key, the action
        /// removes both that key and its associated value. The operation succeeds even if you
        /// attempt to remove tags from an accelerator that was already removed.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccelerator



        /// <summary>
        /// Update an accelerator. 
        /// 
        ///  <important> 
        /// <para>
        /// Global Accelerator is a global service that supports endpoints in multiple AWS Regions
        /// but you must specify the US West (Oregon) Region to create or update accelerators.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        Task<UpdateAcceleratorResponse> UpdateAcceleratorAsync(UpdateAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAcceleratorAttributes



        /// <summary>
        /// Update the attributes for an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcceleratorAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAcceleratorAttributes service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        Task<UpdateAcceleratorAttributesResponse> UpdateAcceleratorAttributesAsync(UpdateAcceleratorAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCustomRoutingAccelerator



        /// <summary>
        /// Update a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingAccelerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomRoutingAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingAccelerator">REST API Reference for UpdateCustomRoutingAccelerator Operation</seealso>
        Task<UpdateCustomRoutingAcceleratorResponse> UpdateCustomRoutingAcceleratorAsync(UpdateCustomRoutingAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCustomRoutingAcceleratorAttributes



        /// <summary>
        /// Update the attributes for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingAcceleratorAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomRoutingAcceleratorAttributes service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingAcceleratorAttributes">REST API Reference for UpdateCustomRoutingAcceleratorAttributes Operation</seealso>
        Task<UpdateCustomRoutingAcceleratorAttributesResponse> UpdateCustomRoutingAcceleratorAttributesAsync(UpdateCustomRoutingAcceleratorAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCustomRoutingListener



        /// <summary>
        /// Update a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomRoutingListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingListener">REST API Reference for UpdateCustomRoutingListener Operation</seealso>
        Task<UpdateCustomRoutingListenerResponse> UpdateCustomRoutingListenerAsync(UpdateCustomRoutingListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpointGroup



        /// <summary>
        /// Update an endpoint group. A resource must be valid and active when you add it as an
        /// endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        Task<UpdateEndpointGroupResponse> UpdateEndpointGroupAsync(UpdateEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateListener



        /// <summary>
        /// Update a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  WithdrawByoipCidr



        /// <summary>
        /// Stops advertising an address range that is provisioned as an address pool. You can
        /// perform this operation at most once every 10 seconds, even if you specify different
        /// address ranges each time.
        /// 
        ///  
        /// <para>
        /// It can take a few minutes before traffic to the specified addresses stops routing
        /// to AWS because of propagation delays.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the WithdrawByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ByoipCidrNotFoundException">
        /// The CIDR that you specified was not found or is incorrect.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        Task<WithdrawByoipCidrResponse> WithdrawByoipCidrAsync(WithdrawByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}