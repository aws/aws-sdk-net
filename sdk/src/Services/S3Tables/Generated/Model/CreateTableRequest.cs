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
    /// Container for the parameters to the CreateTable operation.
    /// Creates a new table associated with the given namespace in a table bucket. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-create.html">Creating
    /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    /// You must have the <c>s3tables:CreateTable</c> permission to use this operation. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use this operation with the optional <c>metadata</c> request parameter you
    /// must have the <c>s3tables:PutTableData</c> permission. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use this operation with the optional <c>encryptionConfiguration</c> request
    /// parameter you must have the <c>s3tables:PutTableEncryption</c> permission. 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Additionally, If you choose SSE-KMS encryption you must grant the S3 Tables maintenance
    /// principal access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
    /// requirements for S3 Tables SSE-KMS encryption</a>. 
    /// </para>
    ///  </note> </dd> </dl>
    /// </summary>
    public partial class CreateTableRequest : AmazonS3TablesRequest
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private OpenTableFormat _format;
        private TableMetadata _metadata;
        private string _name;
        private string _awsNamespace;
        private string _tableBucketARN;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration to use for the table. This configuration specifies the
        /// encryption algorithm and, if using SSE-KMS, the KMS key to use for encrypting the
        /// table. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose SSE-KMS encryption you must grant the S3 Tables maintenance principal
        /// access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format for the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenTableFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the table.
        /// </para>
        /// </summary>
        public TableMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to associated with the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket to create the table in.
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