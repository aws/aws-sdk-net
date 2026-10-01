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
    /// Container for the parameters to the CreateTable operation. Creates a new table associated
    /// with the given namespace in a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-create.html">Creating
    /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>. <dl>
    /// <dt>Permissions</dt> <dd> <ul> <li> <para> You must have the <c>s3tables:CreateTable</c>
    /// permission to use this operation. </para> </li> <li> <para> If you use this operation
    /// with the optional <c>metadata</c> request parameter you must have the <c>s3tables:PutTableData</c>
    /// permission. </para> </li> <li> <para> If you use this operation with the optional
    /// <c>encryptionConfiguration</c> request parameter you must have the <c>s3tables:PutTableEncryption</c>
    /// permission. </para> </li> <li> <para> If you use this operation with the <c>storageClassConfiguration</c>
    /// request parameter, you must have the <c>s3tables:PutTableStorageClass</c> permission.
    /// </para> </li> <li> <para> To create a table with tags, you must have the <c>s3tables:TagResource</c>
    /// permission in addition to <c>s3tables:CreateTable</c> permission. </para> </li> </ul>
    /// <note> <para> Additionally, If you choose SSE-KMS encryption you must grant the S3
    /// Tables maintenance principal access to your KMS key. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
    /// requirements for S3 Tables SSE-KMS encryption</a>. </para> </note> </dd> </dl>
    /// </summary>
    public partial class CreateTableRequest : AmazonS3TablesRequest
    {
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
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format for the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpenTableFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the table.
        /// </para>
        /// </summary>
        public TableMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to associated with the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property StorageClassConfiguration. 
        /// <para>
        /// The storage class configuration for the table. If not specified, the table inherits
        /// the storage class configuration from its table bucket. Specify this parameter to override
        /// the bucket's default storage class for this table.
        /// </para>
        /// </summary>
        public StorageClassConfiguration StorageClassConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageClassConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageClassConfiguration() => this.StorageClassConfiguration != null;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket to create the table in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of user-defined tags that you would like to apply to the table that you are
        /// creating. A tag is a key-value pair that you apply to your resources. Tags can help
        /// you organize, track costs for, and control access to resources. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html">Tagging
        /// for cost allocation or attribute-based access control (ABAC)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have the <c>s3tables:TagResource</c> permission in addition to <c>s3tables:CreateTable</c>
        /// permission to create a table with tags.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
