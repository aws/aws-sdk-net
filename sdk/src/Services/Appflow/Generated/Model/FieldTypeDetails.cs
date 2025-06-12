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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains details regarding the supported field type and the operators that can be
    /// applied for filtering.
    /// </summary>
    public partial class FieldTypeDetails
    {
        private Range _fieldLengthRange;
        private string _fieldType;
        private Range _fieldValueRange;
        private List<string> _filterOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _supportedDateFormat;
        private List<string> _supportedValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _valueRegexPattern;

        /// <summary>
        /// Gets and sets the property FieldLengthRange. 
        /// <para>
        /// This is the allowable length range for this field's value.
        /// </para>
        /// </summary>
        public Range FieldLengthRange
        {
            get { return this._fieldLengthRange; }
            set { this._fieldLengthRange = value; }
        }

        // Check to see if FieldLengthRange property is set
        internal bool IsSetFieldLengthRange()
        {
            return this._fieldLengthRange != null;
        }

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        ///  The type of field, such as string, integer, date, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FieldType
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
        /// Gets and sets the property FieldValueRange. 
        /// <para>
        /// The range of values this field can hold.
        /// </para>
        /// </summary>
        public Range FieldValueRange
        {
            get { return this._fieldValueRange; }
            set { this._fieldValueRange = value; }
        }

        // Check to see if FieldValueRange property is set
        internal bool IsSetFieldValueRange()
        {
            return this._fieldValueRange != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOperators. 
        /// <para>
        ///  The list of operators supported by a field. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> FilterOperators
        {
            get { return this._filterOperators; }
            set { this._filterOperators = value; }
        }

        // Check to see if FilterOperators property is set
        internal bool IsSetFilterOperators()
        {
            return this._filterOperators != null && (this._filterOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedDateFormat. 
        /// <para>
        /// The date format that the field supports.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string SupportedDateFormat
        {
            get { return this._supportedDateFormat; }
            set { this._supportedDateFormat = value; }
        }

        // Check to see if SupportedDateFormat property is set
        internal bool IsSetSupportedDateFormat()
        {
            return this._supportedDateFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedValues. 
        /// <para>
        ///  The list of values that a field can contain. For example, a Boolean <c>fieldType</c>
        /// can have two values: "true" and "false". 
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

        /// <summary>
        /// Gets and sets the property ValueRegexPattern. 
        /// <para>
        /// The regular expression pattern for the field name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ValueRegexPattern
        {
            get { return this._valueRegexPattern; }
            set { this._valueRegexPattern = value; }
        }

        // Check to see if ValueRegexPattern property is set
        internal bool IsSetValueRegexPattern()
        {
            return this._valueRegexPattern != null;
        }

    }
}