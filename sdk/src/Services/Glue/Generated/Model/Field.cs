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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The <c>Field</c> object has information about the different properties associated
    /// with a field in the connector.
    /// </summary>
    public partial class Field
    {
        private Dictionary<string, string> _customProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _description;
        private string _fieldName;
        private FieldDataType _fieldType;
        private bool? _isCreateable;
        private bool? _isDefaultOnCreate;
        private bool? _isFilterable;
        private bool? _isNullable;
        private bool? _isPartitionable;
        private bool? _isPrimaryKey;
        private bool? _isRetrievable;
        private bool? _isUpdateable;
        private bool? _isUpsertable;
        private string _label;
        private string _nativeDataType;
        private string _parentField;
        private List<string> _supportedFilterOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// Optional map of keys which may be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomProperties
        {
            get { return this._customProperties; }
            set { this._customProperties = value; }
        }

        // Check to see if CustomProperties property is set
        internal bool IsSetCustomProperties()
        {
            return this._customProperties != null && (this._customProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the field.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FieldName. 
        /// <para>
        /// A unique identifier for the field.
        /// </para>
        /// </summary>
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        /// The type of data in the field.
        /// </para>
        /// </summary>
        public FieldDataType FieldType
        {
            get { return this._fieldType; }
            set { this._fieldType = value; }
        }

        // Check to see if FieldType property is set
        internal bool IsSetFieldType()
        {
            return this._fieldType != null;
        }

        /// <summary>
        /// Gets and sets the property IsCreateable. 
        /// <para>
        /// Indicates whether this field can be created as part of a destination write.
        /// </para>
        /// </summary>
        public bool? IsCreateable
        {
            get { return this._isCreateable; }
            set { this._isCreateable = value; }
        }

        // Check to see if IsCreateable property is set
        internal bool IsSetIsCreateable()
        {
            return this._isCreateable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDefaultOnCreate. 
        /// <para>
        /// Indicates whether this field is populated automatically when the object is created,
        /// such as a created at timestamp.
        /// </para>
        /// </summary>
        public bool? IsDefaultOnCreate
        {
            get { return this._isDefaultOnCreate; }
            set { this._isDefaultOnCreate = value; }
        }

        // Check to see if IsDefaultOnCreate property is set
        internal bool IsSetIsDefaultOnCreate()
        {
            return this._isDefaultOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsFilterable. 
        /// <para>
        ///  Indicates whether this field can used in a filter clause (<c>WHERE</c> clause) of
        /// a SQL statement when querying data. 
        /// </para>
        /// </summary>
        public bool? IsFilterable
        {
            get { return this._isFilterable; }
            set { this._isFilterable = value; }
        }

        // Check to see if IsFilterable property is set
        internal bool IsSetIsFilterable()
        {
            return this._isFilterable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNullable. 
        /// <para>
        /// Indicates whether this field can be nullable or not.
        /// </para>
        /// </summary>
        public bool? IsNullable
        {
            get { return this._isNullable; }
            set { this._isNullable = value; }
        }

        // Check to see if IsNullable property is set
        internal bool IsSetIsNullable()
        {
            return this._isNullable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPartitionable. 
        /// <para>
        /// Indicates whether a given field can be used in partitioning the query made to SaaS.
        /// </para>
        /// </summary>
        public bool? IsPartitionable
        {
            get { return this._isPartitionable; }
            set { this._isPartitionable = value; }
        }

        // Check to see if IsPartitionable property is set
        internal bool IsSetIsPartitionable()
        {
            return this._isPartitionable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPrimaryKey. 
        /// <para>
        /// Indicates whether this field can used as a primary key for the given entity.
        /// </para>
        /// </summary>
        public bool? IsPrimaryKey
        {
            get { return this._isPrimaryKey; }
            set { this._isPrimaryKey = value; }
        }

        // Check to see if IsPrimaryKey property is set
        internal bool IsSetIsPrimaryKey()
        {
            return this._isPrimaryKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRetrievable. 
        /// <para>
        /// Indicates whether this field can be added in Select clause of SQL query or whether
        /// it is retrievable or not.
        /// </para>
        /// </summary>
        public bool? IsRetrievable
        {
            get { return this._isRetrievable; }
            set { this._isRetrievable = value; }
        }

        // Check to see if IsRetrievable property is set
        internal bool IsSetIsRetrievable()
        {
            return this._isRetrievable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsUpdateable. 
        /// <para>
        /// Indicates whether this field can be updated as part of a destination write.
        /// </para>
        /// </summary>
        public bool? IsUpdateable
        {
            get { return this._isUpdateable; }
            set { this._isUpdateable = value; }
        }

        // Check to see if IsUpdateable property is set
        internal bool IsSetIsUpdateable()
        {
            return this._isUpdateable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsUpsertable. 
        /// <para>
        /// Indicates whether this field can be upserted as part of a destination write.
        /// </para>
        /// </summary>
        public bool? IsUpsertable
        {
            get { return this._isUpsertable; }
            set { this._isUpsertable = value; }
        }

        // Check to see if IsUpsertable property is set
        internal bool IsSetIsUpsertable()
        {
            return this._isUpsertable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A readable label used for the field.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property NativeDataType. 
        /// <para>
        /// The data type returned by the SaaS API, such as “picklist” or “textarea” from Salesforce.
        /// </para>
        /// </summary>
        public string NativeDataType
        {
            get { return this._nativeDataType; }
            set { this._nativeDataType = value; }
        }

        // Check to see if NativeDataType property is set
        internal bool IsSetNativeDataType()
        {
            return this._nativeDataType != null;
        }

        /// <summary>
        /// Gets and sets the property ParentField. 
        /// <para>
        /// A parent field name for a nested field.
        /// </para>
        /// </summary>
        public string ParentField
        {
            get { return this._parentField; }
            set { this._parentField = value; }
        }

        // Check to see if ParentField property is set
        internal bool IsSetParentField()
        {
            return this._parentField != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedFilterOperators. 
        /// <para>
        /// Indicates the support filter operators for this field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedFilterOperators
        {
            get { return this._supportedFilterOperators; }
            set { this._supportedFilterOperators = value; }
        }

        // Check to see if SupportedFilterOperators property is set
        internal bool IsSetSupportedFilterOperators()
        {
            return this._supportedFilterOperators != null && (this._supportedFilterOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedValues. 
        /// <para>
        /// A list of supported values for the field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedValues
        {
            get { return this._supportedValues; }
            set { this._supportedValues = value; }
        }

        // Check to see if SupportedValues property is set
        internal bool IsSetSupportedValues()
        {
            return this._supportedValues != null && (this._supportedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}