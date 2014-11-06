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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The <code>LoadBalancerAttributes</code> data type.
    /// </summary>
    public partial class LoadBalancerAttributes
    {
        private AccessLog _accessLog;
        private List<AdditionalAttribute> _additionalAttributes = new List<AdditionalAttribute>();
        private ConnectionDraining _connectionDraining;
        private ConnectionSettings _connectionSettings;
        private CrossZoneLoadBalancing _crossZoneLoadBalancing;

        /// <summary>
        /// Gets and sets the property AccessLog. 
        /// <para>
        /// The name of the load balancer attribute. If enabled, the load balancer captures detailed
        /// information of all the requests and delivers the information to the Amazon S3 bucket
        /// that you specify.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/enable-access-logs.html">Enable
        /// Access Logs</a>.
        /// </para>
        /// </summary>
        public AccessLog AccessLog
        {
            get { return this._accessLog; }
            set { this._accessLog = value; }
        }

        // Check to see if AccessLog property is set
        internal bool IsSetAccessLog()
        {
            return this._accessLog != null;
        }

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// This parameter is reserved for future use.
        /// </para>
        /// </summary>
        public List<AdditionalAttribute> AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null && this._additionalAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionDraining. 
        /// <para>
        /// The name of the load balancer attribute. If enabled, the load balancer allows existing
        /// requests to complete before the load balancer shifts traffic away from a deregistered
        /// or unhealthy back-end instance. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/config-conn-drain.html">Enable
        /// Connection Draining</a>.
        /// </para>
        /// </summary>
        public ConnectionDraining ConnectionDraining
        {
            get { return this._connectionDraining; }
            set { this._connectionDraining = value; }
        }

        // Check to see if ConnectionDraining property is set
        internal bool IsSetConnectionDraining()
        {
            return this._connectionDraining != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionSettings. 
        /// <para>
        /// The name of the load balancer attribute. 
        /// </para>
        ///  
        /// <para>
        /// By default, Elastic Load Balancing maintains a 60-second idle connection timeout for
        /// both front-end and back-end connections of your load balancer. If the <code>ConnectionSettings</code>
        /// attribute is set, Elastic Load Balancing will allow the connections to remain idle
        /// (no data is sent over the connection) for the specified duration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/config-idle-timeout.html">Configure
        /// Idle Connection Timeout</a>.
        /// </para>
        /// </summary>
        public ConnectionSettings ConnectionSettings
        {
            get { return this._connectionSettings; }
            set { this._connectionSettings = value; }
        }

        // Check to see if ConnectionSettings property is set
        internal bool IsSetConnectionSettings()
        {
            return this._connectionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CrossZoneLoadBalancing. 
        /// <para>
        /// The name of the load balancer attribute. If enabled, the load balancer routes the
        /// request traffic evenly across all back-end instances regardless of the Availability
        /// Zones.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/enable-disable-crosszone-lb.html">Enable
        /// Cross-Zone Load Balancing</a>.
        /// </para>
        /// </summary>
        public CrossZoneLoadBalancing CrossZoneLoadBalancing
        {
            get { return this._crossZoneLoadBalancing; }
            set { this._crossZoneLoadBalancing = value; }
        }

        // Check to see if CrossZoneLoadBalancing property is set
        internal bool IsSetCrossZoneLoadBalancing()
        {
            return this._crossZoneLoadBalancing != null;
        }

    }
}