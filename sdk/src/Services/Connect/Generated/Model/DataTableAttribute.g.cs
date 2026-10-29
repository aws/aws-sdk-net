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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Represents an attribute (column) in a data table. Attributes define the schema and
    /// validation rules for values that can be stored in the table. They specify the data
    /// type, constraints, and whether the attribute is used as a primary key for record identification.
    /// </summary>
    public partial class DataTableAttribute
    {
        /// <summary>
        /// Gets and sets the property AttributeId. 
        /// <para>
        /// The unique identifier for the attribute within the data table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AttributeId { get; set; }

        /// <summary>
        /// Checks to see if the AttributeId property is set.
        /// </summary>
        internal bool IsSetAttributeId() => this.AttributeId != null;

        /// <summary>
        /// Gets and sets the property DataTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data table that contains this attribute.
        /// </para>
        /// </summary>
        public string DataTableArn { get; set; }

        /// <summary>
        /// Checks to see if the DataTableArn property is set.
        /// </summary>
        internal bool IsSetDataTableArn() => this.DataTableArn != null;

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier of the data table that contains this attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DataTableId { get; set; }

        /// <summary>
        /// Checks to see if the DataTableId property is set.
        /// </summary>
        internal bool IsSetDataTableId() => this.DataTableId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description explaining the purpose and usage of this attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this attribute was last modified, used for region
        /// replication.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this attribute was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The lock version for this attribute, used for optimistic locking to prevent concurrent
        /// modification conflicts.
        /// </para>
        /// </summary>
        public DataTableLockVersion LockVersion { get; set; }

        /// <summary>
        /// Checks to see if the LockVersion property is set.
        /// </summary>
        internal bool IsSetLockVersion() => this.LockVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the attribute. Must be unique within the data table and
        /// conform to Connect naming standards.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// Boolean indicating whether this attribute is used as a primary key for record identification.
        /// Primary attributes must have unique value combinations and cannot contain expressions.
        /// </para>
        /// </summary>
        public bool? Primary { get; set; }

        /// <summary>
        /// Checks to see if the Primary property is set.
        /// </summary>
        internal bool IsSetPrimary() => this.Primary.HasValue;

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// The validation rules applied to values of this attribute. Based on JSON Schema Draft
        /// 2020-12 with additional Connect-specific validations for data integrity.
        /// </para>
        /// </summary>
        public Validation Validation { get; set; }

        /// <summary>
        /// Checks to see if the Validation property is set.
        /// </summary>
        internal bool IsSetValidation() => this.Validation != null;

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The type of value allowed for this attribute. Must be one of TEXT, TEXT_LIST, NUMBER,
        /// NUMBER_LIST, or BOOLEAN. Determines how values are validated and processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableAttributeValueType ValueType { get; set; }

        /// <summary>
        /// Checks to see if the ValueType property is set.
        /// </summary>
        internal bool IsSetValueType() => this.ValueType != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version identifier for this attribute, used for versioning and change tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
