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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private bool? _compatible;
        private Device _device;
        private List<IncompatibilityMessage> _incompatibilityMessages = AWSConfigs.InitializeCollections ? new List<IncompatibilityMessage>() : null;

        /// <summary>
        /// Gets and sets the property Compatible. 
        /// <para>
        /// Whether the result was compatible with the device pool.
        /// </para>
        /// </summary>
        public bool? Compatible
        {
            get { return this._compatible; }
            set { this._compatible = value; }
        }

        // Check to see if Compatible property is set
        internal bool IsSetCompatible()
        {
            return this._compatible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device (phone or tablet) to return information about.
        /// </para>
        /// </summary>
        public Device Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property IncompatibilityMessages. 
        /// <para>
        /// Information about the compatibility.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IncompatibilityMessage> IncompatibilityMessages
        {
            get { return this._incompatibilityMessages; }
            set { this._incompatibilityMessages = value; }
        }

        // Check to see if IncompatibilityMessages property is set
        internal bool IsSetIncompatibilityMessages()
        {
            return this._incompatibilityMessages != null && (this._incompatibilityMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}