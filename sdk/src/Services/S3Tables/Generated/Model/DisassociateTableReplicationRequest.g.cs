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
    /// Container for the parameters to the DisassociateTableReplication operation. Disassociates
    /// a replica table from replication, making it a standalone writable table. Any in-progress
    /// replication to the table stops, and in-flight commits fail without being committed
    /// to the table. Disassociating a table from replication is permanent and can't be reversed.
    /// <para> You can only disassociate a replica table. If you call this operation on a
    /// table that isn't a replica table, including a table that you have already disassociated,
    /// the request fails. </para> <para> After you disassociate a table from replication,
    /// you can write to the table as you do any other table. <c>GetTable</c> no longer returns
    /// <c>managedByService</c> and <c>managedTableInformation</c> for the table, and <c>ListTables</c>
    /// no longer returns <c>managedByService</c> for it. On the source table, <c>GetTableReplicationStatus</c>
    /// reports a failure for this destination the next time replication to it is attempted.
    /// </para> <para> Disassociating a table from replication doesn't change its maintenance
    /// configuration. Review the maintenance settings of the table, such as compaction, after
    /// you disassociate it. </para> <dl> <dt>Permissions</dt> <dd> <para> You must have the
    /// <c>s3tables:DisassociateTableReplication</c> permission to use this operation. </para>
    /// </dd> </dl>
    /// </summary>
    public partial class DisassociateTableReplicationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replica table to disassociate from replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;
    }
}
