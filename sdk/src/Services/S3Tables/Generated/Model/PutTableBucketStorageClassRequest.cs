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
    /// Container for the parameters to the PutTableBucketStorageClass operation.
    /// Sets or updates the storage class configuration for a table bucket. This configuration
    /// serves as the default storage class for all new tables created in the bucket, allowing
    /// you to optimize storage costs at the bucket level.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3tables:PutTableBucketStorageClass</c> permission to use this
    /// operation.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class PutTableBucketStorageClassRequest : AmazonS3TablesRequest
    {
        private StorageClassConfiguration _storageClassConfiguration;
        private string _tableBucketARN;

        /// <summary>
        /// Gets and sets the property StorageClassConfiguration. 
        /// <para>
        /// The storage class configuration to apply to the table bucket. This configuration will
        /// serve as the default for new tables created in this bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageClassConfiguration StorageClassConfiguration
        {
            get { return this._storageClassConfiguration; }
            set { this._storageClassConfiguration = value; }
        }

        // Check to see if StorageClassConfiguration property is set
        internal bool IsSetStorageClassConfiguration()
        {
            return this._storageClassConfiguration != null;
        }

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

    }
}