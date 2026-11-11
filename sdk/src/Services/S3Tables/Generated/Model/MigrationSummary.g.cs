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
    /// A summary of a migration.
    /// </summary>
    public partial class MigrationSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the migration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property HasValidPlan. 
        /// <para>
        /// A Boolean value that specifies whether planning produced a plan that the migration
        /// can run. If planning hasn't finished, this value isn't returned.
        /// </para>
        /// </summary>
        public bool? HasValidPlan { get; set; }

        /// <summary>
        /// Checks to see if the HasValidPlan property is set.
        /// </summary>
        internal bool IsSetHasValidPlan() => this.HasValidPlan.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The ID of the migration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string MigrationId { get; set; }

        /// <summary>
        /// Checks to see if the MigrationId property is set.
        /// </summary>
        internal bool IsSetMigrationId() => this.MigrationId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the destination table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the destination table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the migration. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>new</c> - S3 Tables accepted the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>planning</c> - The migration is checking the source table, its objects and the
        /// destination for compatibility, and writing the compatibility reports.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pendingReview</c> - Planning finished, and the migration waits for you to continue
        /// or cancel it with <c>UpdateTableMigration</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>queued</c> - The migration is waiting to start migrating data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>migrating</c> - The migration is running the plan from the <c>planning</c> state:
        /// it copies data and commits it to the destination table. A migration reaches this state
        /// only if <c>hasValidPlan</c> is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>succeeded</c> - Every planned object migrated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - The migration failed. Check <c>failureReason</c> for the cause.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelling</c> - You cancelled the migration, and it is finishing the work in
        /// progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelled</c> - The migration is cancelled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateUpdatedAt. 
        /// <para>
        /// The date and time that the migration's state last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StateUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the StateUpdatedAt property is set.
        /// </summary>
        internal bool IsSetStateUpdatedAt() => this.StateUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination table, once the migration creates
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TableARN { get; set; }

        /// <summary>
        /// Checks to see if the TableARN property is set.
        /// </summary>
        internal bool IsSetTableARN() => this.TableARN != null;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket that contains the destination table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the migration. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>start</c> - A migration that <c>StartTableMigration</c> started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sync</c> - A migration that <c>SyncTableMigration</c> started.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
