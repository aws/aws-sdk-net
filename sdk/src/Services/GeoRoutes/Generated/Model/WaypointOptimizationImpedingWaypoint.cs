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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// The impeding waypoint.
    /// </summary>
    public partial class WaypointOptimizationImpedingWaypoint
    {
        private List<WaypointOptimizationFailedConstraint> _failedConstraints = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationFailedConstraint>() : null;
        private string _id;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property FailedConstraints. 
        /// <para>
        /// Failed constraints for an impeding waypoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WaypointOptimizationFailedConstraint> FailedConstraints
        {
            get { return this._failedConstraints; }
            set { this._failedConstraints = value; }
        }

        // Check to see if FailedConstraints property is set
        internal bool IsSetFailedConstraints()
        {
            return this._failedConstraints != null && (this._failedConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The waypoint Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Position defined as <c>[longitude, latitude]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && (this._position.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}