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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourcePosition operation. Update the position
    /// information of a given wireless device or a wireless gateway resource. The position
    /// coordinates are based on the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
    /// World Geodetic System (WGS84)</a>.
    /// </summary>
    public partial class UpdateResourcePositionRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property GeoJsonPayload. 
        /// <para>
        /// The position information of the resource, displayed as a JSON payload. The payload
        /// uses the GeoJSON format, which a format that's used to encode geographic data structures.
        /// For more information, see <a href="https://geojson.org/">GeoJSON</a>.
        /// </para>
        /// </summary>
        public MemoryStream GeoJsonPayload { get; set; }

        /// <summary>
        /// Checks to see if the GeoJsonPayload property is set.
        /// </summary>
        internal bool IsSetGeoJsonPayload() => this.GeoJsonPayload != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier of the resource for which position information is updated. It can be
        /// the wireless device ID or the wireless gateway ID, depending on the resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for which position information is updated, which can be a wireless
        /// device or a wireless gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PositionResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
