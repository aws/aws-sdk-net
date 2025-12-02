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
    /// Container for the parameters to the CreateTableBucket operation.
    /// Creates a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-create.html">Creating
    /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    /// You must have the <c>s3tables:CreateTableBucket</c> permission to use this operation.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use this operation with the optional <c>encryptionConfiguration</c> parameter
    /// you must have the <c>s3tables:PutTableBucketEncryption</c> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use this operation with the <c>storageClassConfiguration</c> request parameter,
    /// you must have the <c>s3tables:PutTableBucketStorageClass</c> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a table bucket with tags, you must have the <c>s3tables:TagResource</c>
    /// permission in addition to <c>s3tables:CreateTableBucket</c> permission.
    /// </para>
    ///  </li> </ul> </dd> </dl>
    /// </summary>
    public partial class CreateTableBucketRequest : AmazonS3TablesRequest
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private string _name;
        private StorageClassConfiguration _storageClassConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration to use for the table bucket. This configuration specifies
        /// the default encryption settings that will be applied to all tables created in this
        /// bucket unless overridden at the table level. The configuration includes the encryption
        /// algorithm and, if using SSE-KMS, the KMS key to use.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClassConfiguration. 
        /// <para>
        /// The default storage class configuration for the table bucket. This configuration will
        /// be applied to all new tables created in this bucket unless overridden at the table
        /// level. If not specified, the service default storage class will be used.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of user-defined tags that you would like to apply to the table bucket that you
        /// are creating. A tag is a key-value pair that you apply to your resources. Tags can
        /// help you organize and control access to resources. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html">Tagging
        /// for cost allocation or attribute-based access control (ABAC)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have the <c>s3tables:TagResource</c> permission in addition to <c>s3tables:CreateTableBucket</c>
        /// permisson to create a table bucket with tags.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}