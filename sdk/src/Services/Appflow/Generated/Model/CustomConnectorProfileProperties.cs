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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The profile properties required by the custom connector.
    /// </summary>
    public partial class CustomConnectorProfileProperties
    {
        private OAuth2Properties _oAuth2Properties;
        private Dictionary<string, string> _profileProperties = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property OAuth2Properties.
        /// </summary>
        public OAuth2Properties OAuth2Properties
        {
            get { return this._oAuth2Properties; }
            set { this._oAuth2Properties = value; }
        }

        // Check to see if OAuth2Properties property is set
        internal bool IsSetOAuth2Properties()
        {
            return this._oAuth2Properties != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileProperties. 
        /// <para>
        /// A map of properties that are required to create a profile for the custom connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> ProfileProperties
        {
            get { return this._profileProperties; }
            set { this._profileProperties = value; }
        }

        // Check to see if ProfileProperties property is set
        internal bool IsSetProfileProperties()
        {
            return this._profileProperties != null && this._profileProperties.Count > 0; 
        }

    }
}