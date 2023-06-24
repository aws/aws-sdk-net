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
    /// WCDMA local identification (local ID) information.
    /// </summary>
    public partial class WcdmaLocalId
    {
        private int? _psc;
        private int? _uarfcndl;

        /// <summary>
        /// Gets and sets the property Psc. 
        /// <para>
        /// Primary Scrambling Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=511)]
        public int Psc
        {
            get { return this._psc.GetValueOrDefault(); }
            set { this._psc = value; }
        }

        // Check to see if Psc property is set
        internal bool IsSetPsc()
        {
            return this._psc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uarfcndl. 
        /// <para>
        /// WCDMA UTRA Absolute RF Channel Number downlink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=16383)]
        public int Uarfcndl
        {
            get { return this._uarfcndl.GetValueOrDefault(); }
            set { this._uarfcndl = value; }
        }

        // Check to see if Uarfcndl property is set
        internal bool IsSetUarfcndl()
        {
            return this._uarfcndl.HasValue; 
        }

    }
}