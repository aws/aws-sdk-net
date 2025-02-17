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
    /// Travel mode options when the provided travel mode is "Truck"
    /// </summary>
    public partial class WaypointOptimizationTruckOptions
    {
        private long? _grossWeight;
        private List<string> _hazardousCargos = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _height;
        private long? _length;
        private WaypointOptimizationTrailerOptions _trailer;
        private WaypointOptimizationTruckType _truckType;
        private string _tunnelRestrictionCode;
        private long? _weightPerAxle;
        private long? _width;

        /// <summary>
        /// Gets and sets the property GrossWeight. 
        /// <para>
        /// Gross weight of the vehicle including trailers, and goods at capacity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long GrossWeight
        {
            get { return this._grossWeight.GetValueOrDefault(); }
            set { this._grossWeight = value; }
        }

        // Check to see if GrossWeight property is set
        internal bool IsSetGrossWeight()
        {
            return this._grossWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HazardousCargos. 
        /// <para>
        /// List of Hazardous cargo contained in the vehicle.
        /// </para>
        /// </summary>
        public List<string> HazardousCargos
        {
            get { return this._hazardousCargos; }
            set { this._hazardousCargos = value; }
        }

        // Check to see if HazardousCargos property is set
        internal bool IsSetHazardousCargos()
        {
            return this._hazardousCargos != null && (this._hazardousCargos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// Height of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5000)]
        public long Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// Length of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30000)]
        public long Length
        {
            get { return this._length.GetValueOrDefault(); }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Trailer. 
        /// <para>
        /// Trailer options corresponding to the vehicle.
        /// </para>
        /// </summary>
        public WaypointOptimizationTrailerOptions Trailer
        {
            get { return this._trailer; }
            set { this._trailer = value; }
        }

        // Check to see if Trailer property is set
        internal bool IsSetTrailer()
        {
            return this._trailer != null;
        }

        /// <summary>
        /// Gets and sets the property TruckType. 
        /// <para>
        /// Type of the truck.
        /// </para>
        /// </summary>
        public WaypointOptimizationTruckType TruckType
        {
            get { return this._truckType; }
            set { this._truckType = value; }
        }

        // Check to see if TruckType property is set
        internal bool IsSetTruckType()
        {
            return this._truckType != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelRestrictionCode. 
        /// <para>
        /// The tunnel restriction code.
        /// </para>
        ///  
        /// <para>
        /// Tunnel categories in this list indicate the restrictions which apply to certain tunnels
        /// in Great Britain. They relate to the types of dangerous goods that can be transported
        /// through them.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Tunnel Category B</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: Limited risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Few restrictions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>Tunnel Category C</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: Medium risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Some restrictions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>Tunnel Category D</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: High risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Many restrictions occur
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>Tunnel Category E</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: Very high risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Restricted tunnel
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string TunnelRestrictionCode
        {
            get { return this._tunnelRestrictionCode; }
            set { this._tunnelRestrictionCode = value; }
        }

        // Check to see if TunnelRestrictionCode property is set
        internal bool IsSetTunnelRestrictionCode()
        {
            return this._tunnelRestrictionCode != null;
        }

        /// <summary>
        /// Gets and sets the property WeightPerAxle. 
        /// <para>
        /// Heaviest weight per axle irrespective of the axle type or the axle group. Meant for
        /// usage in countries where the differences in axle types or axle groups are not distinguished.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long WeightPerAxle
        {
            get { return this._weightPerAxle.GetValueOrDefault(); }
            set { this._weightPerAxle = value; }
        }

        // Check to see if WeightPerAxle property is set
        internal bool IsSetWeightPerAxle()
        {
            return this._weightPerAxle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// Width of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5000)]
        public long Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}