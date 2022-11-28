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
    /// Global identity information.
    /// </summary>
    public partial class GlobalIdentity
    {
        private int? _geranCid;
        private int? _lac;

        /// <summary>
        /// Gets and sets the property GeranCid. 
        /// <para>
        /// GERAN (GSM EDGE Radio Access Network) cell global identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int GeranCid
        {
            get { return this._geranCid.GetValueOrDefault(); }
            set { this._geranCid = value; }
        }

        // Check to see if GeranCid property is set
        internal bool IsSetGeranCid()
        {
            return this._geranCid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lac. 
        /// <para>
        /// Location area code of the global identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int Lac
        {
            get { return this._lac.GetValueOrDefault(); }
            set { this._lac = value; }
        }

        // Check to see if Lac property is set
        internal bool IsSetLac()
        {
            return this._lac.HasValue; 
        }

    }
}