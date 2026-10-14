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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AuthenticationTypes. 
        /// <para>
        /// A list of authentication types supported by this connection type, such as Basic, OAuth2,
        /// or Custom authentication methods.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AuthenticationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationTypes property is set.
        /// </summary>
        internal bool IsSetAuthenticationTypes() => this.AuthenticationTypes != null && (this.AuthenticationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BasicAuthenticationProperties.
        /// </summary>
        public BasicAuthenticationProperties BasicAuthenticationProperties { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthenticationProperties property is set.
        /// </summary>
        internal bool IsSetBasicAuthenticationProperties() => this.BasicAuthenticationProperties != null;

        /// <summary>
        /// Gets and sets the property CustomAuthenticationProperties.
        /// </summary>
        public CustomAuthenticationProperties CustomAuthenticationProperties { get; set; }

        /// <summary>
        /// Checks to see if the CustomAuthenticationProperties property is set.
        /// </summary>
        internal bool IsSetCustomAuthenticationProperties() => this.CustomAuthenticationProperties != null;

        /// <summary>
        /// Gets and sets the property OAuth2Properties.
        /// </summary>
        public ConnectorOAuth2Properties OAuth2Properties { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2Properties property is set.
        /// </summary>
        internal bool IsSetOAuth2Properties() => this.OAuth2Properties != null;
    }
}
