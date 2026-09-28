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
    /// Container for the parameters to the UpdateWirelessDevice operation. Updates properties
    /// of a wireless device.
    /// </summary>
    public partial class UpdateWirelessDeviceRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the new destination for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationName property is set.
        /// </summary>
        internal bool IsSetDestinationName() => this.DestinationName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// The updated wireless device's configuration.
        /// </para>
        /// </summary>
        public LoRaWANUpdateDevice LoRaWAN { get; set; }

        /// <summary>
        /// Checks to see if the LoRaWAN property is set.
        /// </summary>
        internal bool IsSetLoRaWAN() => this.LoRaWAN != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name of the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following special characters aren't accepted: <c>&lt;>^#~$</c> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// The integration status of the Device Location feature for LoRaWAN and Sidewalk devices.
        /// </para>
        /// </summary>
        public PositioningConfigStatus Positioning { get; set; }

        /// <summary>
        /// Checks to see if the Positioning property is set.
        /// </summary>
        internal bool IsSetPositioning() => this.Positioning != null;

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The updated sidewalk properties.
        /// </para>
        /// </summary>
        public SidewalkUpdateWirelessDevice Sidewalk { get; set; }

        /// <summary>
        /// Checks to see if the Sidewalk property is set.
        /// </summary>
        internal bool IsSetSidewalk() => this.Sidewalk != null;
    }
}
