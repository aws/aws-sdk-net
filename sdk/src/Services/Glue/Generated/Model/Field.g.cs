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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The <c>Field</c> object has information about the different properties associated
    /// with a field in the connector.
    /// </summary>
    public partial class Field
    {
        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// Optional map of keys which may be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomProperties property is set.
        /// </summary>
        internal bool IsSetCustomProperties() => this.CustomProperties != null && (this.CustomProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the field.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// A unique identifier for the field.
        /// </para>
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        /// The type of data in the field.
        /// </para>
        /// </summary>
        public FieldDataType FieldType { get; set; }

        /// <summary>
        /// Checks to see if the FieldType property is set.
        /// </summary>
        internal bool IsSetFieldType() => this.FieldType != null;

        /// <summary>
        /// Gets and sets the property IsCreateable. 
        /// <para>
        /// Indicates whether this field can be created as part of a destination write.
        /// </para>
        /// </summary>
        public bool? IsCreateable { get; set; }

        /// <summary>
        /// Checks to see if the IsCreateable property is set.
        /// </summary>
        internal bool IsSetIsCreateable() => this.IsCreateable.HasValue;

        /// <summary>
        /// Gets and sets the property IsDefaultOnCreate. 
        /// <para>
        /// Indicates whether this field is populated automatically when the object is created,
        /// such as a created at timestamp.
        /// </para>
        /// </summary>
        public bool? IsDefaultOnCreate { get; set; }

        /// <summary>
        /// Checks to see if the IsDefaultOnCreate property is set.
        /// </summary>
        internal bool IsSetIsDefaultOnCreate() => this.IsDefaultOnCreate.HasValue;

        /// <summary>
        /// Gets and sets the property IsFilterable. 
        /// <para>
        ///  Indicates whether this field can used in a filter clause (<c>WHERE</c> clause) of
        /// a SQL statement when querying data. 
        /// </para>
        /// </summary>
        public bool? IsFilterable { get; set; }

        /// <summary>
        /// Checks to see if the IsFilterable property is set.
        /// </summary>
        internal bool IsSetIsFilterable() => this.IsFilterable.HasValue;

        /// <summary>
        /// Gets and sets the property IsNullable. 
        /// <para>
        /// Indicates whether this field can be nullable or not.
        /// </para>
        /// </summary>
        public bool? IsNullable { get; set; }

        /// <summary>
        /// Checks to see if the IsNullable property is set.
        /// </summary>
        internal bool IsSetIsNullable() => this.IsNullable.HasValue;

        /// <summary>
        /// Gets and sets the property IsPartitionable. 
        /// <para>
        /// Indicates whether a given field can be used in partitioning the query made to SaaS.
        /// </para>
        /// </summary>
        public bool? IsPartitionable { get; set; }

        /// <summary>
        /// Checks to see if the IsPartitionable property is set.
        /// </summary>
        internal bool IsSetIsPartitionable() => this.IsPartitionable.HasValue;

        /// <summary>
        /// Gets and sets the property IsPrimaryKey. 
        /// <para>
        /// Indicates whether this field can used as a primary key for the given entity.
        /// </para>
        /// </summary>
        public bool? IsPrimaryKey { get; set; }

        /// <summary>
        /// Checks to see if the IsPrimaryKey property is set.
        /// </summary>
        internal bool IsSetIsPrimaryKey() => this.IsPrimaryKey.HasValue;

        /// <summary>
        /// Gets and sets the property IsRetrievable. 
        /// <para>
        /// Indicates whether this field can be added in Select clause of SQL query or whether
        /// it is retrievable or not.
        /// </para>
        /// </summary>
        public bool? IsRetrievable { get; set; }

        /// <summary>
        /// Checks to see if the IsRetrievable property is set.
        /// </summary>
        internal bool IsSetIsRetrievable() => this.IsRetrievable.HasValue;

        /// <summary>
        /// Gets and sets the property IsUpdateable. 
        /// <para>
        /// Indicates whether this field can be updated as part of a destination write.
        /// </para>
        /// </summary>
        public bool? IsUpdateable { get; set; }

        /// <summary>
        /// Checks to see if the IsUpdateable property is set.
        /// </summary>
        internal bool IsSetIsUpdateable() => this.IsUpdateable.HasValue;

        /// <summary>
        /// Gets and sets the property IsUpsertable. 
        /// <para>
        /// Indicates whether this field can be upserted as part of a destination write.
        /// </para>
        /// </summary>
        public bool? IsUpsertable { get; set; }

        /// <summary>
        /// Checks to see if the IsUpsertable property is set.
        /// </summary>
        internal bool IsSetIsUpsertable() => this.IsUpsertable.HasValue;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A readable label used for the field.
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property NativeDataType. 
        /// <para>
        /// The data type returned by the SaaS API, such as “picklist” or “textarea” from Salesforce.
        /// </para>
        /// </summary>
        public string NativeDataType { get; set; }

        /// <summary>
        /// Checks to see if the NativeDataType property is set.
        /// </summary>
        internal bool IsSetNativeDataType() => this.NativeDataType != null;

        /// <summary>
        /// Gets and sets the property ParentField. 
        /// <para>
        /// A parent field name for a nested field.
        /// </para>
        /// </summary>
        public string ParentField { get; set; }

        /// <summary>
        /// Checks to see if the ParentField property is set.
        /// </summary>
        internal bool IsSetParentField() => this.ParentField != null;

        /// <summary>
        /// Gets and sets the property SupportedFilterOperators. 
        /// <para>
        /// Indicates the support filter operators for this field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedFilterOperators { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedFilterOperators property is set.
        /// </summary>
        internal bool IsSetSupportedFilterOperators() => this.SupportedFilterOperators != null && (this.SupportedFilterOperators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedValues. 
        /// <para>
        /// A list of supported values for the field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedValues property is set.
        /// </summary>
        internal bool IsSetSupportedValues() => this.SupportedValues != null && (this.SupportedValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
