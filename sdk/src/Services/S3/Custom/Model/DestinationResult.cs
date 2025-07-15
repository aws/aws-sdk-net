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
    /// The destination information for the S3 Metadata configuration.
    /// </summary>
    public partial class DestinationResult
    {
        private string _tableBucketArn;
        private S3TablesBucketType _tableBucketType;
        private string _tableNamespace;

        /// <summary>
        /// Gets and sets the property TableBucketArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the table bucket where the metadata configuration
        /// is stored. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TableBucketType. 
        /// <para>
        ///  The type of the table bucket where the metadata configuration is stored. The <c>aws</c>
        /// value indicates an Amazon Web Services managed table bucket, and the <c>customer</c>
        /// value indicates a customer-managed table bucket. V2 metadata configurations are stored
        /// in Amazon Web Services managed table buckets, and V1 metadata configurations are stored
        /// in customer-managed table buckets. 
        /// </para>
        /// </summary>
        public S3TablesBucketType TableBucketType
        {
            get { return this._tableBucketType; }
            set { this._tableBucketType = value; }
        }

        // Check to see if TableBucketType property is set
        internal bool IsSetTableBucketType()
        {
            return this._tableBucketType != null;
        }

        /// <summary>
        /// Gets and sets the property TableNamespace. 
        /// <para>
        ///  The namespace in the table bucket where the metadata tables for a metadata configuration
        /// are stored. 
        /// </para>
        /// </summary>
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