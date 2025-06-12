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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a connector that enables persistent storage for users.
    /// </summary>
    public partial class StorageConnector
    {
        private StorageConnectorType _connectorType;
        private List<string> _domains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _domainsRequireAdminConsent = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The type of storage connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageConnectorType ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null;
        }

        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The names of the domains for the account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && (this._domains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainsRequireAdminConsent. 
        /// <para>
        /// The OneDrive for Business domains where you require admin consent when users try to
        /// link their OneDrive account to AppStream 2.0. The attribute can only be specified
        /// when ConnectorType=ONE_DRIVE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> DomainsRequireAdminConsent
        {
            get { return this._domainsRequireAdminConsent; }
            set { this._domainsRequireAdminConsent = value; }
        }

        // Check to see if DomainsRequireAdminConsent property is set
        internal bool IsSetDomainsRequireAdminConsent()
        {
            return this._domainsRequireAdminConsent != null && (this._domainsRequireAdminConsent.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ARN of the storage connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}