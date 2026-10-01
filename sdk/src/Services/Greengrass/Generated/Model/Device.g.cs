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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about a device.
    /// </summary>
    public partial class Device
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. The ARN of the certificate associated with
        /// the device.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property Id. A descriptive or arbitrary ID for the device. This
        /// value must be unique within the device definition version. Max length is 128 characters
        /// with pattern ''[a-zA-Z0-9:_-]+''.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property SyncShadow. If true, the device's local shadow will be
        /// automatically synced with the cloud.
        /// </summary>
        public bool? SyncShadow { get; set; }

        /// <summary>
        /// Checks to see if the SyncShadow property is set.
        /// </summary>
        internal bool IsSetSyncShadow() => this.SyncShadow.HasValue;

        /// <summary>
        /// Gets and sets the property ThingArn. The thing ARN of the device.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ThingArn { get; set; }

        /// <summary>
        /// Checks to see if the ThingArn property is set.
        /// </summary>
        internal bool IsSetThingArn() => this.ThingArn != null;
    }
}
