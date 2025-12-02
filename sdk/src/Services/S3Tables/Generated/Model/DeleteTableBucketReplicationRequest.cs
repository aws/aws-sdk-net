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
    /// Container for the parameters to the DeleteTableBucketReplication operation.
    /// Deletes the replication configuration for a table bucket. After deletion, new table
    /// updates will no longer be replicated to destination buckets, though existing replicated
    /// tables will remain in destination buckets.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3tables:DeleteTableBucketReplication</c> permission to use this
    /// operation.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class DeleteTableBucketReplicationRequest : AmazonS3TablesRequest
    {
        private string _tableBucketARN;
        private string _versionToken;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket.
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
        /// ensure you're deleting the expected version of the configuration.
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