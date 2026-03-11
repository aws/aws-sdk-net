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
    /// Details related to the U-turn step.
    /// </summary>
    public partial class RouteUTurnStepDetails
    {
        private List<LocalizedString> _intersection = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;
        private RouteSteeringDirection _steeringDirection;
        private double? _turnAngle;
        private RouteTurnIntensity _turnIntensity;

        /// <summary>
        /// Gets and sets the property Intersection. 
        /// <para>
        /// Name of the intersection, if applicable to the step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LocalizedString> Intersection
        {
            get { return this._intersection; }
            set { this._intersection = value; }
        }

        // Check to see if Intersection property is set
        internal bool IsSetIntersection()
        {
            return this._intersection != null && (this._intersection.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SteeringDirection. 
        /// <para>
        /// Steering direction for the step.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteSteeringDirection SteeringDirection
        {
            get { return this._steeringDirection; }
            set { this._steeringDirection = value; }
        }

        // Check to see if SteeringDirection property is set
        internal bool IsSetSteeringDirection()
        {
            return this._steeringDirection != null;
        }

        /// <summary>
        /// Gets and sets the property TurnAngle. 
        /// <para>
        /// Angle of the turn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-180, Max=180)]
        public double? TurnAngle
        {
            get { return this._turnAngle; }
            set { this._turnAngle = value; }
        }

        // Check to see if TurnAngle property is set
        internal bool IsSetTurnAngle()
        {
            return this._turnAngle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TurnIntensity. 
        /// <para>
        /// Intensity of the turn.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteTurnIntensity TurnIntensity
        {
            get { return this._turnIntensity; }
            set { this._turnIntensity = value; }
        }

        // Check to see if TurnIntensity property is set
        internal bool IsSetTurnIntensity()
        {
            return this._turnIntensity != null;
        }

    }
}