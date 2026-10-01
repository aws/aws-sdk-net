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
    /// Sidewalk device object.
    /// </summary>
    public partial class SidewalkDevice
    {
        /// <summary>
        /// Gets and sets the property AmazonId.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AmazonId { get; set; }

        /// <summary>
        /// Checks to see if the AmazonId property is set.
        /// </summary>
        internal bool IsSetAmazonId() => this.AmazonId != null;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the Sidewalk device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property DeviceCertificates. 
        /// <para>
        /// The sidewalk device certificates for Ed25519 and P256r1.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CertificateList> DeviceCertificates { get; set; } = AWSConfigs.InitializeCollections ? new List<CertificateList>() : null;

        /// <summary>
        /// Checks to see if the DeviceCertificates property is set.
        /// </summary>
        internal bool IsSetDeviceCertificates() => this.DeviceCertificates != null && (this.DeviceCertificates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeviceProfileId. 
        /// <para>
        /// The ID of the Sidewalk device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DeviceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProfileId property is set.
        /// </summary>
        internal bool IsSetDeviceProfileId() => this.DeviceProfileId != null;

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// The Positioning object of the Sidewalk device.
        /// </para>
        /// </summary>
        public SidewalkPositioning Positioning { get; set; }

        /// <summary>
        /// Checks to see if the Positioning property is set.
        /// </summary>
        internal bool IsSetPositioning() => this.Positioning != null;

        /// <summary>
        /// Gets and sets the property PrivateKeys. 
        /// <para>
        /// The Sidewalk device private keys that will be used for onboarding the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CertificateList> PrivateKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<CertificateList>() : null;

        /// <summary>
        /// Checks to see if the PrivateKeys property is set.
        /// </summary>
        internal bool IsSetPrivateKeys() => this.PrivateKeys != null && (this.PrivateKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SidewalkId. 
        /// <para>
        /// The sidewalk device identification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SidewalkId { get; set; }

        /// <summary>
        /// Checks to see if the SidewalkId property is set.
        /// </summary>
        internal bool IsSetSidewalkId() => this.SidewalkId != null;

        /// <summary>
        /// Gets and sets the property SidewalkManufacturingSn. 
        /// <para>
        /// The Sidewalk manufacturing series number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SidewalkManufacturingSn { get; set; }

        /// <summary>
        /// Checks to see if the SidewalkManufacturingSn property is set.
        /// </summary>
        internal bool IsSetSidewalkManufacturingSn() => this.SidewalkManufacturingSn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The Sidewalk device status, such as provisioned or registered.
        /// </para>
        /// </summary>
        public WirelessDeviceSidewalkStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
