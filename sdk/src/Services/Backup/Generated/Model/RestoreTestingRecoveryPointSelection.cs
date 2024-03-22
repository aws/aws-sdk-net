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
    /// Required: Algorithm; Required: Recovery point types; IncludeVaults(one or more). Optional:
    /// SelectionWindowDays ('30' if not specified);ExcludeVaults (list of selectors), defaults
    /// to empty list if not listed.
    /// </summary>
    public partial class RestoreTestingRecoveryPointSelection
    {
        private RestoreTestingRecoveryPointSelectionAlgorithm _algorithm;
        private List<string> _excludeVaults = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeVaults = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _recoveryPointTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _selectionWindowDays;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// Acceptable values include "LATEST_WITHIN_WINDOW" or "RANDOM_WITHIN_WINDOW"
        /// </para>
        /// </summary>
        public RestoreTestingRecoveryPointSelectionAlgorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeVaults. 
        /// <para>
        /// Accepted values include specific ARNs or list of selectors. Defaults to empty list
        /// if not listed.
        /// </para>
        /// </summary>
        public List<string> ExcludeVaults
        {
            get { return this._excludeVaults; }
            set { this._excludeVaults = value; }
        }

        // Check to see if ExcludeVaults property is set
        internal bool IsSetExcludeVaults()
        {
            return this._excludeVaults != null && (this._excludeVaults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeVaults. 
        /// <para>
        /// Accepted values include wildcard ["*"] or by specific ARNs or ARN wilcard replacement
        /// ["arn:aws:backup:us-west-2:123456789012:backup-vault:asdf", ...] ["arn:aws:backup:*:*:backup-vault:asdf-*",
        /// ...]
        /// </para>
        /// </summary>
        public List<string> IncludeVaults
        {
            get { return this._includeVaults; }
            set { this._includeVaults = value; }
        }

        // Check to see if IncludeVaults property is set
        internal bool IsSetIncludeVaults()
        {
            return this._includeVaults != null && (this._includeVaults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointTypes. 
        /// <para>
        /// These are the types of recovery points.
        /// </para>
        /// </summary>
        public List<string> RecoveryPointTypes
        {
            get { return this._recoveryPointTypes; }
            set { this._recoveryPointTypes = value; }
        }

        // Check to see if RecoveryPointTypes property is set
        internal bool IsSetRecoveryPointTypes()
        {
            return this._recoveryPointTypes != null && (this._recoveryPointTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectionWindowDays. 
        /// <para>
        /// Accepted values are integers from 1 to 365.
        /// </para>
        /// </summary>
        public int SelectionWindowDays
        {
            get { return this._selectionWindowDays.GetValueOrDefault(); }
            set { this._selectionWindowDays = value; }
        }

        // Check to see if SelectionWindowDays property is set
        internal bool IsSetSelectionWindowDays()
        {
            return this._selectionWindowDays.HasValue; 
        }

    }
}