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
    /// Contains details about a table.
    /// </summary>
    public partial class TableSummary
    {
        private DateTime? _createdAt;
        private DateTime? _modifiedAt;
        private string _name;
        private List<string> _awsNamespace = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _namespaceId;
        private string _tablearn;
        private string _tableBucketId;
        private TableType _type;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the table was created at.
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the table was last modified at.
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
        /// The name of the namespace.
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
        /// The unique identifier for the namespace that contains this table.
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
        /// The unique identifier for the table bucket that contains this table.
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

    }
}