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
    /// Container for the parameters to the UpdateDataTableAttribute operation. Updates all
    /// properties for an attribute using all properties from CreateDataTableAttribute. There
    /// are no other granular update endpoints. It does not act as a patch operation - all
    /// properties must be provided. System managed attributes are not mutable by customers.
    /// Changing an attribute's validation does not invalidate existing values since validation
    /// only runs when values are created or updated.
    /// </summary>
    public partial class UpdateDataTableAttributeRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The current name of the attribute to update. Used as an identifier since attribute
        /// names can be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table. Must also accept the table ARN with or without
        /// a version alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DataTableId { get; set; }

        /// <summary>
        /// Checks to see if the DataTableId property is set.
        /// </summary>
        internal bool IsSetDataTableId() => this.DataTableId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the attribute. Must conform to Connect human readable string specification
        /// and be unique within the data table.
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
        /// Whether the attribute should be treated as a primary key. Converting to primary attribute
        /// requires existing values to maintain uniqueness.
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
        /// The updated validation rules for the attribute. Changes do not affect existing values
        /// until they are modified.
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
        /// The updated value type for the attribute. When changing value types, existing values
        /// are not deleted but may return default values if incompatible.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableAttributeValueType ValueType { get; set; }

        /// <summary>
        /// Checks to see if the ValueType property is set.
        /// </summary>
        internal bool IsSetValueType() => this.ValueType != null;
    }
}
