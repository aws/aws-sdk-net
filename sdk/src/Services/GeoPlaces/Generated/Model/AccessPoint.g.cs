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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Position of the access point represented by longitude and latitude for a vehicle.
    /// </summary>
    public partial class AccessPoint
    {
        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A short textual description of the access point, such as <c>"North Entrance"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position in World Geodetic System (WGS 84) format: [longitude, latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// Set to <c>true</c> for the primary access position when the place has more than one
        /// access point.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Primary { get; set; }

        /// <summary>
        /// Checks to see if the Primary property is set.
        /// </summary>
        internal bool IsSetPrimary() => this.Primary.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of access point, indicating its intended use. Only applies to results of
        /// type place.
        /// </para>
        /// </summary>
        public AccessPointType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
