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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the PutTableBucketReplication operation.
    /// Creates or updates the replication configuration for a table bucket. This operation
    /// defines how tables in the source bucket are replicated to destination buckets. Replication
    /// helps ensure data availability and disaster recovery across regions or accounts.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    /// You must have the <c>s3tables:PutTableBucketReplication</c> permission to use this
    /// operation. The IAM role specified in the configuration must have permissions to read
    /// from the source bucket and write permissions to all destination buckets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must also have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3tables:GetTable</c> permission on the source table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:ListTables</c> permission on the bucket containing the table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:CreateTable</c> permission for the destination.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:CreateNamespace</c> permission for the destination.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:GetTableMaintenanceConfig</c> permission for the source bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3tables:PutTableMaintenanceConfig</c> permission for the destination bucket.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// You must have <c>iam:PassRole</c> permission with condition allowing roles to be passed
    /// to <c>replication.s3tables.amazonaws.com</c>.
    /// </para>
    ///  </li> </ul> </dd> </dl>
    /// </summary>
    public partial class PutTableBucketReplicationRequest : AmazonS3TablesRequest
    {
        private TableBucketReplicationConfiguration _configuration;
        private string _tableBucketARN;
        private string _versionToken;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The replication configuration to apply, including the IAM role and replication rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableBucketReplicationConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableBucketARN
        {
            get { return this._tableBucketARN; }
            set { this._tableBucketARN = value; }
        }

        // Check to see if TableBucketARN property is set
        internal bool IsSetTableBucketARN()
        {
            return this._tableBucketARN != null;
        }

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// A version token from a previous GetTableBucketReplication call. Use this token to
        /// ensure you're updating the expected version of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string VersionToken
        {
            get { return this._versionToken; }
            set { this._versionToken = value; }
        }

        // Check to see if VersionToken property is set
        internal bool IsSetVersionToken()
        {
            return this._versionToken != null;
        }

    }
}