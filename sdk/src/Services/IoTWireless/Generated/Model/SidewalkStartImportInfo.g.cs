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
    /// Information about an import task created for bulk provisioning.
    /// </summary>
    public partial class SidewalkStartImportInfo
    {
        /// <summary>
        /// Gets and sets the property DeviceCreationFile. 
        /// <para>
        /// The CSV file contained in an S3 bucket that's used for adding devices to an import
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeviceCreationFile { get; set; }

        /// <summary>
        /// Checks to see if the DeviceCreationFile property is set.
        /// </summary>
        internal bool IsSetDeviceCreationFile() => this.DeviceCreationFile != null;

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
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that allows AWS IoT Wireless to access the CSV file in the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
