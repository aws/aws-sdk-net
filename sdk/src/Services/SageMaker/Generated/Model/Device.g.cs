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
    /// Information of a particular device.
    /// </summary>
    public partial class Device
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property IotThingName. 
        /// <para>
        /// Amazon Web Services Internet of Things (IoT) object name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string IotThingName { get; set; }

        /// <summary>
        /// Checks to see if the IotThingName property is set.
        /// </summary>
        internal bool IsSetIotThingName() => this.IotThingName != null;
    }
}
