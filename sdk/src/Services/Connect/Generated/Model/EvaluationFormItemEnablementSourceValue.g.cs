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
    /// An enablement expression source value. Provide only the value member that matches
    /// the specified <c>Type</c>.
    /// </summary>
    public partial class EvaluationFormItemEnablementSourceValue
    {
        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A Boolean value to compare against the source. Use when <c>Type</c> is <c>BOOLEAN_VALUE</c>.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DateTimeValue. 
        /// <para>
        /// A date and time value to compare against the source. Use when <c>Type</c> is <c>DATETIME_VALUE</c>.
        /// </para>
        /// </summary>
        public DateTime? DateTimeValue { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeValue property is set.
        /// </summary>
        internal bool IsSetDateTimeValue() => this.DateTimeValue.HasValue;

        /// <summary>
        /// Gets and sets the property NumericValue. 
        /// <para>
        /// A numeric value to compare against the source. Use when <c>Type</c> is <c>NUMERIC_VALUE</c>.
        /// </para>
        /// </summary>
        public double? NumericValue { get; set; }

        /// <summary>
        /// Checks to see if the NumericValue property is set.
        /// </summary>
        internal bool IsSetNumericValue() => this.NumericValue.HasValue;

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// A referenceId of the source value. Use when <c>Type</c> is <c>OPTION_REF_ID</c>.
        /// </para>
        /// </summary>
        public string RefId { get; set; }

        /// <summary>
        /// Checks to see if the RefId property is set.
        /// </summary>
        internal bool IsSetRefId() => this.RefId != null;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string value to compare against the source. Use when <c>Type</c> is <c>STRING_VALUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A type of source item value. Valid values: <c>OPTION_REF_ID</c> | <c>STRING_VALUE</c>
        /// | <c>NUMERIC_VALUE</c> | <c>BOOLEAN_VALUE</c> | <c>DATETIME_VALUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormItemEnablementSourceValueType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
