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
    /// The authentication configuration for a connection returned by the <c>DescribeConnectionType</c>
    /// API.
    /// </summary>
    public partial class AuthConfiguration
    {
        private Property _authenticationType;
        private Dictionary<string, Property> _basicAuthenticationProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private Dictionary<string, Property> _customAuthenticationProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private Dictionary<string, Property> _oAuth2Properties = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private Property _secretArn;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication for a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Property AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthenticationProperties. 
        /// <para>
        /// A map of key-value pairs for the OAuth2 properties. Each value is a a <c>Property</c>
        /// object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> BasicAuthenticationProperties
        {
            get { return this._basicAuthenticationProperties; }
            set { this._basicAuthenticationProperties = value; }
        }

        // Check to see if BasicAuthenticationProperties property is set
        internal bool IsSetBasicAuthenticationProperties()
        {
            return this._basicAuthenticationProperties != null && (this._basicAuthenticationProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomAuthenticationProperties. 
        /// <para>
        /// A map of key-value pairs for the custom authentication properties. Each value is a
        /// a <c>Property</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> CustomAuthenticationProperties
        {
            get { return this._customAuthenticationProperties; }
            set { this._customAuthenticationProperties = value; }
        }

        // Check to see if CustomAuthenticationProperties property is set
        internal bool IsSetCustomAuthenticationProperties()
        {
            return this._customAuthenticationProperties != null && (this._customAuthenticationProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OAuth2Properties. 
        /// <para>
        /// A map of key-value pairs for the OAuth2 properties. Each value is a a <c>Property</c>
        /// object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Property> OAuth2Properties
        {
            get { return this._oAuth2Properties; }
            set { this._oAuth2Properties = value; }
        }

        // Check to see if OAuth2Properties property is set
        internal bool IsSetOAuth2Properties()
        {
            return this._oAuth2Properties != null && (this._oAuth2Properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Secrets Manager.
        /// </para>
        /// </summary>
        public Property SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}