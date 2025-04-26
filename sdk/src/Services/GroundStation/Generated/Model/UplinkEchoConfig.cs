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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about an uplink echo <c>Config</c>.
    /// 
    ///  
    /// <para>
    /// Parameters from the <c>AntennaUplinkConfig</c>, corresponding to the specified <c>AntennaUplinkConfigArn</c>,
    /// are used when this <c>UplinkEchoConfig</c> is used in a contact.
    /// </para>
    /// </summary>
    public partial class UplinkEchoConfig
    {
        private string _antennaUplinkConfigArn;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property AntennaUplinkConfigArn. 
        /// <para>
        /// ARN of an uplink <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=82, Max=424)]
        public string AntennaUplinkConfigArn
        {
            get { return this._antennaUplinkConfigArn; }
            set { this._antennaUplinkConfigArn = value; }
        }

        // Check to see if AntennaUplinkConfigArn property is set
        internal bool IsSetAntennaUplinkConfigArn()
        {
            return this._antennaUplinkConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether or not an uplink <c>Config</c> is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}