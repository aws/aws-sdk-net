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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Groupings of columns that work together in certain Amazon QuickSight features. This
    /// is a variant type structure. For this structure to be valid, only one of the attributes
    /// can be non-null.
    /// </summary>
    public partial class ColumnGroup
    {
        private GeoSpatialColumnGroup _geoSpatialColumnGroup;

        /// <summary>
        /// Gets and sets the property GeoSpatialColumnGroup. 
        /// <para>
        /// Geospatial column group that denotes a hierarchy.
        /// </para>
        /// </summary>
        public GeoSpatialColumnGroup GeoSpatialColumnGroup
        {
            get { return this._geoSpatialColumnGroup; }
            set { this._geoSpatialColumnGroup = value; }
        }

        // Check to see if GeoSpatialColumnGroup property is set
        internal bool IsSetGeoSpatialColumnGroup()
        {
            return this._geoSpatialColumnGroup != null;
        }

    }
}