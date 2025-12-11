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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Represents an attribute (column) in a data table. Attributes define the schema and
    /// validation rules for values that can be stored in the table. They specify the data
    /// type, constraints, and whether the attribute is used as a primary key for record identification.
    /// </summary>
    public partial class DataTableAttribute
    {
        private string _attributeId;
        private string _dataTableArn;
        private string _dataTableId;
        private string _description;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private DataTableLockVersion _lockVersion;
        private string _name;
        private bool? _primary;
        private Validation _validation;
        private DataTableAttributeValueType _valueType;
        private string _version;

        /// <summary>
        /// Gets and sets the property AttributeId. 
        /// <para>
        /// The unique identifier for the attribute within the data table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AttributeId
        {
            get { return this._attributeId; }
            set { this._attributeId = value; }
        }

        // Check to see if AttributeId property is set
        internal bool IsSetAttributeId()
        {
            return this._attributeId != null;
        }

        /// <summary>
        /// Gets and sets the property DataTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data table that contains this attribute.
        /// </para>
        /// </summary>
        public string DataTableArn
        {
            get { return this._dataTableArn; }
            set { this._dataTableArn = value; }
        }

        // Check to see if DataTableArn property is set
        internal bool IsSetDataTableArn()
        {
            return this._dataTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier of the data table that contains this attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataTableId
        {
            get { return this._dataTableId; }
            set { this._dataTableId = value; }
        }

        // Check to see if DataTableId property is set
        internal bool IsSetDataTableId()
        {
            return this._dataTableId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description explaining the purpose and usage of this attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The AWS region where this attribute was last modified, used for region replication.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this attribute was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The lock version for this attribute, used for optimistic locking to prevent concurrent
        /// modification conflicts.
        /// </para>
        /// </summary>
        public DataTableLockVersion LockVersion
        {
            get { return this._lockVersion; }
            set { this._lockVersion = value; }
        }

        // Check to see if LockVersion property is set
        internal bool IsSetLockVersion()
        {
            return this._lockVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the attribute. Must be unique within the data table and
        /// conform to Connect naming standards.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
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
        /// Gets and sets the property Primary. 
        /// <para>
        /// Boolean indicating whether this attribute is used as a primary key for record identification.
        /// Primary attributes must have unique value combinations and cannot contain expressions.
        /// </para>
        /// </summary>
        public bool? Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// The validation rules applied to values of this attribute. Based on JSON Schema Draft
        /// 2020-12 with additional Connect-specific validations for data integrity.
        /// </para>
        /// </summary>
        public Validation Validation
        {
            get { return this._validation; }
            set { this._validation = value; }
        }

        // Check to see if Validation property is set
        internal bool IsSetValidation()
        {
            return this._validation != null;
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The type of value allowed for this attribute. Must be one of TEXT, TEXT_LIST, NUMBER,
        /// NUMBER_LIST, or BOOLEAN. Determines how values are validated and processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataTableAttributeValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version identifier for this attribute, used for versioning and change tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}