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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Represents an element of a leg within a route. A step contains instructions for how
    /// to move to the next step in the leg.
    /// </summary>
    public partial class Step
    {
        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The travel distance between the step's <c>StartPosition</c> and <c>EndPosition</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0)]
        public double? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The estimated travel time, in seconds, from the step's <c>StartPosition</c> to the
        /// <c>EndPosition</c>. . The travel mode and departure time that you specify in the request
        /// determines the calculated time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0)]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EndPosition. 
        /// <para>
        /// The end position of a step. If the position the last step in the leg, this position
        /// is the same as the end position of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> EndPosition { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the EndPosition property is set.
        /// </summary>
        internal bool IsSetEndPosition() => this.EndPosition != null && (this.EndPosition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Represents the start position, or index, in a sequence of steps within the leg's line
        /// string geometry. For example, the index of the first step in a leg geometry is <c>0</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Included in the response for queries that set <c>IncludeLegGeometry</c> to <c>True</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GeometryOffset { get; set; }

        /// <summary>
        /// Checks to see if the GeometryOffset property is set.
        /// </summary>
        internal bool IsSetGeometryOffset() => this.GeometryOffset.HasValue;

        /// <summary>
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// The starting position of a step. If the position is the first step in the leg, this
        /// position is the same as the start position of the leg.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> StartPosition { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the StartPosition property is set.
        /// </summary>
        internal bool IsSetStartPosition() => this.StartPosition != null && (this.StartPosition.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
