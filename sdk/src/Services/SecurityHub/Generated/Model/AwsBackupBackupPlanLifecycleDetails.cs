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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides lifecycle details for the backup plan. A lifecycle defines when a backup
    /// is transitioned to cold storage and when it expires.
    /// </summary>
    public partial class AwsBackupBackupPlanLifecycleDetails
    {
        private long? _deleteAfterDays;
        private long? _moveToColdStorageAfterDays;

        /// <summary>
        /// Gets and sets the property DeleteAfterDays. 
        /// <para>
        /// Specifies the number of days after creation that a recovery point is deleted. Must
        /// be greater than 90 days plus <code>MoveToColdStorageAfterDays</code>. 
        /// </para>
        /// </summary>
        public long DeleteAfterDays
        {
            get { return this._deleteAfterDays.GetValueOrDefault(); }
            set { this._deleteAfterDays = value; }
        }

        // Check to see if DeleteAfterDays property is set
        internal bool IsSetDeleteAfterDays()
        {
            return this._deleteAfterDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MoveToColdStorageAfterDays. 
        /// <para>
        /// Specifies the number of days after creation that a recovery point is moved to cold
        /// storage. 
        /// </para>
        /// </summary>
        public long MoveToColdStorageAfterDays
        {
            get { return this._moveToColdStorageAfterDays.GetValueOrDefault(); }
            set { this._moveToColdStorageAfterDays = value; }
        }

        // Check to see if MoveToColdStorageAfterDays property is set
        internal bool IsSetMoveToColdStorageAfterDays()
        {
            return this._moveToColdStorageAfterDays.HasValue; 
        }

    }
}