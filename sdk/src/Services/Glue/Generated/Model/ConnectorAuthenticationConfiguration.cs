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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration that defines the supported authentication types and required properties
    /// for the connection type.
    /// </summary>
    public partial class ConnectorAuthenticationConfiguration
    {
        private List<string> _authenticationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private BasicAuthenticationProperties _basicAuthenticationProperties;
        private CustomAuthenticationProperties _customAuthenticationProperties;
        private ConnectorOAuth2Properties _oAuth2Properties;

        /// <summary>
        /// Gets and sets the property AuthenticationTypes. 
        /// <para>
        /// A list of authentication types supported by this connection type, such as Basic, OAuth2,
        /// or Custom authentication methods.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AuthenticationTypes
        {
            get { return this._authenticationTypes; }
            set { this._authenticationTypes = value; }
        }

        // Check to see if AuthenticationTypes property is set
        internal bool IsSetAuthenticationTypes()
        {
            return this._authenticationTypes != null && (this._authenticationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BasicAuthenticationProperties.
        /// </summary>
        public BasicAuthenticationProperties BasicAuthenticationProperties
        {
            get { return this._basicAuthenticationProperties; }
            set { this._basicAuthenticationProperties = value; }
        }

        // Check to see if BasicAuthenticationProperties property is set
        internal bool IsSetBasicAuthenticationProperties()
        {
            return this._basicAuthenticationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAuthenticationProperties.
        /// </summary>
        public CustomAuthenticationProperties CustomAuthenticationProperties
        {
            get { return this._customAuthenticationProperties; }
            set { this._customAuthenticationProperties = value; }
        }

        // Check to see if CustomAuthenticationProperties property is set
        internal bool IsSetCustomAuthenticationProperties()
        {
            return this._customAuthenticationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2Properties.
        /// </summary>
        public ConnectorOAuth2Properties OAuth2Properties
        {
            get { return this._oAuth2Properties; }
            set { this._oAuth2Properties = value; }
        }

        // Check to see if OAuth2Properties property is set
        internal bool IsSetOAuth2Properties()
        {
            return this._oAuth2Properties != null;
        }

    }
}