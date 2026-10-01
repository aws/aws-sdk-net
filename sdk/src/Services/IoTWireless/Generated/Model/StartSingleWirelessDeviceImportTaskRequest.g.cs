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
    /// Container for the parameters to the StartSingleWirelessDeviceImportTask operation.
    /// Start import task for a single wireless device.
    /// </summary>
    public partial class StartSingleWirelessDeviceImportTaskRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the Sidewalk destination that describes the IoT rule to route messages
        /// from the device in the import task that will be onboarded to AWS IoT Wireless.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationName property is set.
        /// </summary>
        internal bool IsSetDestinationName() => this.DestinationName != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the wireless device for which an import task is being started.
        /// </para>
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// The integration status of the Device Location feature for Sidewalk devices.
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
        /// The Sidewalk-related parameters for importing a single wireless device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SidewalkSingleStartImportInfo Sidewalk { get; set; }

        /// <summary>
        /// Checks to see if the Sidewalk property is set.
        /// </summary>
        internal bool IsSetSidewalk() => this.Sidewalk != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
