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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use these settings to insert a DVB Network Information Table (NIT) in the transport
    /// stream of this output.
    /// </summary>
    public partial class DvbNitSettings
    {
        private int? _networkId;
        private string _networkName;
        private int? _nitInterval;

        /// <summary>
        /// Gets and sets the property NetworkId. The numeric value placed in the Network Information
        /// Table (NIT).
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkName. The network name text placed in the network_name_descriptor
        /// inside the Network Information Table. Maximum length is 256 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NetworkName
        {
            get { return this._networkName; }
            set { this._networkName = value; }
        }

        // Check to see if NetworkName property is set
        internal bool IsSetNetworkName()
        {
            return this._networkName != null;
        }

        /// <summary>
        /// Gets and sets the property NitInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min=25, Max=10000)]
        public int? NitInterval
        {
            get { return this._nitInterval; }
            set { this._nitInterval = value; }
        }

        // Check to see if NitInterval property is set
        internal bool IsSetNitInterval()
        {
            return this._nitInterval.HasValue; 
        }

    }
}