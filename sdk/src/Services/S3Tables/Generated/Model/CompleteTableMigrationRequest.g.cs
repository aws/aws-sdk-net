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
    /// Container for the parameters to the CompleteTableMigration operation. Completes the
    /// migration of a table. The table's most recent migration must be in the <c>succeeded</c>,
    /// <c>failed</c> or <c>cancelled</c> state. After you complete the migration, you can't
    /// sync the table again, and you can write to and maintain the table as you do any other
    /// table: compaction starts, and unreferenced file removal follows the table bucket's
    /// configuration. You can't undo this operation. Calling it again for the same table
    /// returns a <c>ConflictException</c>. <dl> <dt>Permissions</dt> <dd> <ul> <li> <para>
    /// You must have the <c>s3tables:CompleteTableMigration</c> permission to use this operation.
    /// </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class CompleteTableMigrationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the migrated table to complete the migration of.
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
