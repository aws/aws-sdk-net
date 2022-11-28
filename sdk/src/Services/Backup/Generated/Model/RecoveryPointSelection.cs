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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This specifies criteria to assign a set of resources, such as resource types or backup
    /// vaults.
    /// </summary>
    public partial class RecoveryPointSelection
    {
        private DateRange _dateRange;
        private List<string> _resourceIdentifiers = new List<string>();
        private List<string> _vaultNames = new List<string>();

        /// <summary>
        /// Gets and sets the property DateRange.
        /// </summary>
        public DateRange DateRange
        {
            get { return this._dateRange; }
            set { this._dateRange = value; }
        }

        // Check to see if DateRange property is set
        internal bool IsSetDateRange()
        {
            return this._dateRange != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. 
        /// <para>
        /// These are the resources included in the resource selection (including type of resources
        /// and vaults).
        /// </para>
        /// </summary>
        public List<string> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && this._resourceIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VaultNames. 
        /// <para>
        /// These are the names of the vaults in which the selected recovery points are contained.
        /// </para>
        /// </summary>
        public List<string> VaultNames
        {
            get { return this._vaultNames; }
            set { this._vaultNames = value; }
        }

        // Check to see if VaultNames property is set
        internal bool IsSetVaultNames()
        {
            return this._vaultNames != null && this._vaultNames.Count > 0; 
        }

    }
}