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
    /// Container for the parameters to the GetBackupPlan operation.
    /// Returns <c>BackupPlan</c> details for the specified <c>BackupPlanId</c>. The details
    /// are the body of a backup plan in JSON format, in addition to plan metadata.
    /// </summary>
    public partial class GetBackupPlanRequest : AmazonBackupRequest
    {
        private string _backupPlanId;
        private int? _maxScheduledRunsPreview;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// Uniquely identifies a backup plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupPlanId
        {
            get { return this._backupPlanId; }
            set { this._backupPlanId = value; }
        }

        // Check to see if BackupPlanId property is set
        internal bool IsSetBackupPlanId()
        {
            return this._backupPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxScheduledRunsPreview. 
        /// <para>
        /// Number of future scheduled backup runs to preview. When set to 0 (default), no scheduled
        /// runs preview is included in the response. Valid range is 0-10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int MaxScheduledRunsPreview
        {
            get { return this._maxScheduledRunsPreview.GetValueOrDefault(); }
            set { this._maxScheduledRunsPreview = value; }
        }

        // Check to see if MaxScheduledRunsPreview property is set
        internal bool IsSetMaxScheduledRunsPreview()
        {
            return this._maxScheduledRunsPreview.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Unique, randomly generated, Unicode, UTF-8 encoded strings that are at most 1,024
        /// bytes long. Version IDs cannot be edited.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}