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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The destination information for the metadata table configuration. The destination
    /// table bucket must be in the same Region and Amazon Web Services account as the general
    /// purpose bucket. The specified metadata table name must be unique within the <c>aws_s3_metadata</c>
    /// namespace in the destination table bucket.
    /// </summary>
    public partial class S3TablesDestinationResult
    {
        private string _tableArn;
        private string _tableBucketArn;
        private string _tableName;
        private string _tableNamespace;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the metadata table in the metadata table configuration.
        /// The specified metadata table name must be unique within the <c>aws_s3_metadata</c>
        /// namespace in the destination table bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableBucketArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the table bucket that's specified as the destination
        /// in the metadata table configuration. The destination table bucket must be in the same
        /// Region and Amazon Web Services account as the general purpose bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableBucketArn
        {
            get { return this._tableBucketArn; }
            set { this._tableBucketArn = value; }
        }

        // Check to see if TableBucketArn property is set
        internal bool IsSetTableBucketArn()
        {
            return this._tableBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The name for the metadata table in your metadata table configuration. The specified
        /// metadata table name must be unique within the <c>aws_s3_metadata</c> namespace in
        /// the destination table bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableNamespace. 
        /// <para>
        ///  The table bucket namespace for the metadata table in your metadata table configuration.
        /// This value is always <c>aws_s3_metadata</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableNamespace
        {
            get { return this._tableNamespace; }
            set { this._tableNamespace = value; }
        }

        // Check to see if TableNamespace property is set
        internal bool IsSetTableNamespace()
        {
            return this._tableNamespace != null;
        }

    }
}