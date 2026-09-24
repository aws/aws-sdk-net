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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// A time segment containing azimuth elevation pointing data.
    /// 
    ///  
    /// <para>
    ///  Each segment defines a continuous time period with pointing angle data points. AWS
    /// Ground Station uses 4th order Lagrange interpolation between the provided points,
    /// so each segment must contain at least five data points. 
    /// </para>
    /// </summary>
    public partial class AzElSegment
    {
        /// <summary>
        /// Gets and sets the property AzElList. 
        /// <para>
        /// List of time-tagged azimuth elevation data points.
        /// </para>
        ///  
        /// <para>
        ///  Must contain at least five points to support 4th order Lagrange interpolation. Points
        /// must be in chronological order with no duplicates. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 5)]
        public List<TimeAzEl> AzElList { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeAzEl>() : null;

        /// <summary>
        /// Checks to see if the AzElList property is set.
        /// </summary>
        internal bool IsSetAzElList() => this.AzElList != null && (this.AzElList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceEpoch. 
        /// <para>
        /// The reference time for this segment in ISO 8601 format in Coordinated Universal Time
        /// (UTC).
        /// </para>
        ///  
        /// <para>
        /// All time values within the segment's <a>AzElSegment$azElList</a> are specified as
        /// offsets in atomic seconds from this reference epoch.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>2024-01-15T12:00:00.000Z</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ReferenceEpoch { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceEpoch property is set.
        /// </summary>
        internal bool IsSetReferenceEpoch() => this.ReferenceEpoch.HasValue;

        /// <summary>
        /// Gets and sets the property ValidTimeRange. 
        /// <para>
        /// The valid time range for this segment.
        /// </para>
        ///  
        /// <para>
        ///  Specifies the start and end timestamps in ISO 8601 format in Coordinated Universal
        /// Time (UTC). The segment's pointing data must cover this entire time range. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ISO8601TimeRange ValidTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the ValidTimeRange property is set.
        /// </summary>
        internal bool IsSetValidTimeRange() => this.ValidTimeRange != null;
    }
}
