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
    /// Container for the parameters to the CreateFuotaTask operation. Creates a FUOTA task.
    /// </summary>
    public partial class CreateFuotaTaskRequest : AmazonIoTWirelessRequest
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
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Descriptor.
        /// </summary>
        [AWSProperty(Min = 0, Max = 332)]
        public string Descriptor { get; set; }

        /// <summary>
        /// Checks to see if the Descriptor property is set.
        /// </summary>
        internal bool IsSetDescriptor() => this.Descriptor != null;

        /// <summary>
        /// Gets and sets the property FirmwareUpdateImage.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string FirmwareUpdateImage { get; set; }

        /// <summary>
        /// Checks to see if the FirmwareUpdateImage property is set.
        /// </summary>
        internal bool IsSetFirmwareUpdateImage() => this.FirmwareUpdateImage != null;

        /// <summary>
        /// Gets and sets the property FirmwareUpdateRole.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string FirmwareUpdateRole { get; set; }

        /// <summary>
        /// Checks to see if the FirmwareUpdateRole property is set.
        /// </summary>
        internal bool IsSetFirmwareUpdateRole() => this.FirmwareUpdateRole != null;

        /// <summary>
        /// Gets and sets the property FragmentIntervalMS.
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? FragmentIntervalMS { get; set; }

        /// <summary>
        /// Checks to see if the FragmentIntervalMS property is set.
        /// </summary>
        internal bool IsSetFragmentIntervalMS() => this.FragmentIntervalMS.HasValue;

        /// <summary>
        /// Gets and sets the property FragmentSizeBytes.
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? FragmentSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the FragmentSizeBytes property is set.
        /// </summary>
        internal bool IsSetFragmentSizeBytes() => this.FragmentSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property LoRaWAN.
        /// </summary>
        public LoRaWANFuotaTask LoRaWAN { get; set; }

        /// <summary>
        /// Checks to see if the LoRaWAN property is set.
        /// </summary>
        internal bool IsSetLoRaWAN() => this.LoRaWAN != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RedundancyPercent.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? RedundancyPercent { get; set; }

        /// <summary>
        /// Checks to see if the RedundancyPercent property is set.
        /// </summary>
        internal bool IsSetRedundancyPercent() => this.RedundancyPercent.HasValue;

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
