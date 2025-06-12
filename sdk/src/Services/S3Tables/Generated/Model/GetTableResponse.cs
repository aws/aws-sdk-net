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
    /// This is the response object from the GetTable operation.
    /// </summary>
    public partial class GetTableResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private OpenTableFormat _format;
        private string _managedByService;
        private string _metadataLocation;
        private DateTime? _modifiedAt;
        private string _modifiedBy;
        private string _name;
        private List<string> _awsNamespace = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _namespaceId;
        private string _ownerAccountId;
        private string _tablearn;
        private string _tableBucketId;
        private TableType _type;
        private string _versionToken;
        private string _warehouseLocation;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the table bucket was created at.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The ID of the account that created the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the table.
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
        /// Gets and sets the property ManagedByService. 
        /// <para>
        /// The service that manages the table.
        /// </para>
        /// </summary>
        public string ManagedByService
        {
            get { return this._managedByService; }
            set { this._managedByService = value; }
        }

        // Check to see if ManagedByService property is set
        internal bool IsSetManagedByService()
        {
            return this._managedByService != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataLocation. 
        /// <para>
        /// The metadata location of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string MetadataLocation
        {
            get { return this._metadataLocation; }
            set { this._metadataLocation = value; }
        }

        // Check to see if MetadataLocation property is set
        internal bool IsSetMetadataLocation()
        {
            return this._metadataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the table was last modified on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedBy. 
        /// <para>
        /// The ID of the account that last modified the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string ModifiedBy
        {
            get { return this._modifiedBy; }
            set { this._modifiedBy = value; }
        }

        // Check to see if ModifiedBy property is set
        internal bool IsSetModifiedBy()
        {
            return this._modifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table.
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
        /// The namespace associated with the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null && (this._awsNamespace.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The unique identifier of the namespace containing this table.
        /// </para>
        /// </summary>
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the account that owns the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TableARN
        {
            get { return this._tablearn; }
            set { this._tablearn = value; }
        }

        // Check to see if TableARN property is set
        internal bool IsSetTableARN()
        {
            return this._tablearn != null;
        }

        /// <summary>
        /// Gets and sets the property TableBucketId. 
        /// <para>
        /// The unique identifier of the table bucket containing this table.
        /// </para>
        /// </summary>
        public string TableBucketId
        {
            get { return this._tableBucketId; }
            set { this._tableBucketId = value; }
        }

        // Check to see if TableBucketId property is set
        internal bool IsSetTableBucketId()
        {
            return this._tableBucketId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// The version token of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property WarehouseLocation. 
        /// <para>
        /// The warehouse location of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string WarehouseLocation
        {
            get { return this._warehouseLocation; }
            set { this._warehouseLocation = value; }
        }

        // Check to see if WarehouseLocation property is set
        internal bool IsSetWarehouseLocation()
        {
            return this._warehouseLocation != null;
        }

    }
}