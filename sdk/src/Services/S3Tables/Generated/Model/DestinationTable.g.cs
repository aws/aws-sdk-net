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
    /// The table that a migration creates in a table bucket and migrates the source into.
    /// </summary>
    public partial class DestinationTable
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the table. If you don't specify one, the table uses
        /// the default encryption configuration of its table bucket. If you specify an encryption
        /// configuration, the migration role must have the <c>s3tables:PutTableEncryption</c>
        /// permission. If you choose SSE-KMS, the migration role must have the <c>kms:DescribeKey</c>,
        /// <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> permissions on the KMS key, and
        /// the S3 Tables maintenance principal must have access to it. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a>.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property IcebergSortOrder. 
        /// <para>
        /// The sort order of the rows within each data file that the migration writes. A sort
        /// order can have up to five fields, each naming a column of the schema that you specify
        /// by its field ID, so to use a sort order you must specify a schema. <c>StartTableMigration</c>
        /// rejects a field that names no column of the schema, or whose transform doesn't fit
        /// the column's type.
        /// </para>
        /// </summary>
        public IcebergSortOrder IcebergSortOrder { get; set; }

        /// <summary>
        /// Checks to see if the IcebergSortOrder property is set.
        /// </summary>
        internal bool IsSetIcebergSortOrder() => this.IcebergSortOrder != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table to create.
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
        /// The namespace to create the table in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the destination table, such as its Iceberg format version and the
        /// format of its data files.
        /// </para>
        /// </summary>
        public MigrationTableProperties Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema of the table to create. If you don't specify a schema, the migration infers
        /// it from the source table, with every column optional. A schema that you specify must
        /// include every partition column of the source table. It can leave out other columns
        /// only if <c>unmatchedSourceFieldsPolicy</c> is <c>drop</c>. A struct column must have
        /// the same fields as the source column. Column default values aren't supported. If you
        /// mark a column as required, every source object must have a value for it: an object
        /// with a null value in a required column fails to migrate. The destination table is
        /// partitioned in the same way as the source table. To specify fields in <c>icebergSortOrder</c>,
        /// you must specify a schema.
        /// </para>
        /// </summary>
        public IcebergSchemaV2 Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property StorageClassConfiguration. 
        /// <para>
        /// The storage class configuration for the table. If you don't specify one, the table
        /// inherits the storage class configuration of its table bucket. If you specify a storage
        /// class configuration, the migration role must have the <c>s3tables:PutTableStorageClass</c>
        /// permission.
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
        /// The tags to add to the table. A tag is a key-value pair that you apply to your resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html">Tagging
        /// for cost allocation or attribute-based access control (ABAC)</a>. If you specify tags,
        /// the migration role must have the <c>s3tables:TagResource</c> permission.
        /// </para>
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
