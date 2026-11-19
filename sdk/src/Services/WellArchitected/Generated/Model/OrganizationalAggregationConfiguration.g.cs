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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The organizational monitoring boundary configuration. Contains organizational unit
    /// entries and individual account entries, each with their own region selections, that
    /// define the scope for organizational profile analysis.
    /// </summary>
    public partial class OrganizationalAggregationConfiguration
    {
        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// A list of individual account entries that define additional accounts to include. Each
        /// entry specifies an account ID and the regions to monitor within it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public List<OrganizationalAccountEntry> Accounts { get; set; } = AWSConfigs.InitializeCollections ? new List<OrganizationalAccountEntry>() : null;

        /// <summary>
        /// Checks to see if the Accounts property is set.
        /// </summary>
        internal bool IsSetAccounts() => this.Accounts != null && (this.Accounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// A list of organizational unit or root entries that define the organizational scope.
        /// Each entry specifies an OU or root ID and the regions to monitor within it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public List<OrganizationalUnitEntry> OrganizationalUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<OrganizationalUnitEntry>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnits property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnits() => this.OrganizationalUnits != null && (this.OrganizationalUnits.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
