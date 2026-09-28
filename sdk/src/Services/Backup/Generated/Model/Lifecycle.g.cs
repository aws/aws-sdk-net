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
    /// Specifies the time period, in days, before a recovery point transitions to cold storage
    /// or is deleted.
    /// 
    ///  
    /// <para>
    /// Backups transitioned to cold storage must be stored in cold storage for a minimum
    /// of 90 days. Therefore, on the console, the retention setting must be 90 days greater
    /// than the transition to cold after days setting. The transition to cold after days
    /// setting can't be changed after a backup has been transitioned to cold.
    /// </para>
    ///  
    /// <para>
    /// Resource types that can transition to cold storage are listed in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
    /// availability by resource</a> table. Backup ignores this expression for other resource
    /// types.
    /// </para>
    ///  
    /// <para>
    /// To remove the existing lifecycle and retention periods and keep your recovery points
    /// indefinitely, specify -1 for <c>MoveToColdStorageAfterDays</c> and <c>DeleteAfterDays</c>.
    /// </para>
    /// </summary>
    public partial class Lifecycle
    {
        /// <summary>
        /// Gets and sets the property DeleteAfterDays. 
        /// <para>
        /// The number of days after creation that a recovery point is deleted. This value must
        /// be at least 90 days after the number of days specified in <c>MoveToColdStorageAfterDays</c>.
        /// </para>
        /// </summary>
        public long? DeleteAfterDays { get; set; }

        /// <summary>
        /// Checks to see if the DeleteAfterDays property is set.
        /// </summary>
        internal bool IsSetDeleteAfterDays() => this.DeleteAfterDays.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteAfterEvent. 
        /// <para>
        /// The event after which a recovery point is deleted. A recovery point with both <c>DeleteAfterDays</c>
        /// and <c>DeleteAfterEvent</c> will delete after whichever condition is satisfied first.
        /// Not valid as an input.
        /// </para>
        /// </summary>
        public LifecycleDeleteAfterEvent DeleteAfterEvent { get; set; }

        /// <summary>
        /// Checks to see if the DeleteAfterEvent property is set.
        /// </summary>
        internal bool IsSetDeleteAfterEvent() => this.DeleteAfterEvent != null;

        /// <summary>
        /// Gets and sets the property MoveToColdStorageAfterDays. 
        /// <para>
        /// The number of days after creation that a recovery point is moved to cold storage.
        /// </para>
        /// </summary>
        public long? MoveToColdStorageAfterDays { get; set; }

        /// <summary>
        /// Checks to see if the MoveToColdStorageAfterDays property is set.
        /// </summary>
        internal bool IsSetMoveToColdStorageAfterDays() => this.MoveToColdStorageAfterDays.HasValue;

        /// <summary>
        /// Gets and sets the property OptInToArchiveForSupportedResources. 
        /// <para>
        /// If the value is true, your backup plan transitions supported resources to archive
        /// (cold) storage tier in accordance with your lifecycle settings.
        /// </para>
        /// </summary>
        public bool? OptInToArchiveForSupportedResources { get; set; }

        /// <summary>
        /// Checks to see if the OptInToArchiveForSupportedResources property is set.
        /// </summary>
        internal bool IsSetOptInToArchiveForSupportedResources() => this.OptInToArchiveForSupportedResources.HasValue;
    }
}
