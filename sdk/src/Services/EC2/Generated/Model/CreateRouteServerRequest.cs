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
    /// Container for the parameters to the CreateRouteServer operation.
    /// Creates a new route server to manage dynamic routing in a VPC.
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
    public partial class CreateRouteServerRequest : AmazonEC2Request
    {
        private long? _amazonSideAsn;
        private string _clientToken;
        private bool? _dryRun;
        private RouteServerPersistRoutesAction _persistRoutes;
        private long? _persistRoutesDuration;
        private bool? _snsNotificationsEnabled;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The private Autonomous System Number (ASN) for the Amazon side of the BGP session.
        /// Valid values are from 1 to 4294967295. We recommend using a private ASN in the 64512–65534
        /// (16-bit ASN) or 4200000000–4294967294 (32-bit ASN) range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// Indicates whether routes should be persisted after all BGP sessions are terminated.
        /// </para>
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
        /// Gets and sets the property SnsNotificationsEnabled. 
        /// <para>
        /// Indicates whether SNS notifications should be enabled for route server events. Enabling
        /// SNS notifications persists BGP status changes to an SNS topic provisioned by Amazon
        /// Web Services.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the route server during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}