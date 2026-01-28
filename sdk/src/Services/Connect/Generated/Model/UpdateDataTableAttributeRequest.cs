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
    /// Container for the parameters to the UpdateDataTableAttribute operation.
    /// Updates all properties for an attribute using all properties from CreateDataTableAttribute.
    /// There are no other granular update endpoints. It does not act as a patch operation
    /// - all properties must be provided. System managed attributes are not mutable by customers.
    /// Changing an attribute's validation does not invalidate existing values since validation
    /// only runs when values are created or updated.
    /// </summary>
    public partial class UpdateDataTableAttributeRequest : AmazonConnectRequest
    {
        private string _attributeName;
        private string _dataTableId;
        private string _description;
        private string _instanceId;
        private string _name;
        private bool? _primary;
        private Validation _validation;
        private DataTableAttributeValueType _valueType;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The current name of the attribute to update. Used as an identifier since attribute
        /// names can be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table. Must also accept the table ARN with or without
        /// a version alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The updated description for the attribute.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the attribute. Must conform to Connect human readable string specification
        /// and be unique within the data table.
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
        /// Whether the attribute should be treated as a primary key. Converting to primary attribute
        /// requires existing values to maintain uniqueness.
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
        /// The updated validation rules for the attribute. Changes do not affect existing values
        /// until they are modified.
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
        /// The updated value type for the attribute. When changing value types, existing values
        /// are not deleted but may return default values if incompatible.
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

    }
}