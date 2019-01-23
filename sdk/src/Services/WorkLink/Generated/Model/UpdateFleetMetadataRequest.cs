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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFleetMetadata operation.
    /// Updates fleet metadata, such as DisplayName.
    /// </summary>
    public partial class UpdateFleetMetadataRequest : AmazonWorkLinkRequest
    {
        private string _displayName;
        private string _fleetArn;
        private bool? _optimizeForEndUserLocation;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The fleet name to display. The existing DisplayName is unset if null is passed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The ARN of the fleet.
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
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

    }
}