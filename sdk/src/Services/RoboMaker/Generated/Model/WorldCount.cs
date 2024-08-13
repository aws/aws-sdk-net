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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// The number of worlds that will be created. You can configure the number of unique
    /// floorplans and the number of unique interiors for each floor plan. For example, if
    /// you want 1 world with 20 unique interiors, you set <c>floorplanCount = 1</c> and <c>interiorCountPerFloorplan
    /// = 20</c>. This will result in 20 worlds (<c>floorplanCount</c> * <c>interiorCountPerFloorplan)</c>.
    /// 
    /// 
    ///  
    /// <para>
    /// If you set <c>floorplanCount = 4</c> and <c>interiorCountPerFloorplan = 5</c>, there
    /// will be 20 worlds with 5 unique floor plans. 
    /// </para>
    /// </summary>
    public partial class WorldCount
    {
        private int? _floorplanCount;
        private int? _interiorCountPerFloorplan;

        /// <summary>
        /// Gets and sets the property FloorplanCount. 
        /// <para>
        /// The number of unique floorplans.
        /// </para>
        /// </summary>
        public int? FloorplanCount
        {
            get { return this._floorplanCount; }
            set { this._floorplanCount = value; }
        }

        // Check to see if FloorplanCount property is set
        internal bool IsSetFloorplanCount()
        {
            return this._floorplanCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InteriorCountPerFloorplan. 
        /// <para>
        /// The number of unique interiors per floorplan.
        /// </para>
        /// </summary>
        public int? InteriorCountPerFloorplan
        {
            get { return this._interiorCountPerFloorplan; }
            set { this._interiorCountPerFloorplan = value; }
        }

        // Check to see if InteriorCountPerFloorplan property is set
        internal bool IsSetInteriorCountPerFloorplan()
        {
            return this._interiorCountPerFloorplan.HasValue; 
        }

    }
}