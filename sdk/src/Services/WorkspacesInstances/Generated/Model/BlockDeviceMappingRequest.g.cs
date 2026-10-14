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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines device mapping for WorkSpace Instance storage.
    /// </summary>
    public partial class BlockDeviceMappingRequest
    {
        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// Name of the device for storage mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        /// EBS volume configuration for the device.
        /// </para>
        /// </summary>
        public EbsBlockDevice Ebs { get; set; }

        /// <summary>
        /// Checks to see if the Ebs property is set.
        /// </summary>
        internal bool IsSetEbs() => this.Ebs != null;

        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        /// Indicates device should not be mapped.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string NoDevice { get; set; }

        /// <summary>
        /// Checks to see if the NoDevice property is set.
        /// </summary>
        internal bool IsSetNoDevice() => this.NoDevice != null;

        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// Virtual device name for ephemeral storage.
        /// </para>
        /// </summary>
        public string VirtualName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualName property is set.
        /// </summary>
        internal bool IsSetVirtualName() => this.VirtualName != null;
    }
}
