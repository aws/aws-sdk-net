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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Backup backup plan and an array of <c>BackupRule</c> objects,
    /// each of which specifies a backup rule.
    /// </summary>
    public partial class AwsBackupBackupPlanDetails
    {
        /// <summary>
        /// Gets and sets the property BackupPlan. 
        /// <para>
        /// Uniquely identifies the backup plan to be associated with the selection of resources.
        /// 
        /// </para>
        /// </summary>
        public AwsBackupBackupPlanBackupPlanDetails BackupPlan { get; set; }

        /// <summary>
        /// Checks to see if the BackupPlan property is set.
        /// </summary>
        internal bool IsSetBackupPlan() => this.BackupPlan != null;

        /// <summary>
        /// Gets and sets the property BackupPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the backup plan. 
        /// </para>
        /// </summary>
        public string BackupPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupPlanArn property is set.
        /// </summary>
        internal bool IsSetBackupPlanArn() => this.BackupPlanArn != null;

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// A unique ID for the backup plan. 
        /// </para>
        /// </summary>
        public string BackupPlanId { get; set; }

        /// <summary>
        /// Checks to see if the BackupPlanId property is set.
        /// </summary>
        internal bool IsSetBackupPlanId() => this.BackupPlanId != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Unique, randomly generated, Unicode, UTF-8 encoded strings. Version IDs cannot be
        /// edited. 
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
