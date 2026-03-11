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
    /// Information about answer data for a contact evaluation. Answer data must be either
    /// string, numeric, or not applicable.
    /// </summary>
    public partial class EvaluationAnswerData
    {
        private string _dateTimeValue;
        private bool? _notApplicable;
        private double? _numericValue;
        private string _stringValue;
        private List<string> _stringValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DateTimeValue. 
        /// <para>
        /// Date and time value provided as an answer to an evaluation question.
        /// </para>
        /// </summary>
        public string DateTimeValue
        {
            get { return this._dateTimeValue; }
            set { this._dateTimeValue = value; }
        }

        // Check to see if DateTimeValue property is set
        internal bool IsSetDateTimeValue()
        {
            return this._dateTimeValue != null;
        }

        /// <summary>
        /// Gets and sets the property NotApplicable. 
        /// <para>
        /// The flag to mark the question as not applicable.
        /// </para>
        /// </summary>
        public bool? NotApplicable
        {
            get { return this._notApplicable; }
            set { this._notApplicable = value; }
        }

        // Check to see if NotApplicable property is set
        internal bool IsSetNotApplicable()
        {
            return this._notApplicable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumericValue. 
        /// <para>
        /// The numeric value for an answer in a contact evaluation.
        /// </para>
        /// </summary>
        public double? NumericValue
        {
            get { return this._numericValue; }
            set { this._numericValue = value; }
        }

        // Check to see if NumericValue property is set
        internal bool IsSetNumericValue()
        {
            return this._numericValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The string value for an answer in a contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// String values provided as answers to evaluation questions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringValues
        {
            get { return this._stringValues; }
            set { this._stringValues = value; }
        }

        // Check to see if StringValues property is set
        internal bool IsSetStringValues()
        {
            return this._stringValues != null && (this._stringValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}