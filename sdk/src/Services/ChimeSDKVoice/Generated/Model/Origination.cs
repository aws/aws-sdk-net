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
    /// Origination settings enable your SIP hosts to receive inbound calls using your Amazon
    /// Chime SDK Voice Connector.
    /// 
    ///  <note> 
    /// <para>
    /// The parameters listed below are not required, but you must use at least one.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Origination
    {
        private bool? _disabled;
        private List<OriginationRoute> _routes = new List<OriginationRoute>();

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When origination settings are disabled, inbound calls are not enabled for your Amazon
        /// Chime SDK Voice Connector. This parameter is not required, but you must specify this
        /// parameter or <code>Routes</code>.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The call distribution properties defined for your SIP hosts. Valid range: Minimum
        /// value of 1. Maximum value of 20. This parameter is not required, but you must specify
        /// this parameter or <code>Disabled</code>.
        /// </para>
        /// </summary>
        public List<OriginationRoute> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && this._routes.Count > 0; 
        }

    }
}