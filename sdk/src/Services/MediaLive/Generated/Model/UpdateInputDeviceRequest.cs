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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
    /// Container for the parameters to the UpdateInputDevice operation.
    /// Updates the parameters for the input device.
    /// </summary>
    public partial class UpdateInputDeviceRequest : AmazonMediaLiveRequest
    {
        private string _availabilityZone;
        private InputDeviceConfigurableSettings _hdDeviceSettings;
        private string _inputDeviceId;
        private string _name;
        private InputDeviceConfigurableSettings _uhdDeviceSettings;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. The Availability Zone you want associated
        /// with this input device.
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property HdDeviceSettings. The settings that you want to apply to
        /// the HD input device.
        /// </summary>
        public InputDeviceConfigurableSettings HdDeviceSettings
        {
            get { return this._hdDeviceSettings; }
            set { this._hdDeviceSettings = value; }
        }

        // Check to see if HdDeviceSettings property is set
        internal bool IsSetHdDeviceSettings()
        {
            return this._hdDeviceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property InputDeviceId. The unique ID of the input device. For example,
        /// hd-123456789abcdef.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputDeviceId
        {
            get { return this._inputDeviceId; }
            set { this._inputDeviceId = value; }
        }

        // Check to see if InputDeviceId property is set
        internal bool IsSetInputDeviceId()
        {
            return this._inputDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name that you assigned to this input device (not
        /// the unique ID).
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UhdDeviceSettings. The settings that you want to apply
        /// to the UHD input device.
        /// </summary>
        public InputDeviceConfigurableSettings UhdDeviceSettings
        {
            get { return this._uhdDeviceSettings; }
            set { this._uhdDeviceSettings = value; }
        }

        // Check to see if UhdDeviceSettings property is set
        internal bool IsSetUhdDeviceSettings()
        {
            return this._uhdDeviceSettings != null;
        }

    }
}