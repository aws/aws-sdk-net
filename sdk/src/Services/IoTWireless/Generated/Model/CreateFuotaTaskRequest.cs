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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFuotaTask operation.
    /// Creates a FUOTA task.
    /// </summary>
    public partial class CreateFuotaTaskRequest : AmazonIoTWirelessRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _firmwareUpdateImage;
        private string _firmwareUpdateRole;
        private int? _fragmentIntervalMS;
        private int? _fragmentSizeBytes;
        private LoRaWANFuotaTask _loRaWAN;
        private string _name;
        private int? _redundancyPercent;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FirmwareUpdateImage.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string FirmwareUpdateImage
        {
            get { return this._firmwareUpdateImage; }
            set { this._firmwareUpdateImage = value; }
        }

        // Check to see if FirmwareUpdateImage property is set
        internal bool IsSetFirmwareUpdateImage()
        {
            return this._firmwareUpdateImage != null;
        }

        /// <summary>
        /// Gets and sets the property FirmwareUpdateRole.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string FirmwareUpdateRole
        {
            get { return this._firmwareUpdateRole; }
            set { this._firmwareUpdateRole = value; }
        }

        // Check to see if FirmwareUpdateRole property is set
        internal bool IsSetFirmwareUpdateRole()
        {
            return this._firmwareUpdateRole != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentIntervalMS.
        /// </summary>
        [AWSProperty(Min=1)]
        public int FragmentIntervalMS
        {
            get { return this._fragmentIntervalMS.GetValueOrDefault(); }
            set { this._fragmentIntervalMS = value; }
        }

        // Check to see if FragmentIntervalMS property is set
        internal bool IsSetFragmentIntervalMS()
        {
            return this._fragmentIntervalMS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FragmentSizeBytes.
        /// </summary>
        [AWSProperty(Min=1)]
        public int FragmentSizeBytes
        {
            get { return this._fragmentSizeBytes.GetValueOrDefault(); }
            set { this._fragmentSizeBytes = value; }
        }

        // Check to see if FragmentSizeBytes property is set
        internal bool IsSetFragmentSizeBytes()
        {
            return this._fragmentSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoRaWAN.
        /// </summary>
        public LoRaWANFuotaTask LoRaWAN
        {
            get { return this._loRaWAN; }
            set { this._loRaWAN = value; }
        }

        // Check to see if LoRaWAN property is set
        internal bool IsSetLoRaWAN()
        {
            return this._loRaWAN != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property RedundancyPercent.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int RedundancyPercent
        {
            get { return this._redundancyPercent.GetValueOrDefault(); }
            set { this._redundancyPercent = value; }
        }

        // Check to see if RedundancyPercent property is set
        internal bool IsSetRedundancyPercent()
        {
            return this._redundancyPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}