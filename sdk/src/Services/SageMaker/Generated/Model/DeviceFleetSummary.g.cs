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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary of the device fleet.
    /// </summary>
    public partial class DeviceFleetSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp of when the device fleet was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceFleetArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the device fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceFleetArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetArn property is set.
        /// </summary>
        internal bool IsSetDeviceFleetArn() => this.DeviceFleetArn != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// Name of the device fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceFleetName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetName property is set.
        /// </summary>
        internal bool IsSetDeviceFleetName() => this.DeviceFleetName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Timestamp of when the device fleet was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
