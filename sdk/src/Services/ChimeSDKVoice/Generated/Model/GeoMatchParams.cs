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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The country and area code for a proxy phone number in a proxy phone session.
    /// </summary>
    public partial class GeoMatchParams
    {
        private string _areaCode;
        private string _country;

        /// <summary>
        /// Gets and sets the property AreaCode. 
        /// <para>
        /// The area code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AreaCode
        {
            get { return this._areaCode; }
            set { this._areaCode = value; }
        }

        // Check to see if AreaCode property is set
        internal bool IsSetAreaCode()
        {
            return this._areaCode != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

    }
}