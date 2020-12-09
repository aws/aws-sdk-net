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
using System.Collections.Generic;
using System.Net;

using Amazon.GlobalAccelerator.Model;
using Amazon.GlobalAccelerator.Model.Internal.MarshallTransformations;
using Amazon.GlobalAccelerator.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GlobalAccelerator
{
    /// <summary>
    /// Implementation for accessing GlobalAccelerator
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
    public partial class AmazonGlobalAcceleratorClient : AmazonServiceClient, IAmazonGlobalAccelerator
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlobalAcceleratorMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with the credentials loaded from the application's
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
        public AmazonGlobalAcceleratorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlobalAcceleratorConfig()) { }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with the credentials loaded from the application's
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
        public AmazonGlobalAcceleratorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlobalAcceleratorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlobalAcceleratorClient Configuration Object</param>
        public AmazonGlobalAcceleratorClient(AmazonGlobalAcceleratorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlobalAcceleratorClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlobalAcceleratorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlobalAcceleratorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlobalAcceleratorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Credentials and an
        /// AmazonGlobalAcceleratorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlobalAcceleratorClient Configuration Object</param>
        public AmazonGlobalAcceleratorClient(AWSCredentials credentials, AmazonGlobalAcceleratorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlobalAcceleratorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlobalAcceleratorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlobalAcceleratorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlobalAcceleratorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlobalAcceleratorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlobalAcceleratorClient Configuration Object</param>
        public AmazonGlobalAcceleratorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlobalAcceleratorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlobalAcceleratorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlobalAcceleratorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlobalAcceleratorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlobalAcceleratorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlobalAcceleratorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlobalAcceleratorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlobalAcceleratorClient Configuration Object</param>
        public AmazonGlobalAcceleratorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlobalAcceleratorConfig clientConfig)
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
        public virtual AddCustomRoutingEndpointsResponse AddCustomRoutingEndpoints(AddCustomRoutingEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomRoutingEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomRoutingEndpointsResponseUnmarshaller.Instance;

            return Invoke<AddCustomRoutingEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomRoutingEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomRoutingEndpoints operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddCustomRoutingEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AddCustomRoutingEndpoints">REST API Reference for AddCustomRoutingEndpoints Operation</seealso>
        public virtual IAsyncResult BeginAddCustomRoutingEndpoints(AddCustomRoutingEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomRoutingEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomRoutingEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddCustomRoutingEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddCustomRoutingEndpoints.</param>
        /// 
        /// <returns>Returns a  AddCustomRoutingEndpointsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AddCustomRoutingEndpoints">REST API Reference for AddCustomRoutingEndpoints Operation</seealso>
        public virtual AddCustomRoutingEndpointsResponse EndAddCustomRoutingEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<AddCustomRoutingEndpointsResponse>(asyncResult);
        }

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
        public virtual AdvertiseByoipCidrResponse AdvertiseByoipCidr(AdvertiseByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdvertiseByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdvertiseByoipCidrResponseUnmarshaller.Instance;

            return Invoke<AdvertiseByoipCidrResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdvertiseByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdvertiseByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        public virtual IAsyncResult BeginAdvertiseByoipCidr(AdvertiseByoipCidrRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdvertiseByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdvertiseByoipCidrResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AdvertiseByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdvertiseByoipCidr.</param>
        /// 
        /// <returns>Returns a  AdvertiseByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        public virtual AdvertiseByoipCidrResponse EndAdvertiseByoipCidr(IAsyncResult asyncResult)
        {
            return EndInvoke<AdvertiseByoipCidrResponse>(asyncResult);
        }

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
        /// 
        /// <returns>The response from the AllowCustomRoutingTraffic service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AllowCustomRoutingTraffic">REST API Reference for AllowCustomRoutingTraffic Operation</seealso>
        public virtual AllowCustomRoutingTrafficResponse AllowCustomRoutingTraffic(AllowCustomRoutingTrafficRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllowCustomRoutingTrafficRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllowCustomRoutingTrafficResponseUnmarshaller.Instance;

            return Invoke<AllowCustomRoutingTrafficResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllowCustomRoutingTraffic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllowCustomRoutingTraffic operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllowCustomRoutingTraffic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AllowCustomRoutingTraffic">REST API Reference for AllowCustomRoutingTraffic Operation</seealso>
        public virtual IAsyncResult BeginAllowCustomRoutingTraffic(AllowCustomRoutingTrafficRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllowCustomRoutingTrafficRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllowCustomRoutingTrafficResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AllowCustomRoutingTraffic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllowCustomRoutingTraffic.</param>
        /// 
        /// <returns>Returns a  AllowCustomRoutingTrafficResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AllowCustomRoutingTraffic">REST API Reference for AllowCustomRoutingTraffic Operation</seealso>
        public virtual AllowCustomRoutingTrafficResponse EndAllowCustomRoutingTraffic(IAsyncResult asyncResult)
        {
            return EndInvoke<AllowCustomRoutingTrafficResponse>(asyncResult);
        }

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
        public virtual CreateAcceleratorResponse CreateAccelerator(CreateAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcceleratorResponseUnmarshaller.Instance;

            return Invoke<CreateAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        public virtual IAsyncResult BeginCreateAccelerator(CreateAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccelerator.</param>
        /// 
        /// <returns>Returns a  CreateAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        public virtual CreateAcceleratorResponse EndCreateAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAcceleratorResponse>(asyncResult);
        }

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
        public virtual CreateCustomRoutingAcceleratorResponse CreateCustomRoutingAccelerator(CreateCustomRoutingAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return Invoke<CreateCustomRoutingAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomRoutingAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingAccelerator">REST API Reference for CreateCustomRoutingAccelerator Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomRoutingAccelerator(CreateCustomRoutingAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomRoutingAccelerator.</param>
        /// 
        /// <returns>Returns a  CreateCustomRoutingAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingAccelerator">REST API Reference for CreateCustomRoutingAccelerator Operation</seealso>
        public virtual CreateCustomRoutingAcceleratorResponse EndCreateCustomRoutingAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomRoutingAcceleratorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomRoutingEndpointGroup

        /// <summary>
        /// Create an endpoint group for the specified listener for a custom routing accelerator.
        /// An endpoint group is a collection of endpoints in one AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingEndpointGroup service method.</param>
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
        public virtual CreateCustomRoutingEndpointGroupResponse CreateCustomRoutingEndpointGroup(CreateCustomRoutingEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomRoutingEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomRoutingEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCustomRoutingEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomRoutingEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomRoutingEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingEndpointGroup">REST API Reference for CreateCustomRoutingEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomRoutingEndpointGroup(CreateCustomRoutingEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomRoutingEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomRoutingEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomRoutingEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomRoutingEndpointGroup.</param>
        /// 
        /// <returns>Returns a  CreateCustomRoutingEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingEndpointGroup">REST API Reference for CreateCustomRoutingEndpointGroup Operation</seealso>
        public virtual CreateCustomRoutingEndpointGroupResponse EndCreateCustomRoutingEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomRoutingEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomRoutingListener

        /// <summary>
        /// Create a listener to process inbound connections from clients to a custom routing
        /// accelerator. Connections arrive to assigned static IP addresses on the port range
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingListener service method.</param>
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
        public virtual CreateCustomRoutingListenerResponse CreateCustomRoutingListener(CreateCustomRoutingListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomRoutingListenerResponseUnmarshaller.Instance;

            return Invoke<CreateCustomRoutingListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomRoutingListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomRoutingListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingListener">REST API Reference for CreateCustomRoutingListener Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomRoutingListener(CreateCustomRoutingListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomRoutingListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomRoutingListener.</param>
        /// 
        /// <returns>Returns a  CreateCustomRoutingListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateCustomRoutingListener">REST API Reference for CreateCustomRoutingListener Operation</seealso>
        public virtual CreateCustomRoutingListenerResponse EndCreateCustomRoutingListener(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomRoutingListenerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpointGroup

        /// <summary>
        /// Create an endpoint group for the specified listener. An endpoint group is a collection
        /// of endpoints in one AWS Region. A resource must be valid and active when you add it
        /// as an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointGroup service method.</param>
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
        public virtual CreateEndpointGroupResponse CreateEndpointGroup(CreateEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpointGroup(CreateEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointGroup.</param>
        /// 
        /// <returns>Returns a  CreateEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        public virtual CreateEndpointGroupResponse EndCreateEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateListener

        /// <summary>
        /// Create a listener to process inbound connections from clients to an accelerator. Connections
        /// arrive to assigned static IP addresses on a port, port range, or list of port ranges
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
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
        public virtual CreateListenerResponse CreateListener(CreateListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return Invoke<CreateListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public virtual IAsyncResult BeginCreateListener(CreateListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateListener.</param>
        /// 
        /// <returns>Returns a  CreateListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public virtual CreateListenerResponse EndCreateListener(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateListenerResponse>(asyncResult);
        }

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
        public virtual DeleteAcceleratorResponse DeleteAccelerator(DeleteAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcceleratorResponseUnmarshaller.Instance;

            return Invoke<DeleteAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccelerator(DeleteAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccelerator.</param>
        /// 
        /// <returns>Returns a  DeleteAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        public virtual DeleteAcceleratorResponse EndDeleteAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAcceleratorResponse>(asyncResult);
        }

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
        public virtual DeleteCustomRoutingAcceleratorResponse DeleteCustomRoutingAccelerator(DeleteCustomRoutingAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomRoutingAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomRoutingAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingAccelerator">REST API Reference for DeleteCustomRoutingAccelerator Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomRoutingAccelerator(DeleteCustomRoutingAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomRoutingAccelerator.</param>
        /// 
        /// <returns>Returns a  DeleteCustomRoutingAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingAccelerator">REST API Reference for DeleteCustomRoutingAccelerator Operation</seealso>
        public virtual DeleteCustomRoutingAcceleratorResponse EndDeleteCustomRoutingAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomRoutingAcceleratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomRoutingEndpointGroup

        /// <summary>
        /// Delete an endpoint group from a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingEndpointGroup service method.</param>
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
        public virtual DeleteCustomRoutingEndpointGroupResponse DeleteCustomRoutingEndpointGroup(DeleteCustomRoutingEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomRoutingEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomRoutingEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomRoutingEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomRoutingEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomRoutingEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingEndpointGroup">REST API Reference for DeleteCustomRoutingEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomRoutingEndpointGroup(DeleteCustomRoutingEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomRoutingEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomRoutingEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomRoutingEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomRoutingEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCustomRoutingEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingEndpointGroup">REST API Reference for DeleteCustomRoutingEndpointGroup Operation</seealso>
        public virtual DeleteCustomRoutingEndpointGroupResponse EndDeleteCustomRoutingEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomRoutingEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomRoutingListener

        /// <summary>
        /// Delete a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingListener service method.</param>
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
        public virtual DeleteCustomRoutingListenerResponse DeleteCustomRoutingListener(DeleteCustomRoutingListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomRoutingListenerResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomRoutingListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomRoutingListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomRoutingListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingListener">REST API Reference for DeleteCustomRoutingListener Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomRoutingListener(DeleteCustomRoutingListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomRoutingListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomRoutingListener.</param>
        /// 
        /// <returns>Returns a  DeleteCustomRoutingListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteCustomRoutingListener">REST API Reference for DeleteCustomRoutingListener Operation</seealso>
        public virtual DeleteCustomRoutingListenerResponse EndDeleteCustomRoutingListener(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomRoutingListenerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpointGroup

        /// <summary>
        /// Delete an endpoint group from a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointGroup service method.</param>
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
        public virtual DeleteEndpointGroupResponse DeleteEndpointGroup(DeleteEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpointGroup(DeleteEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        public virtual DeleteEndpointGroupResponse EndDeleteEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteListener

        /// <summary>
        /// Delete a listener from an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
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
        public virtual DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return Invoke<DeleteListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public virtual IAsyncResult BeginDeleteListener(DeleteListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteListener.</param>
        /// 
        /// <returns>Returns a  DeleteListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public virtual DeleteListenerResponse EndDeleteListener(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteListenerResponse>(asyncResult);
        }

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
        /// 
        /// <returns>The response from the DenyCustomRoutingTraffic service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DenyCustomRoutingTraffic">REST API Reference for DenyCustomRoutingTraffic Operation</seealso>
        public virtual DenyCustomRoutingTrafficResponse DenyCustomRoutingTraffic(DenyCustomRoutingTrafficRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DenyCustomRoutingTrafficRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DenyCustomRoutingTrafficResponseUnmarshaller.Instance;

            return Invoke<DenyCustomRoutingTrafficResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DenyCustomRoutingTraffic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DenyCustomRoutingTraffic operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDenyCustomRoutingTraffic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DenyCustomRoutingTraffic">REST API Reference for DenyCustomRoutingTraffic Operation</seealso>
        public virtual IAsyncResult BeginDenyCustomRoutingTraffic(DenyCustomRoutingTrafficRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DenyCustomRoutingTrafficRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DenyCustomRoutingTrafficResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DenyCustomRoutingTraffic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDenyCustomRoutingTraffic.</param>
        /// 
        /// <returns>Returns a  DenyCustomRoutingTrafficResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DenyCustomRoutingTraffic">REST API Reference for DenyCustomRoutingTraffic Operation</seealso>
        public virtual DenyCustomRoutingTrafficResponse EndDenyCustomRoutingTraffic(IAsyncResult asyncResult)
        {
            return EndInvoke<DenyCustomRoutingTrafficResponse>(asyncResult);
        }

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
        public virtual DeprovisionByoipCidrResponse DeprovisionByoipCidr(DeprovisionByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprovisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprovisionByoipCidrResponseUnmarshaller.Instance;

            return Invoke<DeprovisionByoipCidrResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeprovisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprovisionByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        public virtual IAsyncResult BeginDeprovisionByoipCidr(DeprovisionByoipCidrRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprovisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprovisionByoipCidrResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeprovisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprovisionByoipCidr.</param>
        /// 
        /// <returns>Returns a  DeprovisionByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        public virtual DeprovisionByoipCidrResponse EndDeprovisionByoipCidr(IAsyncResult asyncResult)
        {
            return EndInvoke<DeprovisionByoipCidrResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccelerator

        /// <summary>
        /// Describe an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerator service method.</param>
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
        public virtual DescribeAcceleratorResponse DescribeAccelerator(DescribeAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccelerator(DescribeAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccelerator.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        public virtual DescribeAcceleratorResponse EndDescribeAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAcceleratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAcceleratorAttributes

        /// <summary>
        /// Describe the attributes of an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorAttributes service method.</param>
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
        public virtual DescribeAcceleratorAttributesResponse DescribeAcceleratorAttributes(DescribeAcceleratorAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorAttributes operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAcceleratorAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAcceleratorAttributes(DescribeAcceleratorAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAcceleratorAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorAttributesResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        public virtual DescribeAcceleratorAttributesResponse EndDescribeAcceleratorAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAcceleratorAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomRoutingAccelerator

        /// <summary>
        /// Describe a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingAccelerator service method.</param>
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
        public virtual DescribeCustomRoutingAcceleratorResponse DescribeCustomRoutingAccelerator(DescribeCustomRoutingAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomRoutingAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomRoutingAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingAccelerator">REST API Reference for DescribeCustomRoutingAccelerator Operation</seealso>
        public virtual IAsyncResult BeginDescribeCustomRoutingAccelerator(DescribeCustomRoutingAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomRoutingAccelerator.</param>
        /// 
        /// <returns>Returns a  DescribeCustomRoutingAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingAccelerator">REST API Reference for DescribeCustomRoutingAccelerator Operation</seealso>
        public virtual DescribeCustomRoutingAcceleratorResponse EndDescribeCustomRoutingAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomRoutingAcceleratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomRoutingAcceleratorAttributes

        /// <summary>
        /// Describe the attributes of a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingAcceleratorAttributes service method.</param>
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
        public virtual DescribeCustomRoutingAcceleratorAttributesResponse DescribeCustomRoutingAcceleratorAttributes(DescribeCustomRoutingAcceleratorAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingAcceleratorAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomRoutingAcceleratorAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomRoutingAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingAcceleratorAttributes operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomRoutingAcceleratorAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingAcceleratorAttributes">REST API Reference for DescribeCustomRoutingAcceleratorAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeCustomRoutingAcceleratorAttributes(DescribeCustomRoutingAcceleratorAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingAcceleratorAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomRoutingAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomRoutingAcceleratorAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeCustomRoutingAcceleratorAttributesResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingAcceleratorAttributes">REST API Reference for DescribeCustomRoutingAcceleratorAttributes Operation</seealso>
        public virtual DescribeCustomRoutingAcceleratorAttributesResponse EndDescribeCustomRoutingAcceleratorAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomRoutingAcceleratorAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomRoutingEndpointGroup

        /// <summary>
        /// Describe an endpoint group for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingEndpointGroup service method.</param>
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
        public virtual DescribeCustomRoutingEndpointGroupResponse DescribeCustomRoutingEndpointGroup(DescribeCustomRoutingEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomRoutingEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomRoutingEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomRoutingEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingEndpointGroup">REST API Reference for DescribeCustomRoutingEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeCustomRoutingEndpointGroup(DescribeCustomRoutingEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomRoutingEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomRoutingEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DescribeCustomRoutingEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingEndpointGroup">REST API Reference for DescribeCustomRoutingEndpointGroup Operation</seealso>
        public virtual DescribeCustomRoutingEndpointGroupResponse EndDescribeCustomRoutingEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomRoutingEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomRoutingListener

        /// <summary>
        /// The description of a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingListener service method.</param>
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
        public virtual DescribeCustomRoutingListenerResponse DescribeCustomRoutingListener(DescribeCustomRoutingListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingListenerResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomRoutingListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomRoutingListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomRoutingListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingListener">REST API Reference for DescribeCustomRoutingListener Operation</seealso>
        public virtual IAsyncResult BeginDescribeCustomRoutingListener(DescribeCustomRoutingListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomRoutingListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomRoutingListener.</param>
        /// 
        /// <returns>Returns a  DescribeCustomRoutingListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeCustomRoutingListener">REST API Reference for DescribeCustomRoutingListener Operation</seealso>
        public virtual DescribeCustomRoutingListenerResponse EndDescribeCustomRoutingListener(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomRoutingListenerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpointGroup

        /// <summary>
        /// Describe an endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointGroup service method.</param>
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
        public virtual DescribeEndpointGroupResponse DescribeEndpointGroup(DescribeEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpointGroup(DescribeEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        public virtual DescribeEndpointGroupResponse EndDescribeEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeListener

        /// <summary>
        /// Describe a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListener service method.</param>
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
        public virtual DescribeListenerResponse DescribeListener(DescribeListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeListenerResponseUnmarshaller.Instance;

            return Invoke<DescribeListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        public virtual IAsyncResult BeginDescribeListener(DescribeListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeListener.</param>
        /// 
        /// <returns>Returns a  DescribeListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        public virtual DescribeListenerResponse EndDescribeListener(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeListenerResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccelerators

        /// <summary>
        /// List the accelerators for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccelerators service method.</param>
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
        public virtual ListAcceleratorsResponse ListAccelerators(ListAcceleratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceleratorsResponseUnmarshaller.Instance;

            return Invoke<ListAcceleratorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccelerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccelerators operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccelerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        public virtual IAsyncResult BeginListAccelerators(ListAcceleratorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAcceleratorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccelerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccelerators.</param>
        /// 
        /// <returns>Returns a  ListAcceleratorsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        public virtual ListAcceleratorsResponse EndListAccelerators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAcceleratorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListByoipCidrs

        /// <summary>
        /// Lists the IP address ranges that were specified in calls to <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/ProvisionByoipCidr.html">ProvisionByoipCidr</a>,
        /// including the current state and a history of state changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByoipCidrs service method.</param>
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
        public virtual ListByoipCidrsResponse ListByoipCidrs(ListByoipCidrsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListByoipCidrsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListByoipCidrsResponseUnmarshaller.Instance;

            return Invoke<ListByoipCidrsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListByoipCidrs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListByoipCidrs operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListByoipCidrs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListByoipCidrs">REST API Reference for ListByoipCidrs Operation</seealso>
        public virtual IAsyncResult BeginListByoipCidrs(ListByoipCidrsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListByoipCidrsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListByoipCidrsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListByoipCidrs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListByoipCidrs.</param>
        /// 
        /// <returns>Returns a  ListByoipCidrsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListByoipCidrs">REST API Reference for ListByoipCidrs Operation</seealso>
        public virtual ListByoipCidrsResponse EndListByoipCidrs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListByoipCidrsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomRoutingAccelerators

        /// <summary>
        /// List the custom routing accelerators for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingAccelerators service method.</param>
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
        public virtual ListCustomRoutingAcceleratorsResponse ListCustomRoutingAccelerators(ListCustomRoutingAcceleratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingAcceleratorsResponseUnmarshaller.Instance;

            return Invoke<ListCustomRoutingAcceleratorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomRoutingAccelerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingAccelerators operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomRoutingAccelerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingAccelerators">REST API Reference for ListCustomRoutingAccelerators Operation</seealso>
        public virtual IAsyncResult BeginListCustomRoutingAccelerators(ListCustomRoutingAcceleratorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingAcceleratorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomRoutingAccelerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomRoutingAccelerators.</param>
        /// 
        /// <returns>Returns a  ListCustomRoutingAcceleratorsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingAccelerators">REST API Reference for ListCustomRoutingAccelerators Operation</seealso>
        public virtual ListCustomRoutingAcceleratorsResponse EndListCustomRoutingAccelerators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomRoutingAcceleratorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomRoutingEndpointGroups

        /// <summary>
        /// List the endpoint groups that are associated with a listener for a custom routing
        /// accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingEndpointGroups service method.</param>
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
        public virtual ListCustomRoutingEndpointGroupsResponse ListCustomRoutingEndpointGroups(ListCustomRoutingEndpointGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingEndpointGroupsResponseUnmarshaller.Instance;

            return Invoke<ListCustomRoutingEndpointGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomRoutingEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingEndpointGroups operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomRoutingEndpointGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingEndpointGroups">REST API Reference for ListCustomRoutingEndpointGroups Operation</seealso>
        public virtual IAsyncResult BeginListCustomRoutingEndpointGroups(ListCustomRoutingEndpointGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingEndpointGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomRoutingEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomRoutingEndpointGroups.</param>
        /// 
        /// <returns>Returns a  ListCustomRoutingEndpointGroupsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingEndpointGroups">REST API Reference for ListCustomRoutingEndpointGroups Operation</seealso>
        public virtual ListCustomRoutingEndpointGroupsResponse EndListCustomRoutingEndpointGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomRoutingEndpointGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomRoutingListeners

        /// <summary>
        /// List the listeners for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingListeners service method.</param>
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
        public virtual ListCustomRoutingListenersResponse ListCustomRoutingListeners(ListCustomRoutingListenersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingListenersResponseUnmarshaller.Instance;

            return Invoke<ListCustomRoutingListenersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomRoutingListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingListeners operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomRoutingListeners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingListeners">REST API Reference for ListCustomRoutingListeners Operation</seealso>
        public virtual IAsyncResult BeginListCustomRoutingListeners(ListCustomRoutingListenersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingListenersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomRoutingListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomRoutingListeners.</param>
        /// 
        /// <returns>Returns a  ListCustomRoutingListenersResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingListeners">REST API Reference for ListCustomRoutingListeners Operation</seealso>
        public virtual ListCustomRoutingListenersResponse EndListCustomRoutingListeners(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomRoutingListenersResponse>(asyncResult);
        }

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
        public virtual ListCustomRoutingPortMappingsResponse ListCustomRoutingPortMappings(ListCustomRoutingPortMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingPortMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingPortMappingsResponseUnmarshaller.Instance;

            return Invoke<ListCustomRoutingPortMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomRoutingPortMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingPortMappings operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomRoutingPortMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingPortMappings">REST API Reference for ListCustomRoutingPortMappings Operation</seealso>
        public virtual IAsyncResult BeginListCustomRoutingPortMappings(ListCustomRoutingPortMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingPortMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingPortMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomRoutingPortMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomRoutingPortMappings.</param>
        /// 
        /// <returns>Returns a  ListCustomRoutingPortMappingsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingPortMappings">REST API Reference for ListCustomRoutingPortMappings Operation</seealso>
        public virtual ListCustomRoutingPortMappingsResponse EndListCustomRoutingPortMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomRoutingPortMappingsResponse>(asyncResult);
        }

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
        public virtual ListCustomRoutingPortMappingsByDestinationResponse ListCustomRoutingPortMappingsByDestination(ListCustomRoutingPortMappingsByDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingPortMappingsByDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingPortMappingsByDestinationResponseUnmarshaller.Instance;

            return Invoke<ListCustomRoutingPortMappingsByDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomRoutingPortMappingsByDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomRoutingPortMappingsByDestination operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomRoutingPortMappingsByDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingPortMappingsByDestination">REST API Reference for ListCustomRoutingPortMappingsByDestination Operation</seealso>
        public virtual IAsyncResult BeginListCustomRoutingPortMappingsByDestination(ListCustomRoutingPortMappingsByDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomRoutingPortMappingsByDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomRoutingPortMappingsByDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomRoutingPortMappingsByDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomRoutingPortMappingsByDestination.</param>
        /// 
        /// <returns>Returns a  ListCustomRoutingPortMappingsByDestinationResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListCustomRoutingPortMappingsByDestination">REST API Reference for ListCustomRoutingPortMappingsByDestination Operation</seealso>
        public virtual ListCustomRoutingPortMappingsByDestinationResponse EndListCustomRoutingPortMappingsByDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomRoutingPortMappingsByDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEndpointGroups

        /// <summary>
        /// List the endpoint groups that are associated with a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointGroups service method.</param>
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
        public virtual ListEndpointGroupsResponse ListEndpointGroups(ListEndpointGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointGroupsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointGroups operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        public virtual IAsyncResult BeginListEndpointGroups(ListEndpointGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointGroups.</param>
        /// 
        /// <returns>Returns a  ListEndpointGroupsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        public virtual ListEndpointGroupsResponse EndListEndpointGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEndpointGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListListeners

        /// <summary>
        /// List the listeners for an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
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
        public virtual ListListenersResponse ListListeners(ListListenersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListListenersResponseUnmarshaller.Instance;

            return Invoke<ListListenersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListListeners operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListListeners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        public virtual IAsyncResult BeginListListeners(ListListenersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListListenersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListListeners.</param>
        /// 
        /// <returns>Returns a  ListListenersResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        public virtual ListListenersResponse EndListListeners(IAsyncResult asyncResult)
        {
            return EndInvoke<ListListenersResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

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
        public virtual ProvisionByoipCidrResponse ProvisionByoipCidr(ProvisionByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionByoipCidrResponseUnmarshaller.Instance;

            return Invoke<ProvisionByoipCidrResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        public virtual IAsyncResult BeginProvisionByoipCidr(ProvisionByoipCidrRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionByoipCidrResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionByoipCidr.</param>
        /// 
        /// <returns>Returns a  ProvisionByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        public virtual ProvisionByoipCidrResponse EndProvisionByoipCidr(IAsyncResult asyncResult)
        {
            return EndInvoke<ProvisionByoipCidrResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveCustomRoutingEndpoints

        /// <summary>
        /// Remove endpoints from a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveCustomRoutingEndpoints service method.</param>
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
        public virtual RemoveCustomRoutingEndpointsResponse RemoveCustomRoutingEndpoints(RemoveCustomRoutingEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveCustomRoutingEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveCustomRoutingEndpointsResponseUnmarshaller.Instance;

            return Invoke<RemoveCustomRoutingEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveCustomRoutingEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveCustomRoutingEndpoints operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveCustomRoutingEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/RemoveCustomRoutingEndpoints">REST API Reference for RemoveCustomRoutingEndpoints Operation</seealso>
        public virtual IAsyncResult BeginRemoveCustomRoutingEndpoints(RemoveCustomRoutingEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveCustomRoutingEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveCustomRoutingEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveCustomRoutingEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveCustomRoutingEndpoints.</param>
        /// 
        /// <returns>Returns a  RemoveCustomRoutingEndpointsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/RemoveCustomRoutingEndpoints">REST API Reference for RemoveCustomRoutingEndpoints Operation</seealso>
        public virtual RemoveCustomRoutingEndpointsResponse EndRemoveCustomRoutingEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveCustomRoutingEndpointsResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

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
        public virtual UpdateAcceleratorResponse UpdateAccelerator(UpdateAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcceleratorResponseUnmarshaller.Instance;

            return Invoke<UpdateAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccelerator(UpdateAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccelerator.</param>
        /// 
        /// <returns>Returns a  UpdateAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        public virtual UpdateAcceleratorResponse EndUpdateAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAcceleratorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAcceleratorAttributes

        /// <summary>
        /// Update the attributes for an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcceleratorAttributes service method.</param>
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
        public virtual UpdateAcceleratorAttributesResponse UpdateAcceleratorAttributes(UpdateAcceleratorAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcceleratorAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateAcceleratorAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcceleratorAttributes operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAcceleratorAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateAcceleratorAttributes(UpdateAcceleratorAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAcceleratorAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAcceleratorAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateAcceleratorAttributesResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        public virtual UpdateAcceleratorAttributesResponse EndUpdateAcceleratorAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAcceleratorAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCustomRoutingAccelerator

        /// <summary>
        /// Update a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingAccelerator service method.</param>
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
        public virtual UpdateCustomRoutingAcceleratorResponse UpdateCustomRoutingAccelerator(UpdateCustomRoutingAcceleratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomRoutingAcceleratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomRoutingAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingAccelerator">REST API Reference for UpdateCustomRoutingAccelerator Operation</seealso>
        public virtual IAsyncResult BeginUpdateCustomRoutingAccelerator(UpdateCustomRoutingAcceleratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomRoutingAcceleratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomRoutingAcceleratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomRoutingAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomRoutingAccelerator.</param>
        /// 
        /// <returns>Returns a  UpdateCustomRoutingAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingAccelerator">REST API Reference for UpdateCustomRoutingAccelerator Operation</seealso>
        public virtual UpdateCustomRoutingAcceleratorResponse EndUpdateCustomRoutingAccelerator(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCustomRoutingAcceleratorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCustomRoutingAcceleratorAttributes

        /// <summary>
        /// Update the attributes for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingAcceleratorAttributes service method.</param>
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
        public virtual UpdateCustomRoutingAcceleratorAttributesResponse UpdateCustomRoutingAcceleratorAttributes(UpdateCustomRoutingAcceleratorAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomRoutingAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomRoutingAcceleratorAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomRoutingAcceleratorAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomRoutingAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingAcceleratorAttributes operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomRoutingAcceleratorAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingAcceleratorAttributes">REST API Reference for UpdateCustomRoutingAcceleratorAttributes Operation</seealso>
        public virtual IAsyncResult BeginUpdateCustomRoutingAcceleratorAttributes(UpdateCustomRoutingAcceleratorAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomRoutingAcceleratorAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomRoutingAcceleratorAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomRoutingAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomRoutingAcceleratorAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateCustomRoutingAcceleratorAttributesResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingAcceleratorAttributes">REST API Reference for UpdateCustomRoutingAcceleratorAttributes Operation</seealso>
        public virtual UpdateCustomRoutingAcceleratorAttributesResponse EndUpdateCustomRoutingAcceleratorAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCustomRoutingAcceleratorAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCustomRoutingListener

        /// <summary>
        /// Update a listener for a custom routing accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingListener service method.</param>
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
        public virtual UpdateCustomRoutingListenerResponse UpdateCustomRoutingListener(UpdateCustomRoutingListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomRoutingListenerResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomRoutingListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomRoutingListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomRoutingListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingListener">REST API Reference for UpdateCustomRoutingListener Operation</seealso>
        public virtual IAsyncResult BeginUpdateCustomRoutingListener(UpdateCustomRoutingListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomRoutingListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomRoutingListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomRoutingListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomRoutingListener.</param>
        /// 
        /// <returns>Returns a  UpdateCustomRoutingListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateCustomRoutingListener">REST API Reference for UpdateCustomRoutingListener Operation</seealso>
        public virtual UpdateCustomRoutingListenerResponse EndUpdateCustomRoutingListener(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCustomRoutingListenerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpointGroup

        /// <summary>
        /// Update an endpoint group. A resource must be valid and active when you add it as an
        /// endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointGroup service method.</param>
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
        public virtual UpdateEndpointGroupResponse UpdateEndpointGroup(UpdateEndpointGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpointGroup(UpdateEndpointGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointGroup.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        public virtual UpdateEndpointGroupResponse EndUpdateEndpointGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateListener

        /// <summary>
        /// Update a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
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
        public virtual UpdateListenerResponse UpdateListener(UpdateListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateListenerResponseUnmarshaller.Instance;

            return Invoke<UpdateListenerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        public virtual IAsyncResult BeginUpdateListener(UpdateListenerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateListenerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateListener.</param>
        /// 
        /// <returns>Returns a  UpdateListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        public virtual UpdateListenerResponse EndUpdateListener(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateListenerResponse>(asyncResult);
        }

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
        public virtual WithdrawByoipCidrResponse WithdrawByoipCidr(WithdrawByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WithdrawByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WithdrawByoipCidrResponseUnmarshaller.Instance;

            return Invoke<WithdrawByoipCidrResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the WithdrawByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndWithdrawByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        public virtual IAsyncResult BeginWithdrawByoipCidr(WithdrawByoipCidrRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WithdrawByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WithdrawByoipCidrResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  WithdrawByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginWithdrawByoipCidr.</param>
        /// 
        /// <returns>Returns a  WithdrawByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        public virtual WithdrawByoipCidrResponse EndWithdrawByoipCidr(IAsyncResult asyncResult)
        {
            return EndInvoke<WithdrawByoipCidrResponse>(asyncResult);
        }

        #endregion
        
    }
}