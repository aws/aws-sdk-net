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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Configuration information when authentication mode is FEDERATED.
    /// </summary>
    public partial class FederationParameters
    {
        private string _applicationCallBackURL;
        private Dictionary<string, string> _attributeMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _federationProviderName;
        private string _federationurn;
        private string _samlMetadataDocument;
        private string _samlMetadataURL;

        /// <summary>
        /// Gets and sets the property ApplicationCallBackURL. 
        /// <para>
        /// The redirect or sign-in URL that should be entered into the SAML 2.0 compliant identity
        /// provider configuration (IdP).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ApplicationCallBackURL
        {
            get { return this._applicationCallBackURL; }
            set { this._applicationCallBackURL = value; }
        }

        // Check to see if ApplicationCallBackURL property is set
        internal bool IsSetApplicationCallBackURL()
        {
            return this._applicationCallBackURL != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeMap. 
        /// <para>
        /// SAML attribute name and value. The name must always be <c>Email</c> and the value
        /// should be set to the attribute definition in which user email is set. For example,
        /// name would be <c>Email</c> and value <c>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress</c>.
        /// Please check your SAML 2.0 compliant identity provider (IdP) documentation for details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AttributeMap
        {
            get { return this._attributeMap; }
            set { this._attributeMap = value; }
        }

        // Check to see if AttributeMap property is set
        internal bool IsSetAttributeMap()
        {
            return this._attributeMap != null && (this._attributeMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FederationProviderName. 
        /// <para>
        /// Name of the identity provider (IdP).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string FederationProviderName
        {
            get { return this._federationProviderName; }
            set { this._federationProviderName = value; }
        }

        // Check to see if FederationProviderName property is set
        internal bool IsSetFederationProviderName()
        {
            return this._federationProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property FederationURN. 
        /// <para>
        /// The Uniform Resource Name (URN). Also referred as Service Provider URN or Audience
        /// URI or Service Provider Entity ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FederationURN
        {
            get { return this._federationurn; }
            set { this._federationurn = value; }
        }

        // Check to see if FederationURN property is set
        internal bool IsSetFederationURN()
        {
            return this._federationurn != null;
        }

        /// <summary>
        /// Gets and sets the property SamlMetadataDocument. 
        /// <para>
        /// SAML 2.0 Metadata document from identity provider (IdP).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1000, Max=10000000)]
        public string SamlMetadataDocument
        {
            get { return this._samlMetadataDocument; }
            set { this._samlMetadataDocument = value; }
        }

        // Check to see if SamlMetadataDocument property is set
        internal bool IsSetSamlMetadataDocument()
        {
            return this._samlMetadataDocument != null;
        }

        /// <summary>
        /// Gets and sets the property SamlMetadataURL. 
        /// <para>
        /// Provide the metadata URL from your SAML 2.0 compliant identity provider (IdP).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string SamlMetadataURL
        {
            get { return this._samlMetadataURL; }
            set { this._samlMetadataURL = value; }
        }

        // Check to see if SamlMetadataURL property is set
        internal bool IsSetSamlMetadataURL()
        {
            return this._samlMetadataURL != null;
        }

    }
}