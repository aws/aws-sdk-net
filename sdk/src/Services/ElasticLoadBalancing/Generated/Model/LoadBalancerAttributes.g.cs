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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The attributes for a load balancer.
    /// </summary>
    public partial class LoadBalancerAttributes
    {
        /// <summary>
        /// Gets and sets the property AccessLog. 
        /// <para>
        /// If enabled, the load balancer captures detailed information of all requests and delivers
        /// the information to the Amazon S3 bucket that you specify.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-access-logs.html">Enable
        /// Access Logs</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        public AccessLog AccessLog { get; set; }

        /// <summary>
        /// Checks to see if the AccessLog property is set.
        /// </summary>
        internal bool IsSetAccessLog() => this.AccessLog != null;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// Any additional attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<AdditionalAttribute> AdditionalAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalAttribute>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAttributes property is set.
        /// </summary>
        internal bool IsSetAdditionalAttributes() => this.AdditionalAttributes != null && (this.AdditionalAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionDraining. 
        /// <para>
        /// If enabled, the load balancer allows existing requests to complete before the load
        /// balancer shifts traffic away from a deregistered or unhealthy instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-conn-drain.html">Configure
        /// Connection Draining</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionDraining ConnectionDraining { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionDraining property is set.
        /// </summary>
        internal bool IsSetConnectionDraining() => this.ConnectionDraining != null;

        /// <summary>
        /// Gets and sets the property ConnectionSettings. 
        /// <para>
        /// If enabled, the load balancer allows the connections to remain idle (no data is sent
        /// over the connection) for the specified duration.
        /// </para>
        ///  
        /// <para>
        /// By default, Elastic Load Balancing maintains a 60-second idle connection timeout for
        /// both front-end and back-end connections of your load balancer. For more information,
        /// see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-idle-timeout.html">Configure
        /// Idle Connection Timeout</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionSettings property is set.
        /// </summary>
        internal bool IsSetConnectionSettings() => this.ConnectionSettings != null;

        /// <summary>
        /// Gets and sets the property CrossZoneLoadBalancing. 
        /// <para>
        /// If enabled, the load balancer routes the request traffic evenly across all instances
        /// regardless of the Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-crosszone-lb.html">Configure
        /// Cross-Zone Load Balancing</a> in the <i>Classic Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        public CrossZoneLoadBalancing CrossZoneLoadBalancing { get; set; }

        /// <summary>
        /// Checks to see if the CrossZoneLoadBalancing property is set.
        /// </summary>
        internal bool IsSetCrossZoneLoadBalancing() => this.CrossZoneLoadBalancing != null;
    }
}
