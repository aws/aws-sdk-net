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
    /// Container for the parameters to the StartSingleWirelessDeviceImportTask operation.
    /// Start import task for a single wireless device.
    /// </summary>
    public partial class StartSingleWirelessDeviceImportTaskRequest : AmazonIoTWirelessRequest
    {
        private string _clientRequestToken;
        private string _destinationName;
        private string _deviceName;
        private SidewalkSingleStartImportInfo _sidewalk;
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
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the Sidewalk destination that describes the IoT rule to route messages
        /// from the device in the import task that will be onboarded to AWS IoT Wireless.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the wireless device for which an import task is being started.
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk-related parameters for importing a single wireless device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SidewalkSingleStartImportInfo Sidewalk
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