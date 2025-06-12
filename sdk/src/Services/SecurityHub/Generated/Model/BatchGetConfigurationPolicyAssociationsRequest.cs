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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetConfigurationPolicyAssociations operation.
    /// Returns associations between an Security Hub configuration and a batch of target
    /// accounts, organizational units, or the root. Only the Security Hub delegated administrator
    /// can invoke this operation from the home Region. A configuration can refer to a configuration
    /// policy or to a self-managed configuration.
    /// </summary>
    public partial class BatchGetConfigurationPolicyAssociationsRequest : AmazonSecurityHubRequest
    {
        private List<ConfigurationPolicyAssociation> _configurationPolicyAssociationIdentifiers = AWSConfigs.InitializeCollections ? new List<ConfigurationPolicyAssociation>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyAssociationIdentifiers. 
        /// <para>
        ///  Specifies one or more target account IDs, organizational unit (OU) IDs, or the root
        /// ID to retrieve associations for. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConfigurationPolicyAssociation> ConfigurationPolicyAssociationIdentifiers
        {
            get { return this._configurationPolicyAssociationIdentifiers; }
            set { this._configurationPolicyAssociationIdentifiers = value; }
        }

        // Check to see if ConfigurationPolicyAssociationIdentifiers property is set
        internal bool IsSetConfigurationPolicyAssociationIdentifiers()
        {
            return this._configurationPolicyAssociationIdentifiers != null && (this._configurationPolicyAssociationIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}