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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains attributes for the load balancer.
    /// </summary>
    public partial class AwsElbLoadBalancerAttributes
    {
        private AwsElbLoadBalancerAccessLog _accessLog;
        private List<AwsElbLoadBalancerAdditionalAttribute> _additionalAttributes = AWSConfigs.InitializeCollections ? new List<AwsElbLoadBalancerAdditionalAttribute>() : null;
        private AwsElbLoadBalancerConnectionDraining _connectionDraining;
        private AwsElbLoadBalancerConnectionSettings _connectionSettings;
        private AwsElbLoadBalancerCrossZoneLoadBalancing _crossZoneLoadBalancing;

        /// <summary>
        /// Gets and sets the property AccessLog. 
        /// <para>
        /// Information about the access log configuration for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// If the access log is enabled, the load balancer captures detailed information about
        /// all requests. It delivers the information to a specified S3 bucket.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerAccessLog AccessLog
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
        /// Any additional attributes for a load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLoadBalancerAdditionalAttribute> AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null && (this._additionalAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionDraining. 
        /// <para>
        /// Information about the connection draining configuration for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// If connection draining is enabled, the load balancer allows existing requests to complete
        /// before it shifts traffic away from a deregistered or unhealthy instance.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerConnectionDraining ConnectionDraining
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
        /// Connection settings for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// If an idle timeout is configured, the load balancer allows connections to remain idle
        /// for the specified duration. When a connection is idle, no data is sent over the connection.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerConnectionSettings ConnectionSettings
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
        /// Cross-zone load balancing settings for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// If cross-zone load balancing is enabled, the load balancer routes the request traffic
        /// evenly across all instances regardless of the Availability Zones.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerCrossZoneLoadBalancing CrossZoneLoadBalancing
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