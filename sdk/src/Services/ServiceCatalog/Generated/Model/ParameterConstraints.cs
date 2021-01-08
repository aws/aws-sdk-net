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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The constraints that the administrator has put on the parameter.
    /// </summary>
    public partial class ParameterConstraints
    {
        private string _allowedPattern;
        private List<string> _allowedValues = new List<string>();
        private string _constraintDescription;
        private string _maxLength;
        private string _maxValue;
        private string _minLength;
        private string _minValue;

        /// <summary>
        /// Gets and sets the property AllowedPattern. 
        /// <para>
        /// A regular expression that represents the patterns that allow for <code>String</code>
        /// types. The pattern must match the entire parameter value provided.
        /// </para>
        /// </summary>
        public string AllowedPattern
        {
            get { return this._allowedPattern; }
            set { this._allowedPattern = value; }
        }

        // Check to see if AllowedPattern property is set
        internal bool IsSetAllowedPattern()
        {
            return this._allowedPattern != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The values that the administrator has allowed for the parameter.
        /// </para>
        /// </summary>
        public List<string> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && this._allowedValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConstraintDescription. 
        /// <para>
        /// A string that explains a constraint when the constraint is violated. For example,
        /// without a constraint description, a parameter that has an allowed pattern of <code>[A-Za-z0-9]+</code>
        /// displays the following error message when the user specifies an invalid value:
        /// </para>
        ///  
        /// <para>
        ///  <code>Malformed input-Parameter MyParameter must match pattern [A-Za-z0-9]+</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// By adding a constraint description, such as must only contain letters (uppercase and
        /// lowercase) and numbers, you can display the following customized error message:
        /// </para>
        ///  
        /// <para>
        ///  <code>Malformed input-Parameter MyParameter must only contain uppercase and lowercase
        /// letters and numbers.</code> 
        /// </para>
        /// </summary>
        public string ConstraintDescription
        {
            get { return this._constraintDescription; }
            set { this._constraintDescription = value; }
        }

        // Check to see if ConstraintDescription property is set
        internal bool IsSetConstraintDescription()
        {
            return this._constraintDescription != null;
        }

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// An integer value that determines the largest number of characters you want to allow
        /// for <code>String</code> types. 
        /// </para>
        /// </summary>
        public string MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength != null;
        }

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// A numeric value that determines the largest numeric value you want to allow for <code>Number</code>
        /// types.
        /// </para>
        /// </summary>
        public string MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue != null;
        }

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// An integer value that determines the smallest number of characters you want to allow
        /// for <code>String</code> types.
        /// </para>
        /// </summary>
        public string MinLength
        {
            get { return this._minLength; }
            set { this._minLength = value; }
        }

        // Check to see if MinLength property is set
        internal bool IsSetMinLength()
        {
            return this._minLength != null;
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// A numeric value that determines the smallest numeric value you want to allow for <code>Number</code>
        /// types. 
        /// </para>
        /// </summary>
        public string MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue != null;
        }

    }
}