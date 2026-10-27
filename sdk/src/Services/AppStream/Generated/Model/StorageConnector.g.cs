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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a connector that enables persistent storage for users.
    /// </summary>
    public partial class StorageConnector
    {
        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The type of storage connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;

        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The names of the domains for the account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Domains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Domains property is set.
        /// </summary>
        internal bool IsSetDomains() => this.Domains != null && (this.Domains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainsRequireAdminConsent. 
        /// <para>
        /// The OneDrive for Business domains where you require admin consent when users try to
        /// link their OneDrive account to WorkSpaces Applications. The attribute can only be
        /// specified when ConnectorType=ONE_DRIVE.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> DomainsRequireAdminConsent { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DomainsRequireAdminConsent property is set.
        /// </summary>
        internal bool IsSetDomainsRequireAdminConsent() => this.DomainsRequireAdminConsent != null && (this.DomainsRequireAdminConsent.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ARN of the storage connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;
    }
}
