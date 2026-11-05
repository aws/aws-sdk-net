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
    /// Container for the parameters to the GetTableMigration operation. Gets the details
    /// of a migration, including its state, the reason it failed, its statistics and the
    /// location of its reports. Identify the migration by its <c>migrationId</c>, or specify
    /// the <c>tableARN</c> of a destination table to get that table's most recent migration.
    /// <dl> <dt>Permissions</dt> <dd> <ul> <li> <para> You must have the <c>s3tables:GetTableMigration</c>
    /// permission to use this operation. </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class GetTableMigrationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The ID of the migration to get. Specify either <c>migrationId</c> or <c>tableARN</c>,
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
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination table. Gets the table's most recent
        /// migration. Specify either <c>tableARN</c> or <c>migrationId</c>, not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TableARN { get; set; }

        /// <summary>
        /// Checks to see if the TableARN property is set.
        /// </summary>
        internal bool IsSetTableARN() => this.TableARN != null;
    }
}
