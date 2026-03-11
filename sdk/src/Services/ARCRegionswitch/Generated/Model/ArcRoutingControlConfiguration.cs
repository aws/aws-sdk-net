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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for ARC routing controls used in a Region switch plan. Routing controls
    /// are simple on/off switches that you can use to shift traffic away from an impaired
    /// Region.
    /// </summary>
    public partial class ArcRoutingControlConfiguration
    {
        private string _crossAccountRole;
        private string _externalId;
        private Dictionary<string, List<ArcRoutingControlState>> _regionAndRoutingControls = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ArcRoutingControlState>>() : null;
        private int? _timeoutMinutes;

        /// <summary>
        /// Gets and sets the property CrossAccountRole. 
        /// <para>
        /// The cross account role for the configuration.
        /// </para>
        /// </summary>
        public string CrossAccountRole
        {
            get { return this._crossAccountRole; }
            set { this._crossAccountRole = value; }
        }

        // Check to see if CrossAccountRole property is set
        internal bool IsSetCrossAccountRole()
        {
            return this._crossAccountRole != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID (secret key) for the configuration.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property RegionAndRoutingControls. 
        /// <para>
        /// The Region and ARC routing controls for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, List<ArcRoutingControlState>> RegionAndRoutingControls
        {
            get { return this._regionAndRoutingControls; }
            set { this._regionAndRoutingControls = value; }
        }

        // Check to see if RegionAndRoutingControls property is set
        internal bool IsSetRegionAndRoutingControls()
        {
            return this._regionAndRoutingControls != null && (this._regionAndRoutingControls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TimeoutMinutes
        {
            get { return this._timeoutMinutes; }
            set { this._timeoutMinutes = value; }
        }

        // Check to see if TimeoutMinutes property is set
        internal bool IsSetTimeoutMinutes()
        {
            return this._timeoutMinutes.HasValue; 
        }

    }
}