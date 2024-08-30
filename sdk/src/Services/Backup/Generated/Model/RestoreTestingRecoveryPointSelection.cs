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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Backup.Model
{
    /// <summary>
    /// <c>RecoveryPointSelection</c> has five parameters (three required and two optional).
    /// The values you specify determine which recovery point is included in the restore test.
    /// You must indicate with <c>Algorithm</c> if you want the latest recovery point within
    /// your <c>SelectionWindowDays</c> or if you want a random recovery point, and you must
    /// indicate through <c>IncludeVaults</c> from which vaults the recovery points can be
    /// chosen.
    /// 
    ///  
    /// <para>
    ///  <c>Algorithm</c> (<i>required</i>) Valid values: "<c>LATEST_WITHIN_WINDOW</c>" or
    /// "<c>RANDOM_WITHIN_WINDOW</c>".
    /// </para>
    ///  
    /// <para>
    ///  <c>Recovery point types</c> (<i>required</i>) Valid values: "<c>SNAPSHOT</c>" and/or
    /// "<c>CONTINUOUS</c>". Include <c>SNAPSHOT</c> to restore only snapshot recovery points;
    /// include <c>CONTINUOUS</c> to restore continuous recovery points (point in time restore
    /// / PITR); use both to restore either a snapshot or a continuous recovery point. The
    /// recovery point will be determined by the value for <c>Algorithm</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>IncludeVaults</c> (<i>required</i>). You must include one or more backup vaults.
    /// Use the wildcard ["*"] or specific ARNs.
    /// </para>
    ///  
    /// <para>
    ///  <c>SelectionWindowDays</c> (<i>optional</i>) Value must be an integer (in days) from
    /// 1 to 365. If not included, the value defaults to <c>30</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>ExcludeVaults</c> (<i>optional</i>). You can choose to input one or more specific
    /// backup vault ARNs to exclude those vaults' contents from restore eligibility. Or,
    /// you can include a list of selectors. If this parameter and its value are not included,
    /// it defaults to empty list.
    /// </para>
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
        ///  
        /// <para>
        /// Include <c>SNAPSHOT</c> to restore only snapshot recovery points; include <c>CONTINUOUS</c>
        /// to restore continuous recovery points (point in time restore / PITR); use both to
        /// restore either a snapshot or a continuous recovery point. The recovery point will
        /// be determined by the value for <c>Algorithm</c>.
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