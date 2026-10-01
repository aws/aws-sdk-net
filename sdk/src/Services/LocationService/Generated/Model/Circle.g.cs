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
    /// A circle on the earth, as defined by a center point and a radius.
    /// </summary>
    public partial class Circle
    {
        /// <summary>
        /// Gets and sets the property Center. 
        /// <para>
        /// A single point geometry, specifying the center of the circle, using <a href="https://gisgeography.com/wgs84-world-geodetic-system/">WGS
        /// 84</a> coordinates, in the form <c>[longitude, latitude]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Center { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Center property is set.
        /// </summary>
        internal bool IsSetCenter() => this.Center != null && (this.Center.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Radius. 
        /// <para>
        /// The radius of the circle in meters. Must be greater than zero and no larger than 100,000
        /// (100 kilometers).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public double? Radius { get; set; }

        /// <summary>
        /// Checks to see if the Radius property is set.
        /// </summary>
        internal bool IsSetRadius() => this.Radius.HasValue;
    }
}
