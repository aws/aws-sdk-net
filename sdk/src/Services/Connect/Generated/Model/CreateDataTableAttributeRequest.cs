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
    /// Container for the parameters to the CreateDataTableAttribute operation.
    /// Adds an attribute to an existing data table. Creating a new primary attribute uses
    /// the empty value for the specified value type for all existing records. This should
    /// not affect uniqueness of published data tables since the existing primary values will
    /// already be unique. Creating attributes does not create any values. System managed
    /// tables may not allow customers to create new attributes.
    /// </summary>
    public partial class CreateDataTableAttributeRequest : AmazonConnectRequest
    {
        private string _dataTableId;
        private string _description;
        private string _instanceId;
        private string _name;
        private bool? _primary;
        private Validation _validation;
        private DataTableAttributeValueType _valueType;

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table. Must also accept the table ARN with or without
        /// a version alias. If the version is provided as part of the identifier or ARN, the
        /// version must be one of the two available system managed aliases, $SAVED or $LATEST.
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
        /// An optional description for the attribute. Must conform to Connect human readable
        /// string specification and have 0-250 characters. Whitespace trimmed before persisting.
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
        /// The name for the attribute. Must conform to Connect human readable string specification
        /// and have 1-127 characters. Must not start with the reserved case insensitive values
        /// 'connect:' and 'aws:'. Whitespace trimmed before persisting. Must be unique for the
        /// data table using case-insensitive comparison.
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
        /// Optional boolean that defaults to false. Determines if the value is used to identify
        /// a record in the table. Values for primary attributes must not be expressions.
        /// </para>
        /// </summary>
        public bool Primary
        {
            get { return this._primary.GetValueOrDefault(); }
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
        /// Optional validation rules for the attribute. Borrows heavily from JSON Schema - Draft
        /// 2020-12. The maximum length of arrays within validations and depth of validations
        /// is 5. There are default limits that apply to all types. Customer specified limits
        /// in excess of the default limits are not permitted.
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
        /// The type of value allowed or the resultant type after the value's expression is evaluated.
        /// Must be one of TEXT, TEXT_LIST, NUMBER, NUMBER_LIST, and BOOLEAN.
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