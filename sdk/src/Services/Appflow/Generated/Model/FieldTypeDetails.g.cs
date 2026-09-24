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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains details regarding the supported field type and the operators that can be
    /// applied for filtering.
    /// </summary>
    public partial class FieldTypeDetails
    {
        /// <summary>
        /// Gets and sets the property FieldLengthRange. 
        /// <para>
        /// This is the allowable length range for this field's value.
        /// </para>
        /// </summary>
        public Range FieldLengthRange { get; set; }

        /// <summary>
        /// Checks to see if the FieldLengthRange property is set.
        /// </summary>
        internal bool IsSetFieldLengthRange() => this.FieldLengthRange != null;

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        ///  The type of field, such as string, integer, date, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FieldType { get; set; }

        /// <summary>
        /// Checks to see if the FieldType property is set.
        /// </summary>
        internal bool IsSetFieldType() => this.FieldType != null;

        /// <summary>
        /// Gets and sets the property FieldValueRange. 
        /// <para>
        /// The range of values this field can hold.
        /// </para>
        /// </summary>
        public Range FieldValueRange { get; set; }

        /// <summary>
        /// Checks to see if the FieldValueRange property is set.
        /// </summary>
        internal bool IsSetFieldValueRange() => this.FieldValueRange != null;

        /// <summary>
        /// Gets and sets the property FilterOperators. 
        /// <para>
        ///  The list of operators supported by a field. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> FilterOperators { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterOperators property is set.
        /// </summary>
        internal bool IsSetFilterOperators() => this.FilterOperators != null && (this.FilterOperators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedDateFormat. 
        /// <para>
        /// The date format that the field supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string SupportedDateFormat { get; set; }

        /// <summary>
        /// Checks to see if the SupportedDateFormat property is set.
        /// </summary>
        internal bool IsSetSupportedDateFormat() => this.SupportedDateFormat != null;

        /// <summary>
        /// Gets and sets the property SupportedValues. 
        /// <para>
        ///  The list of values that a field can contain. For example, a Boolean <c>fieldType</c>
        /// can have two values: "true" and "false". 
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

        /// <summary>
        /// Gets and sets the property ValueRegexPattern. 
        /// <para>
        /// The regular expression pattern for the field name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ValueRegexPattern { get; set; }

        /// <summary>
        /// Checks to see if the ValueRegexPattern property is set.
        /// </summary>
        internal bool IsSetValueRegexPattern() => this.ValueRegexPattern != null;
    }
}
