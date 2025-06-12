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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The endpoint information to connect to your SharePoint data source.
    /// </summary>
    public partial class SharePointSourceConfiguration
    {
        private SharePointAuthType _authType;
        private string _credentialsSecretArn;
        private string _domain;
        private SharePointHostType _hostType;
        private List<string> _siteUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The supported authentication type to authenticate and connect to your SharePoint site/sites.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SharePointAuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsSecretArn. 
        /// <para>
        /// The Amazon Resource Name of an Secrets Manager secret that stores your authentication
        /// credentials for your SharePoint site/sites. For more information on the key-value
        /// pairs that must be included in your secret, depending on your authentication type,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sharepoint-data-source-connector.html#configuration-sharepoint-connector">SharePoint
        /// connection configuration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialsSecretArn
        {
            get { return this._credentialsSecretArn; }
            set { this._credentialsSecretArn = value; }
        }

        // Check to see if CredentialsSecretArn property is set
        internal bool IsSetCredentialsSecretArn()
        {
            return this._credentialsSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain of your SharePoint instance or site URL/URLs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property HostType. 
        /// <para>
        /// The supported host type, whether online/cloud or server/on-premises.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SharePointHostType HostType
        {
            get { return this._hostType; }
            set { this._hostType = value; }
        }

        // Check to see if HostType property is set
        internal bool IsSetHostType()
        {
            return this._hostType != null;
        }

        /// <summary>
        /// Gets and sets the property SiteUrls. 
        /// <para>
        /// A list of one or more SharePoint site URLs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> SiteUrls
        {
            get { return this._siteUrls; }
            set { this._siteUrls = value; }
        }

        // Check to see if SiteUrls property is set
        internal bool IsSetSiteUrls()
        {
            return this._siteUrls != null && (this._siteUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The identifier of your Microsoft 365 tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}