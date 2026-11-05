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
    /// Container for the parameters to the StartTableMigration operation. Starts migrating
    /// an Amazon Web Services Glue Data Catalog table into a new table in a table bucket.
    /// The migration runs asynchronously: this operation returns the migration ID and its
    /// initial state, and you track progress with <c>GetTableMigration</c>. <para> The namespace
    /// must already exist, and a table with the specified name must not. The migration creates
    /// the table during planning and commits data to it as it runs. Until you call <c>CompleteTableMigration</c>,
    /// you can read the table but you can't write to it. If the migration fails or is cancelled,
    /// the table and the data already committed to it remain. </para> <para> The migration
    /// first checks the source and the destination, and writes the table compatibility and
    /// object compatibility reports to the bucket that you specify in <c>migrationOutput</c>.
    /// If you set <c>reviewMigrationPlan</c> to <c>true</c>, the migration waits in the <c>pendingReview</c>
    /// state so that you can review the reports, and continues only when you call <c>UpdateTableMigration</c>
    /// with <c>requestedState</c> set to <c>queued</c>. If you don't continue or cancel the
    /// migration within 30 days, the migration fails. Otherwise it continues to migrate the
    /// data, and writes the object migration report when the migration ends. If planning
    /// fails, the migration writes no object migration report. </para> <dl> <dt>Permissions</dt>
    /// <dd> <ul> <li> <para> You must have the <c>s3tables:StartTableMigration</c> permission
    /// to use this operation. </para> </li> <li> <para> You must have the <c>iam:PassRole</c>
    /// permission on the role that you specify in <c>roleARN</c>, with a condition that allows
    /// passing it to <c>migration.s3tables.amazonaws.com</c>. The associated resource is
    /// the table bucket. </para> </li> <li> <para> If <c>destinationTable</c> specifies SSE-KMS
    /// encryption, you must have the <c>kms:DescribeKey</c> and <c>kms:GenerateDataKey</c>
    /// permissions on the KMS key. You must also grant the S3 Tables maintenance principal
    /// access to the key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
    /// requirements for S3 Tables SSE-KMS encryption</a>. </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class StartTableMigrationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property DataMigration. 
        /// <para>
        /// The maintenance settings and migration policies for the destination table.
        /// </para>
        /// </summary>
        public DataMigrationSettings DataMigration { get; set; }

        /// <summary>
        /// Checks to see if the DataMigration property is set.
        /// </summary>
        internal bool IsSetDataMigration() => this.DataMigration != null;

        /// <summary>
        /// Gets and sets the property DestinationTable. 
        /// <para>
        /// The table to create and migrate the source into.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationTable DestinationTable { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTable property is set.
        /// </summary>
        internal bool IsSetDestinationTable() => this.DestinationTable != null;

        /// <summary>
        /// Gets and sets the property MigrationOutput. 
        /// <para>
        /// The bucket and prefixes that the migration writes its reports to. The bucket must
        /// be a general purpose bucket in your account and in the same Region as the table bucket,
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
        /// Specifies whether the migration waits in the <c>pendingReview</c> state, so that you
        /// can review the compatibility reports before it migrates any data. If <c>true</c>,
        /// the migration continues when you call <c>UpdateTableMigration</c> with <c>requestedState</c>
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
        /// The Amazon Resource Name (ARN) of the IAM role that the migration uses to read the
        /// source table and its data and to write the destination table and the reports. The
        /// role must be in your account, and its trust policy must allow <c>migration.s3tables.amazonaws.com</c>
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The source table to migrate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceConfiguration Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the source. It must match the member that you set in <c>source</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
