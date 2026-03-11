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
    /// A data table evaluated value.
    /// </summary>
    public partial class DataTableEvaluatedValue
    {
        private string _attributeName;
        private bool? _error;
        private string _evaluatedValue;
        private bool? _found;
        private List<PrimaryValue> _primaryValues = AWSConfigs.InitializeCollections ? new List<PrimaryValue>() : null;
        private string _recordId;
        private DataTableAttributeValueType _valueType;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The value's attribute name.
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
        /// Gets and sets the property Error. 
        /// <para>
        /// The value's error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluatedValue. 
        /// <para>
        /// The value's evaluated value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatedValue
        {
            get { return this._evaluatedValue; }
            set { this._evaluatedValue = value; }
        }

        // Check to see if EvaluatedValue property is set
        internal bool IsSetEvaluatedValue()
        {
            return this._evaluatedValue != null;
        }

        /// <summary>
        /// Gets and sets the property Found. 
        /// <para>
        /// The value's found.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Found
        {
            get { return this._found; }
            set { this._found = value; }
        }

        // Check to see if Found property is set
        internal bool IsSetFound()
        {
            return this._found.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The value's primary values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PrimaryValue> PrimaryValues
        {
            get { return this._primaryValues; }
            set { this._primaryValues = value; }
        }

        // Check to see if PrimaryValues property is set
        internal bool IsSetPrimaryValues()
        {
            return this._primaryValues != null && (this._primaryValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The value's record ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The value's value type.
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