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
    /// TracePoints snapped onto the road network.
    /// </summary>
    public partial class RoadSnapSnappedTracePoint
    {
        private double? _confidence;
        private List<double> _originalPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<double> _snappedPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Confidence value for the correctness of this point match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1)]
        public double? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalPosition. 
        /// <para>
        /// Position of the TracePoint provided within the request, at the same index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> OriginalPosition
        {
            get { return this._originalPosition; }
            set { this._originalPosition = value; }
        }

        // Check to see if OriginalPosition property is set
        internal bool IsSetOriginalPosition()
        {
            return this._originalPosition != null && (this._originalPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnappedPosition. 
        /// <para>
        /// Snapped position of the TracePoint provided within the request, at the same index.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> SnappedPosition
        {
            get { return this._snappedPosition; }
            set { this._snappedPosition = value; }
        }

        // Check to see if SnappedPosition property is set
        internal bool IsSetSnappedPosition()
        {
            return this._snappedPosition != null && (this._snappedPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}