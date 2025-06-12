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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a route server and its configuration.
    /// 
    ///  
    /// <para>
    /// Amazon VPC Route Server simplifies routing for traffic between workloads that are
    /// deployed within a VPC and its internet gateways. With this feature, VPC Route Server
    /// dynamically updates VPC and internet gateway route tables with your preferred IPv4
    /// or IPv6 routes to achieve routing fault tolerance for those workloads. This enables
    /// you to automatically reroute traffic within a VPC, which increases the manageability
    /// of VPC routing and interoperability with third-party workloads.
    /// </para>
    ///  
    /// <para>
    /// Route server supports the follow route table types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// VPC route tables not associated with subnets
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Subnet route tables
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Internet gateway route tables
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Route server does not support route tables associated with virtual private gateways.
    /// To propagate routes into a transit gateway route table, use <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-connect.html">Transit
    /// Gateway Connect</a>.
    /// </para>
    /// </summary>
    public partial class RouteServer
    {
        private long? _amazonSideAsn;
        private long? _persistRoutesDuration;
        private RouteServerPersistRoutesState _persistRoutesState;
        private string _routeServerId;
        private bool? _snsNotificationsEnabled;
        private string _snsTopicArn;
        private RouteServerState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The Border Gateway Protocol (BGP) Autonomous System Number (ASN) for the appliance.
        /// Valid values are from 1 to 4294967295. We recommend using a private ASN in the 64512–65534
        /// (16-bit ASN) or 4200000000–4294967294 (32-bit ASN) range.
        /// </para>
        /// </summary>
        public long? AmazonSideAsn
        {
            get { return this._amazonSideAsn; }
            set { this._amazonSideAsn = value; }
        }

        // Check to see if AmazonSideAsn property is set
        internal bool IsSetAmazonSideAsn()
        {
            return this._amazonSideAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PersistRoutesDuration. 
        /// <para>
        /// The number of minutes a route server will wait after BGP is re-established to unpersist
        /// the routes in the FIB and RIB. Value must be in the range of 1-5. The default value
        /// is 1. Only valid if <c>persistRoutesState</c> is 'enabled'.
        /// </para>
        ///  
        /// <para>
        /// If you set the duration to 1 minute, then when your network appliance re-establishes
        /// BGP with route server, it has 1 minute to relearn it's adjacent network and advertise
        /// those routes to route server before route server resumes normal functionality. In
        /// most cases, 1 minute is probably sufficient. If, however, you have concerns that your
        /// BGP network may not be capable of fully re-establishing and re-learning everything
        /// in 1 minute, you can increase the duration up to 5 minutes.
        /// </para>
        /// </summary>
        public long? PersistRoutesDuration
        {
            get { return this._persistRoutesDuration; }
            set { this._persistRoutesDuration = value; }
        }

        // Check to see if PersistRoutesDuration property is set
        internal bool IsSetPersistRoutesDuration()
        {
            return this._persistRoutesDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PersistRoutesState. 
        /// <para>
        /// The current state of route persistence for the route server.
        /// </para>
        /// </summary>
        public RouteServerPersistRoutesState PersistRoutesState
        {
            get { return this._persistRoutesState; }
            set { this._persistRoutesState = value; }
        }

        // Check to see if PersistRoutesState property is set
        internal bool IsSetPersistRoutesState()
        {
            return this._persistRoutesState != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The unique identifier of the route server.
        /// </para>
        /// </summary>
        public string RouteServerId
        {
            get { return this._routeServerId; }
            set { this._routeServerId = value; }
        }

        // Check to see if RouteServerId property is set
        internal bool IsSetRouteServerId()
        {
            return this._routeServerId != null;
        }

        /// <summary>
        /// Gets and sets the property SnsNotificationsEnabled. 
        /// <para>
        /// Indicates whether SNS notifications are enabled for the route server. Enabling SNS
        /// notifications persists BGP status changes to an SNS topic provisioned by Amazon Web
        /// Services.
        /// </para>
        /// </summary>
        public bool? SnsNotificationsEnabled
        {
            get { return this._snsNotificationsEnabled; }
            set { this._snsNotificationsEnabled = value; }
        }

        // Check to see if SnsNotificationsEnabled property is set
        internal bool IsSetSnsNotificationsEnabled()
        {
            return this._snsNotificationsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The ARN of the SNS topic where notifications are published.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route server.
        /// </para>
        /// </summary>
        public RouteServerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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