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
    /// Container for the parameters to the UpdateTableMigration operation. Requests a state
    /// change for a migration. Identify the migration by its <c>migrationId</c> or by the
    /// <c>tableARN</c> of its destination table. <para> Set <c>requestedState</c> to <c>queued</c>
    /// to continue a migration in the <c>pendingReview</c> state; the migration moves to
    /// <c>queued</c> or <c>migrating</c>. Set it to <c>cancelled</c> to cancel a migration
    /// in the <c>new</c>, <c>planning</c>, <c>pendingReview</c>, <c>queued</c> or <c>migrating</c>
    /// state; the migration moves to <c>cancelling</c>, finishes the work in progress, and
    /// then ends in the <c>cancelled</c> state, or in the <c>failed</c> state if any objects
    /// failed to migrate. Data that the migration already committed stays in the destination
    /// table. </para> <dl> <dt>Permissions</dt> <dd> <ul> <li> <para> You must have the <c>s3tables:UpdateTableMigration</c>
    /// permission to use this operation. </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class UpdateTableMigrationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The ID of the migration to update. Specify either <c>migrationId</c> or <c>tableARN</c>,
        /// not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string MigrationId { get; set; }

        /// <summary>
        /// Checks to see if the MigrationId property is set.
        /// </summary>
        internal bool IsSetMigrationId() => this.MigrationId != null;

        /// <summary>
        /// Gets and sets the property RequestedState. 
        /// <para>
        /// The state to move the migration to: <c>queued</c> to continue a migration in the <c>pendingReview</c>
        /// state, or <c>cancelled</c> to cancel a migration in the <c>new</c>, <c>planning</c>,
        /// <c>pendingReview</c>, <c>queued</c> or <c>migrating</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationRequestedState RequestedState { get; set; }

        /// <summary>
        /// Checks to see if the RequestedState property is set.
        /// </summary>
        internal bool IsSetRequestedState() => this.RequestedState != null;

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination table. Updates the table's most
        /// recent migration. Until the migration creates the destination table, specify <c>migrationId</c>.
        /// Specify either <c>tableARN</c> or <c>migrationId</c>, not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TableARN { get; set; }

        /// <summary>
        /// Checks to see if the TableARN property is set.
        /// </summary>
        internal bool IsSetTableARN() => this.TableARN != null;

        /// <summary>
        /// Gets and sets the property UpdateDescription. 
        /// <para>
        /// A description of the update, up to 1,024 characters, with no control characters. <c>GetTableMigration</c>
        /// doesn't return it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UpdateDescription { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDescription property is set.
        /// </summary>
        internal bool IsSetUpdateDescription() => this.UpdateDescription != null;
    }
}
