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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScope operation.
    /// In Network Flow Monitor, you specify a scope for the service to generate metrics for.
    /// By using the scope, Network Flow Monitor can generate a topology of all the resources
    /// to measure performance metrics for. When you create a scope, you enable permissions
    /// for Network Flow Monitor.
    /// 
    ///  
    /// <para>
    /// A scope is a Region-account pair or multiple Region-account pairs. Network Flow Monitor
    /// uses your scope to determine all the resources (the topology) where Network Flow Monitor
    /// will gather network flow performance metrics for you. To provide performance metrics,
    /// Network Flow Monitor uses the data that is sent by the Network Flow Monitor agents
    /// you install on the resources.
    /// </para>
    ///  
    /// <para>
    /// To define the Region-account pairs for your scope, the Network Flow Monitor API uses
    /// the following constucts, which allow for future flexibility in defining scopes:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Targets</i>, which are arrays of targetResources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Target resources</i>, which are Region-targetIdentifier pairs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Target identifiers</i>, made up of a targetID (currently always an account ID)
    /// and a targetType (currently always an account). 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateScopeRequest : AmazonNetworkFlowMonitorRequest
    {
        private string _clientToken;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<TargetResource> _targets = AWSConfigs.InitializeCollections ? new List<TargetResource>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters that you specify to make
        /// an idempotent API request. Don't reuse the same client token for other API requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a scope. You can add a maximum of 200 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets to define the scope to be monitored. A target is an array of targetResources,
        /// which are currently Region-account pairs, defined by targetResource constructs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<TargetResource> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}