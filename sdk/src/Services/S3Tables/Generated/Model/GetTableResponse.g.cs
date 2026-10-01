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
    /// This is the response object from the GetTable operation.
    /// </summary>
    public partial class GetTableResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the table bucket was created at.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The ID of the account that created the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OpenTableFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property ManagedByService. 
        /// <para>
        /// The service that manages the table.
        /// </para>
        /// </summary>
        public string ManagedByService { get; set; }

        /// <summary>
        /// Checks to see if the ManagedByService property is set.
        /// </summary>
        internal bool IsSetManagedByService() => this.ManagedByService != null;

        /// <summary>
        /// Gets and sets the property ManagedTableInformation. 
        /// <para>
        /// If this table is managed by S3 Tables, contains additional information such as replication
        /// details.
        /// </para>
        /// </summary>
        public ManagedTableInformation ManagedTableInformation { get; set; }

        /// <summary>
        /// Checks to see if the ManagedTableInformation property is set.
        /// </summary>
        internal bool IsSetManagedTableInformation() => this.ManagedTableInformation != null;

        /// <summary>
        /// Gets and sets the property MetadataLocation. 
        /// <para>
        /// The metadata location of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string MetadataLocation { get; set; }

        /// <summary>
        /// Checks to see if the MetadataLocation property is set.
        /// </summary>
        internal bool IsSetMetadataLocation() => this.MetadataLocation != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the table was last modified on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedBy. 
        /// <para>
        /// The ID of the account that last modified the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedBy property is set.
        /// </summary>
        internal bool IsSetModifiedBy() => this.ModifiedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table.
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
        /// The namespace associated with the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Namespace { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null && (this.Namespace.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The unique identifier of the namespace containing this table.
        /// </para>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceId property is set.
        /// </summary>
        internal bool IsSetNamespaceId() => this.NamespaceId != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the account that owns the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TableARN { get; set; }

        /// <summary>
        /// Checks to see if the TableARN property is set.
        /// </summary>
        internal bool IsSetTableARN() => this.TableARN != null;

        /// <summary>
        /// Gets and sets the property TableBucketId. 
        /// <para>
        /// The unique identifier of the table bucket containing this table.
        /// </para>
        /// </summary>
        public string TableBucketId { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketId property is set.
        /// </summary>
        internal bool IsSetTableBucketId() => this.TableBucketId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// The version token of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string VersionToken { get; set; }

        /// <summary>
        /// Checks to see if the VersionToken property is set.
        /// </summary>
        internal bool IsSetVersionToken() => this.VersionToken != null;

        /// <summary>
        /// Gets and sets the property WarehouseLocation. 
        /// <para>
        /// The warehouse location of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// Checks to see if the WarehouseLocation property is set.
        /// </summary>
        internal bool IsSetWarehouseLocation() => this.WarehouseLocation != null;
    }
}
