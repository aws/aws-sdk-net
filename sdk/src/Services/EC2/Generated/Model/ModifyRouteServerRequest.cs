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
    /// Container for the parameters to the ModifyRouteServer operation.
    /// Modifies the configuration of an existing route server.
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
    ///  
    /// <para>
    /// For more information see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/dynamic-routing-route-server.html">Dynamic
    /// routing in your VPC with VPC Route Server</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyRouteServerRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private RouteServerPersistRoutesAction _persistRoutes;
        private long? _persistRoutesDuration;
        private string _routeServerId;
        private bool? _snsNotificationsEnabled;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PersistRoutes. 
        /// <para>
        /// Specifies whether to persist routes after all BGP sessions are terminated.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// enable: Routes will be persisted in FIB and RIB after all BGP sessions are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// disable: Routes will not be persisted in FIB and RIB after all BGP sessions are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// reset: If a route server has persisted routes due to all BGP sessions having ended,
        /// reset will withdraw all routes and reset route server to an empty FIB and RIB.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RouteServerPersistRoutesAction PersistRoutes
        {
            get { return this._persistRoutes; }
            set { this._persistRoutes = value; }
        }

        // Check to see if PersistRoutes property is set
        internal bool IsSetPersistRoutes()
        {
            return this._persistRoutes != null;
        }

        /// <summary>
        /// Gets and sets the property PersistRoutesDuration. 
        /// <para>
        /// The number of minutes a route server will wait after BGP is re-established to unpersist
        /// the routes in the FIB and RIB. Value must be in the range of 1-5. Required if PersistRoutes
        /// is <c>enabled</c>.
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
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specifies whether to enable SNS notifications for route server events. Enabling SNS
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

    }
}