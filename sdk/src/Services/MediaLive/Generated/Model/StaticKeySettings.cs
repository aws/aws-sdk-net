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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Static Key Settings
    /// </summary>
    public partial class StaticKeySettings
    {
        private InputLocation _keyProviderServer;
        private string _staticKeyValue;

        /// <summary>
        /// Gets and sets the property KeyProviderServer. The URL of the license server used for
        /// protecting content.
        /// </summary>
        public InputLocation KeyProviderServer
        {
            get { return this._keyProviderServer; }
            set { this._keyProviderServer = value; }
        }

        // Check to see if KeyProviderServer property is set
        internal bool IsSetKeyProviderServer()
        {
            return this._keyProviderServer != null;
        }

        /// <summary>
        /// Gets and sets the property StaticKeyValue. Static key value as a 32 character hexadecimal
        /// string.
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string StaticKeyValue
        {
            get { return this._staticKeyValue; }
            set { this._staticKeyValue = value; }
        }

        // Check to see if StaticKeyValue property is set
        internal bool IsSetStaticKeyValue()
        {
            return this._staticKeyValue != null;
        }

    }
}