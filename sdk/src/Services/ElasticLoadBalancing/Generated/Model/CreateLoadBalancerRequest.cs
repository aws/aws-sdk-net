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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// Creates a Classic Load Balancer.
    /// 
    ///  
    /// <para>
    /// You can add listeners, security groups, subnets, and tags when you create your load
    /// balancer, or you can add them later using <a>CreateLoadBalancerListeners</a>, <a>ApplySecurityGroupsToLoadBalancer</a>,
    /// <a>AttachLoadBalancerToSubnets</a>, and <a>AddTags</a>.
    /// </para>
    ///  
    /// <para>
    /// To describe your current load balancers, see <a>DescribeLoadBalancers</a>. When you
    /// are finished with a load balancer, you can delete it using <a>DeleteLoadBalancer</a>.
    /// </para>
    ///  
    /// <para>
    /// You can create up to 20 load balancers per region per account. You can request an
    /// increase for the number of load balancers for your account. For more information,
    /// see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-limits.html">Limits
    /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Listener> _listeners = AWSConfigs.InitializeCollections ? new List<Listener>() : null;
        private string _loadBalancerName;
        private string _scheme;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates CreateLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer. This name must be unique within your set of load balancers for the region, must have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and cannot begin or end with a hyphen.</param>
        public CreateLoadBalancerRequest(string loadBalancerName)
        {
            _loadBalancerName = loadBalancerName;
        }

        /// <summary>
        /// Instantiates CreateLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer. This name must be unique within your set of load balancers for the region, must have a maximum of 32 characters, must contain only alphanumeric characters or hyphens, and cannot begin or end with a hyphen.</param>
        /// <param name="listeners">The listeners. For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html">Listeners for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.</param>
        /// <param name="availabilityZones">One or more Availability Zones from the same region as the load balancer. You must specify at least one Availability Zone. You can add more Availability Zones after you create the load balancer using <a>EnableAvailabilityZonesForLoadBalancer</a>.</param>
        public CreateLoadBalancerRequest(string loadBalancerName, List<Listener> listeners, List<string> availabilityZones)
        {
            _loadBalancerName = loadBalancerName;
            _listeners = listeners;
            _availabilityZones = availabilityZones;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones from the same region as the load balancer.
        /// </para>
        ///  
        /// <para>
        /// You must specify at least one Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// You can add more Availability Zones after you create the load balancer using <a>EnableAvailabilityZonesForLoadBalancer</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// The listeners.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html">Listeners
        /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Listener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this._listeners != null && (this._listeners.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        ///  
        /// <para>
        /// This name must be unique within your set of load balancers for the region, must have
        /// a maximum of 32 characters, must contain only alphanumeric characters or hyphens,
        /// and cannot begin or end with a hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The type of a load balancer. Valid only for load balancers in a VPC.
        /// </para>
        ///  
        /// <para>
        /// By default, Elastic Load Balancing creates an Internet-facing load balancer with a
        /// DNS name that resolves to public IP addresses. For more information about Internet-facing
        /// and Internal load balancers, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/how-elastic-load-balancing-works.html#load-balancer-scheme">Load
        /// Balancer Scheme</a> in the <i>Elastic Load Balancing User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>internal</c> to create a load balancer with a DNS name that resolves to
        /// private IP addresses.
        /// </para>
        /// </summary>
        public string Scheme
        {
            get { return this._scheme; }
            set { this._scheme = value; }
        }

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this._scheme != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the security groups to assign to the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of the subnets in your VPC to attach to the load balancer. Specify one subnet
        /// per Availability Zone specified in <c>AvailabilityZones</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to assign to the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information about tagging your load balancer, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/add-remove-tags.html">Tag
        /// Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}