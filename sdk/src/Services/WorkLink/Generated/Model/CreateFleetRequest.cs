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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleet operation.
    /// Creates a fleet. A fleet consists of resources and the configuration that delivers
    /// associated websites to authorized users who download and set up the Amazon WorkLink
    /// app.
    /// </summary>
    public partial class CreateFleetRequest : AmazonWorkLinkRequest
    {
        private string _displayName;
        private string _fleetName;
        private bool? _optimizeForEndUserLocation;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The fleet name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// A unique name for the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizeForEndUserLocation. 
        /// <para>
        /// The option to optimize for better performance by routing traffic through the closest
        /// AWS Region to users, which may be outside of your home Region.
        /// </para>
        /// </summary>
        public bool OptimizeForEndUserLocation
        {
            get { return this._optimizeForEndUserLocation.GetValueOrDefault(); }
            set { this._optimizeForEndUserLocation = value; }
        }

        // Check to see if OptimizeForEndUserLocation property is set
        internal bool IsSetOptimizeForEndUserLocation()
        {
            return this._optimizeForEndUserLocation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags to add to the resource. A tag is a key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}