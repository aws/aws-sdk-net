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
    /// Container for the parameters to the UpdateBackupPlan operation.
    /// Updates the specified backup plan. The new version is uniquely identified by its ID.
    /// </summary>
    public partial class UpdateBackupPlanRequest : AmazonBackupRequest
    {
        private BackupPlanInput _backupPlan;
        private string _backupPlanId;

        /// <summary>
        /// Gets and sets the property BackupPlan. 
        /// <para>
        /// The body of a backup plan. Includes a <c>BackupPlanName</c> and one or more sets of
        /// <c>Rules</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BackupPlanInput BackupPlan
        {
            get { return this._backupPlan; }
            set { this._backupPlan = value; }
        }

        // Check to see if BackupPlan property is set
        internal bool IsSetBackupPlan()
        {
            return this._backupPlan != null;
        }

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// The ID of the backup plan.
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

    }
}