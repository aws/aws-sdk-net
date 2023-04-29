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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Nielsen Naes Ii Nw
    /// </summary>
    public partial class NielsenNaesIiNw
    {
        private string _checkDigitString;
        private double? _sid;
        private NielsenWatermarkTimezones _timezone;

        /// <summary>
        /// Gets and sets the property CheckDigitString. Enter the check digit string for the
        /// watermark
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public string CheckDigitString
        {
            get { return this._checkDigitString; }
            set { this._checkDigitString = value; }
        }

        // Check to see if CheckDigitString property is set
        internal bool IsSetCheckDigitString()
        {
            return this._checkDigitString != null;
        }

        /// <summary>
        /// Gets and sets the property Sid. Enter the Nielsen Source ID (SID) to include in the
        /// watermark
        /// </summary>
        [AWSProperty(Required=true)]
        public double Sid
        {
            get { return this._sid.GetValueOrDefault(); }
            set { this._sid = value; }
        }

        // Check to see if Sid property is set
        internal bool IsSetSid()
        {
            return this._sid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timezone. Choose the timezone for the time stamps in the
        /// watermark. If not provided,the timestamps will be in Coordinated Universal Time (UTC)
        /// </summary>
        public NielsenWatermarkTimezones Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}