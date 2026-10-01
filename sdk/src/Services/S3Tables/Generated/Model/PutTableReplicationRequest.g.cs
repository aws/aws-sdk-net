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
    /// Container for the parameters to the PutTableReplication operation. Creates or updates
    /// the replication configuration for a specific table. This operation allows you to define
    /// table-level replication independently of bucket-level replication, providing granular
    /// control over which tables are replicated and where. <dl> <dt>Permissions</dt> <dd>
    /// <ul> <li> <para> You must have the <c>s3tables:PutTableReplication</c> permission
    /// to use this operation. The IAM role specified in the configuration must have permissions
    /// to read from the source table and write to all destination tables. </para> </li> <li>
    /// <para> You must also have the following permissions: </para> <ul> <li> <para> <c>s3tables:GetTable</c>
    /// permission on the source table being replicated. </para> </li> <li> <para> <c>s3tables:CreateTable</c>
    /// permission for the destination. </para> </li> <li> <para> <c>s3tables:CreateNamespace</c>
    /// permission for the destination. </para> </li> <li> <para> <c>s3tables:GetTableMaintenanceConfig</c>
    /// permission for the source table. </para> </li> <li> <para> <c>s3tables:PutTableMaintenanceConfig</c>
    /// permission for the destination table. </para> </li> </ul> </li> <li> <para> You must
    /// have <c>iam:PassRole</c> permission with condition allowing roles to be passed to
    /// <c>replication.s3tables.amazonaws.com</c>. </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class PutTableReplicationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The replication configuration to apply to the table, including the IAM role and replication
        /// rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableReplicationConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// A version token from a previous GetTableReplication call. Use this token to ensure
        /// you're updating the expected version of the configuration.
        /// </para>
        /// </summary>
        public string VersionToken { get; set; }

        /// <summary>
        /// Checks to see if the VersionToken property is set.
        /// </summary>
        internal bool IsSetVersionToken() => this.VersionToken != null;
    }
}
