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
    /// Contains an array of <c>Transition</c> objects specifying how long in days before
    /// a recovery point transitions to cold storage or is deleted.
    /// 
    ///  
    /// <para>
    /// Backups transitioned to cold storage must be stored in cold storage for a minimum
    /// of 90 days. Therefore, on the console, the “retention” setting must be 90 days greater
    /// than the “transition to cold after days” setting. The “transition to cold after days”
    /// setting cannot be changed after a backup has been transitioned to cold.
    /// </para>
    ///  
    /// <para>
    /// Resource types that are able to be transitioned to cold storage are listed in the
    /// "Lifecycle to cold storage" section of the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#features-by-resource">
    /// Feature availability by resource</a> table. Backup ignores this expression for other
    /// resource types.
    /// </para>
    /// </summary>
    public partial class Lifecycle
    {
        private long? _deleteAfterDays;
        private long? _moveToColdStorageAfterDays;
        private bool? _optInToArchiveForSupportedResources;

        /// <summary>
        /// Gets and sets the property DeleteAfterDays. 
        /// <para>
        /// Specifies the number of days after creation that a recovery point is deleted. Must
        /// be greater than 90 days plus <c>MoveToColdStorageAfterDays</c>.
        /// </para>
        /// </summary>
        public long? DeleteAfterDays
        {
            get { return this._deleteAfterDays; }
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
        public long? MoveToColdStorageAfterDays
        {
            get { return this._moveToColdStorageAfterDays; }
            set { this._moveToColdStorageAfterDays = value; }
        }

        // Check to see if MoveToColdStorageAfterDays property is set
        internal bool IsSetMoveToColdStorageAfterDays()
        {
            return this._moveToColdStorageAfterDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptInToArchiveForSupportedResources. 
        /// <para>
        /// Optional Boolean. If this is true, this setting will instruct your backup plan to
        /// transition supported resources to archive (cold) storage tier in accordance with your
        /// lifecycle settings.
        /// </para>
        /// </summary>
        public bool? OptInToArchiveForSupportedResources
        {
            get { return this._optInToArchiveForSupportedResources; }
            set { this._optInToArchiveForSupportedResources = value; }
        }

        // Check to see if OptInToArchiveForSupportedResources property is set
        internal bool IsSetOptInToArchiveForSupportedResources()
        {
            return this._optInToArchiveForSupportedResources.HasValue; 
        }

    }
}