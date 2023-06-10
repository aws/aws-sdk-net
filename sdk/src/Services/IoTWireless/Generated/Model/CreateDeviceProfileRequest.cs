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
    /// Container for the parameters to the CreateDeviceProfile operation.
    /// Creates a new device profile.
    /// </summary>
    public partial class CreateDeviceProfileRequest : AmazonIoTWirelessRequest
    {
        private string _clientRequestToken;
        private LoRaWANDeviceProfile _loRaWAN;
        private string _name;
        private SidewalkCreateDeviceProfile _sidewalk;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Each resource must have a unique client request token. If you try to create a new
        /// resource with the same token as a resource that already exists, an exception occurs.
        /// If you omit this value, AWS SDKs will automatically generate a unique client request.
        /// 
        /// </para>
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
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// The device profile information to use to create the device profile.
        /// </para>
        /// </summary>
        public LoRaWANDeviceProfile LoRaWAN
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
        /// <para>
        /// The name of the new resource.
        /// </para>
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
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk-related information for creating the Sidewalk device profile.
        /// </para>
        /// </summary>
        public SidewalkCreateDeviceProfile Sidewalk
        {
            get { return this._sidewalk; }
            set { this._sidewalk = value; }
        }

        // Check to see if Sidewalk property is set
        internal bool IsSetSidewalk()
        {
            return this._sidewalk != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the new device profile. Tags are metadata that you can use to
        /// manage a resource.
        /// </para>
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