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
    /// Container for the parameters to the ListTables operation.
    /// List tables in the given table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
    /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3tables:ListTables</c> permission to use this operation. 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class ListTablesRequest : AmazonS3TablesRequest
    {
        private string _continuationToken;
        private int? _maxTables;
        private string _awsNamespace;
        private string _prefix;
        private string _tableBucketARN;

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <c>ContinuationToken</c> indicates to Amazon S3 that the list is being continued
        /// on this bucket with a token. <c>ContinuationToken</c> is obfuscated and is not a real
        /// key. You can use this <c>ContinuationToken</c> for pagination of the list results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTables. 
        /// <para>
        /// The maximum number of tables to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxTables
        {
            get { return this._maxTables; }
            set { this._maxTables = value; }
        }

        // Check to see if MaxTables property is set
        internal bool IsSetMaxTables()
        {
            return this._maxTables.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the tables.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the tables.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon resource Name (ARN) of the table bucket.
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

    }
}