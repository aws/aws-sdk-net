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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The thing search index document.
    /// </summary>
    public partial class ThingDocument
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        /// Indicates whether the thing is connected to the Amazon Web Services IoT Core service.
        /// </para>
        /// </summary>
        public ThingConnectivity Connectivity { get; set; }

        /// <summary>
        /// Checks to see if the Connectivity property is set.
        /// </summary>
        internal bool IsSetConnectivity() => this.Connectivity != null;

        /// <summary>
        /// Gets and sets the property DeviceDefender. 
        /// <para>
        /// Contains Device Defender data.
        /// </para>
        ///  
        /// <para>
        /// For more information about Device Defender, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/device-defender.html">Device
        /// Defender</a>. 
        /// </para>
        /// </summary>
        public string DeviceDefender { get; set; }

        /// <summary>
        /// Checks to see if the DeviceDefender property is set.
        /// </summary>
        internal bool IsSetDeviceDefender() => this.DeviceDefender != null;

        /// <summary>
        /// Gets and sets the property Shadow. 
        /// <para>
        /// The unnamed shadow and named shadow.
        /// </para>
        ///  
        /// <para>
        /// For more information about shadows, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-device-shadows.html">IoT
        /// Device Shadow service.</a> 
        /// </para>
        /// </summary>
        public string Shadow { get; set; }

        /// <summary>
        /// Checks to see if the Shadow property is set.
        /// </summary>
        internal bool IsSetShadow() => this.Shadow != null;

        /// <summary>
        /// Gets and sets the property ThingGroupNames. 
        /// <para>
        /// Thing group and billing group names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ThingGroupNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ThingGroupNames property is set.
        /// </summary>
        internal bool IsSetThingGroupNames() => this.ThingGroupNames != null && (this.ThingGroupNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThingId. 
        /// <para>
        /// The thing ID.
        /// </para>
        /// </summary>
        public string ThingId { get; set; }

        /// <summary>
        /// Checks to see if the ThingId property is set.
        /// </summary>
        internal bool IsSetThingId() => this.ThingId != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The thing name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The thing type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeName property is set.
        /// </summary>
        internal bool IsSetThingTypeName() => this.ThingTypeName != null;
    }
}
