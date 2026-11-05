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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the SyncTableMigration operation. Migrates the changes
    /// in the source table since the previous start or sync, such as added and deleted source
    /// objects, into the destination table. The sync runs asynchronously: this operation
    /// returns the migration ID of the sync and its initial state, and you track progress
    /// with <c>GetTableMigration</c>. <para> A sync uses the source, destination and data
    /// migration settings of the table's migration, and plans the work and writes its reports
    /// in the same way as <c>StartTableMigration</c>. You can sync after a start or sync
    /// that succeeded, failed or was cancelled, if an earlier start or sync of the table
    /// has a valid plan (<c>hasValidPlan</c>). You can't sync a table while a start or sync
    /// is in progress for it, and you can sync a table until you call <c>CompleteTableMigration</c>
    /// for it. If a source object that an earlier migration migrated has since been overwritten,
    /// the sync fails. </para> <dl> <dt>Permissions</dt> <dd> <ul> <li> <para> You must have
    /// the <c>s3tables:SyncTableMigration</c> permission to use this operation. </para> </li>
    /// <li> <para> You must have the <c>iam:PassRole</c> permission on the role that you
    /// specify in <c>roleARN</c>, with a condition that allows passing it to <c>migration.s3tables.amazonaws.com</c>.
    /// The associated resource is the table. </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class SyncTableMigrationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property MigrationOutput. 
        /// <para>
        /// The bucket and prefixes that the sync writes its reports to. The bucket must be a
        /// general purpose bucket in your account and in the same Region as the table bucket,
        /// and the migration role must be able to write objects to it. Otherwise, the migration
        /// fails when it writes its first report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationOutputConfiguration MigrationOutput { get; set; }

        /// <summary>
        /// Checks to see if the MigrationOutput property is set.
        /// </summary>
        internal bool IsSetMigrationOutput() => this.MigrationOutput != null;

        /// <summary>
        /// Gets and sets the property ReviewMigrationPlan. 
        /// <para>
        /// Specifies whether the sync waits in the <c>pendingReview</c> state, so that you can
        /// review the compatibility reports before it migrates any data. If <c>true</c>, the
        /// migration continues when you call <c>UpdateTableMigration</c> with <c>requestedState</c>
        /// set to <c>queued</c>. If you don't continue or cancel the migration within 30 days,
        /// the migration fails. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReviewMigrationPlan { get; set; }

        /// <summary>
        /// Checks to see if the ReviewMigrationPlan property is set.
        /// </summary>
        internal bool IsSetReviewMigrationPlan() => this.ReviewMigrationPlan.HasValue;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the sync uses to read the source
        /// table and its data and to write the destination table and the reports. The role must
        /// be in your account, and its trust policy must allow <c>migration.s3tables.amazonaws.com</c>
        /// to assume it. You can limit the trust policy to the destination table bucket with
        /// the <c>aws:SourceArn</c> and <c>aws:SourceAccount</c> condition keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination table to sync. The table must have
        /// a migration, and you must not have called <c>CompleteTableMigration</c> for it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TableARN { get; set; }

        /// <summary>
        /// Checks to see if the TableARN property is set.
        /// </summary>
        internal bool IsSetTableARN() => this.TableARN != null;
    }
}
