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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Contains the authentication configuration details for a data accessor. This structure
    /// defines how the ISV authenticates when accessing data through the data accessor.
    /// </summary>
    public partial class DataAccessorAuthenticationDetail
    {
        private DataAccessorAuthenticationConfiguration _authenticationConfiguration;
        private DataAccessorAuthenticationType _authenticationType;
        private List<string> _externalIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The specific authentication configuration based on the authentication type.
        /// </para>
        /// </summary>
        public DataAccessorAuthenticationConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The type of authentication to use for the data accessor. This determines how the ISV
        /// authenticates when accessing data. You can use one of two authentication types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_IAM_IDC_TTI</c> - Authentication using IAM Identity Center Trusted Token Issuer
        /// (TTI). This authentication type allows the ISV to use a trusted token issuer to generate
        /// tokens for accessing the data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_IAM_IDC_AUTH_CODE</c> - Authentication using IAM Identity Center authorization
        /// code flow. This authentication type uses the standard OAuth 2.0 authorization code
        /// flow for authentication.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataAccessorAuthenticationType AuthenticationType
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
        /// Gets and sets the property ExternalIds. 
        /// <para>
        /// A list of external identifiers associated with this authentication configuration.
        /// These are used to correlate the data accessor with external systems.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ExternalIds
        {
            get { return this._externalIds; }
            set { this._externalIds = value; }
        }

        // Check to see if ExternalIds property is set
        internal bool IsSetExternalIds()
        {
            return this._externalIds != null && (this._externalIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}