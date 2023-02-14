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
    /// Container for the parameters to the CreateBackupPlan operation.
    /// Creates a backup plan using a backup plan name and backup rules. A backup plan is
    /// a document that contains information that Backup uses to schedule tasks that create
    /// recovery points for resources.
    /// 
    ///  
    /// <para>
    /// If you call <code>CreateBackupPlan</code> with a plan that already exists, you receive
    /// an <code>AlreadyExistsException</code> exception.
    /// </para>
    /// </summary>
    public partial class CreateBackupPlanRequest : AmazonBackupRequest
    {
        private BackupPlanInput _backupPlan;
        private Dictionary<string, string> _backupPlanTags = new Dictionary<string, string>();
        private string _creatorRequestId;

        /// <summary>
        /// Gets and sets the property BackupPlan. 
        /// <para>
        /// Specifies the body of a backup plan. Includes a <code>BackupPlanName</code> and one
        /// or more sets of <code>Rules</code>.
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
        /// Gets and sets the property BackupPlanTags. 
        /// <para>
        /// To help organize your resources, you can assign your own metadata to the resources
        /// that you create. Each tag is a key-value pair. The specified tags are assigned to
        /// all backups created with this plan.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> BackupPlanTags
        {
            get { return this._backupPlanTags; }
            set { this._backupPlanTags = value; }
        }

        // Check to see if BackupPlanTags property is set
        internal bool IsSetBackupPlanTags()
        {
            return this._backupPlanTags != null && this._backupPlanTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// Identifies the request and allows failed requests to be retried without the risk of
        /// running the operation twice. If the request includes a <code>CreatorRequestId</code>
        /// that matches an existing backup plan, that plan is returned. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

    }
}