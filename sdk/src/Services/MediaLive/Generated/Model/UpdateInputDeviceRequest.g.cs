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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInputDevice operation. Updates the parameters
    /// for the input device.
    /// </summary>
    public partial class UpdateInputDeviceRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. The Availability Zone you want associated
        /// with this input device.
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property HdDeviceSettings. The settings that you want to apply to
        /// the HD input device.
        /// </summary>
        public InputDeviceConfigurableSettings HdDeviceSettings { get; set; }

        /// <summary>
        /// Checks to see if the HdDeviceSettings property is set.
        /// </summary>
        internal bool IsSetHdDeviceSettings() => this.HdDeviceSettings != null;

        /// <summary>
        /// Gets and sets the property InputDeviceId. The unique ID of the input device. For example,
        /// hd-123456789abcdef.
        /// </summary>
        [AWSProperty(Required = true)]
        public string InputDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the InputDeviceId property is set.
        /// </summary>
        internal bool IsSetInputDeviceId() => this.InputDeviceId != null;

        /// <summary>
        /// Gets and sets the property Name. The name that you assigned to this input device (not
        /// the unique ID).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UhdDeviceSettings. The settings that you want to apply
        /// to the UHD input device.
        /// </summary>
        public InputDeviceConfigurableSettings UhdDeviceSettings { get; set; }

        /// <summary>
        /// Checks to see if the UhdDeviceSettings property is set.
        /// </summary>
        internal bool IsSetUhdDeviceSettings() => this.UhdDeviceSettings != null;
    }
}
