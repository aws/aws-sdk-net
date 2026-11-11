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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a device pool compatibility result.
    /// </summary>
    public partial class DevicePoolCompatibilityResult
    {
        /// <summary>
        /// Gets and sets the property Compatible. 
        /// <para>
        /// Whether the result was compatible with the device pool.
        /// </para>
        /// </summary>
        public bool? Compatible { get; set; }

        /// <summary>
        /// Checks to see if the Compatible property is set.
        /// </summary>
        internal bool IsSetCompatible() => this.Compatible.HasValue;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device (phone or tablet) to return information about.
        /// </para>
        /// </summary>
        public Device Device { get; set; }

        /// <summary>
        /// Checks to see if the Device property is set.
        /// </summary>
        internal bool IsSetDevice() => this.Device != null;

        /// <summary>
        /// Gets and sets the property IncompatibilityMessages. 
        /// <para>
        /// Information about the compatibility.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IncompatibilityMessage> IncompatibilityMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<IncompatibilityMessage>() : null;

        /// <summary>
        /// Checks to see if the IncompatibilityMessages property is set.
        /// </summary>
        internal bool IsSetIncompatibilityMessages() => this.IncompatibilityMessages != null && (this.IncompatibilityMessages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
