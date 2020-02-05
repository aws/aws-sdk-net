/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about an uplink echo <code>Config</code>.
    /// 
    ///  
    /// <para>
    /// Parameters from the <code>AntennaUplinkConfig</code>, corresponding to the specified
    /// <code>AntennaUplinkConfigArn</code>, are used when this <code>UplinkEchoConfig</code>
    /// is used in a contact.
    /// </para>
    /// </summary>
    public partial class UplinkEchoConfig
    {
        private string _antennaUplinkConfigArn;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property AntennaUplinkConfigArn. 
        /// <para>
        /// ARN of an uplink <code>Config</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Whether or not an uplink <code>Config</code> is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}