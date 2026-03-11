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
    /// Calculated isolines and associated properties.
    /// </summary>
    public partial class Isoline
    {
        private List<IsolineConnection> _connections = AWSConfigs.InitializeCollections ? new List<IsolineConnection>() : null;
        private long? _distanceThreshold;
        private List<IsolineShapeGeometry> _geometries = AWSConfigs.InitializeCollections ? new List<IsolineShapeGeometry>() : null;
        private long? _timeThreshold;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// Isolines may contain multiple components, if these components are connected by ferry
        /// links. These components are returned as separate polygons while the ferry links are
        /// returned as connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IsolineConnection> Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null && (this._connections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DistanceThreshold. 
        /// <para>
        /// Distance threshold corresponding to the calculated Isoline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? DistanceThreshold
        {
            get { return this._distanceThreshold; }
            set { this._distanceThreshold = value; }
        }

        // Check to see if DistanceThreshold property is set
        internal bool IsSetDistanceThreshold()
        {
            return this._distanceThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Geometries. 
        /// <para>
        /// Geometries for the Calculated isolines.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IsolineShapeGeometry> Geometries
        {
            get { return this._geometries; }
            set { this._geometries = value; }
        }

        // Check to see if Geometries property is set
        internal bool IsSetGeometries()
        {
            return this._geometries != null && (this._geometries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeThreshold. 
        /// <para>
        /// Time threshold corresponding to the calculated isoline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? TimeThreshold
        {
            get { return this._timeThreshold; }
            set { this._timeThreshold = value; }
        }

        // Check to see if TimeThreshold property is set
        internal bool IsSetTimeThreshold()
        {
            return this._timeThreshold.HasValue; 
        }

    }
}