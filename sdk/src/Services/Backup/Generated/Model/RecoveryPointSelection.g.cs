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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This specifies criteria to assign a set of resources, such as resource types or backup
    /// vaults.
    /// </summary>
    public partial class RecoveryPointSelection
    {
        /// <summary>
        /// Gets and sets the property DateRange.
        /// </summary>
        public DateRange DateRange { get; set; }

        /// <summary>
        /// Checks to see if the DateRange property is set.
        /// </summary>
        internal bool IsSetDateRange() => this.DateRange != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. 
        /// <para>
        /// These are the resources included in the resource selection (including type of resources
        /// and vaults).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceIdentifiers property is set.
        /// </summary>
        internal bool IsSetResourceIdentifiers() => this.ResourceIdentifiers != null && (this.ResourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VaultNames. 
        /// <para>
        /// These are the names of the vaults in which the selected recovery points are contained.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VaultNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VaultNames property is set.
        /// </summary>
        internal bool IsSetVaultNames() => this.VaultNames != null && (this.VaultNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
