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
    /// Describes the Traffic Mirror filter.
    /// </summary>
    public partial class TrafficMirrorFilter
    {
        private string _description;
        private List<TrafficMirrorFilterRule> _egressFilterRules = AWSConfigs.InitializeCollections ? new List<TrafficMirrorFilterRule>() : null;
        private List<TrafficMirrorFilterRule> _ingressFilterRules = AWSConfigs.InitializeCollections ? new List<TrafficMirrorFilterRule>() : null;
        private List<string> _networkServices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trafficMirrorFilterId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EgressFilterRules. 
        /// <para>
        /// Information about the egress rules that are associated with the Traffic Mirror filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrafficMirrorFilterRule> EgressFilterRules
        {
            get { return this._egressFilterRules; }
            set { this._egressFilterRules = value; }
        }

        // Check to see if EgressFilterRules property is set
        internal bool IsSetEgressFilterRules()
        {
            return this._egressFilterRules != null && (this._egressFilterRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IngressFilterRules. 
        /// <para>
        /// Information about the ingress rules that are associated with the Traffic Mirror filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrafficMirrorFilterRule> IngressFilterRules
        {
            get { return this._ingressFilterRules; }
            set { this._ingressFilterRules = value; }
        }

        // Check to see if IngressFilterRules property is set
        internal bool IsSetIngressFilterRules()
        {
            return this._ingressFilterRules != null && (this._ingressFilterRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkServices. 
        /// <para>
        /// The network service traffic that is associated with the Traffic Mirror filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkServices
        {
            get { return this._networkServices; }
            set { this._networkServices = value; }
        }

        // Check to see if NetworkServices property is set
        internal bool IsSetNetworkServices()
        {
            return this._networkServices != null && (this._networkServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Traffic Mirror filter.
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

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        public string TrafficMirrorFilterId
        {
            get { return this._trafficMirrorFilterId; }
            set { this._trafficMirrorFilterId = value; }
        }

        // Check to see if TrafficMirrorFilterId property is set
        internal bool IsSetTrafficMirrorFilterId()
        {
            return this._trafficMirrorFilterId != null;
        }

    }
}