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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about update activities for different components of a hybrid
    /// directory.
    /// </summary>
    public partial class HybridUpdateActivities
    {
        private List<HybridUpdateInfoEntry> _hybridAdministratorAccount = AWSConfigs.InitializeCollections ? new List<HybridUpdateInfoEntry>() : null;
        private List<HybridUpdateInfoEntry> _selfManagedInstances = AWSConfigs.InitializeCollections ? new List<HybridUpdateInfoEntry>() : null;

        /// <summary>
        /// Gets and sets the property HybridAdministratorAccount. 
        /// <para>
        /// A list of update activities related to hybrid directory administrator account changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HybridUpdateInfoEntry> HybridAdministratorAccount
        {
            get { return this._hybridAdministratorAccount; }
            set { this._hybridAdministratorAccount = value; }
        }

        // Check to see if HybridAdministratorAccount property is set
        internal bool IsSetHybridAdministratorAccount()
        {
            return this._hybridAdministratorAccount != null && (this._hybridAdministratorAccount.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelfManagedInstances. 
        /// <para>
        /// A list of update activities related to the self-managed instances with SSM in the
        /// self-managed instances with SSM hybrid directory configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HybridUpdateInfoEntry> SelfManagedInstances
        {
            get { return this._selfManagedInstances; }
            set { this._selfManagedInstances = value; }
        }

        // Check to see if SelfManagedInstances property is set
        internal bool IsSetSelfManagedInstances()
        {
            return this._selfManagedInstances != null && (this._selfManagedInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}