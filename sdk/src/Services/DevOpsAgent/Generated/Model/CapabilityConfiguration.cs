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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Capability configuration for the AWS DevOps Agent.
    /// </summary>
    public partial class CapabilityConfiguration
    {
        private bool? _enabled;
        private List<TriggerFilterGroup> _triggerFilterGroups = AWSConfigs.InitializeCollections ? new List<TriggerFilterGroup>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the capability is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerFilterGroups. 
        /// <para>
        /// Optional trigger filter groups. Evaluated only when enabled=true; retained while the
        /// capability is disabled, so re-enabling restores the prior trigger behavior.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<TriggerFilterGroup> TriggerFilterGroups
        {
            get { return this._triggerFilterGroups; }
            set { this._triggerFilterGroups = value; }
        }

        // Check to see if TriggerFilterGroups property is set
        internal bool IsSetTriggerFilterGroups()
        {
            return this._triggerFilterGroups != null && (this._triggerFilterGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}