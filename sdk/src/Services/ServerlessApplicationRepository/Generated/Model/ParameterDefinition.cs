/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Parameters supported by the application.
    /// </summary>
    public partial class ParameterDefinition
    {
        private string _allowedPattern;
        private List<string> _allowedValues = new List<string>();
        private string _constraintDescription;
        private string _defaultValue;
        private string _description;
        private int? _maxLength;
        private int? _maxValue;
        private int? _minLength;
        private int? _minValue;
        private string _name;
        private bool? _noEcho;
        private List<string> _referencedByResources = new List<string>();
        private string _type;

        /// <summary>
        /// Gets and sets the property AllowedPattern. A regular expression that represents the
        /// patterns to allow for String types.
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
        /// Gets and sets the property AllowedValues. Array containing the list of values allowed
        /// for the parameter.
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
        /// Gets and sets the property ConstraintDescription. A string that explains a constraint
        /// when the constraint is violated. For example, without a constraint description,\n
        /// a parameter that has an allowed pattern of [A-Za-z0-9]+ displays the following error
        /// message when the user\n specifies an invalid value:\n\n Malformed input-Parameter
        /// MyParameter must match pattern [A-Za-z0-9]+ \n \nBy adding a constraint description,
        /// such as "must contain only uppercase and lowercase letters, and numbers," you can
        /// display\n the following customized error message:\n\n Malformed input-Parameter MyParameter
        /// must contain only uppercase and lowercase letters and numbers.
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
        /// Gets and sets the property DefaultValue. A value of the appropriate type for the template
        /// to use if no value is specified when a stack is created.\n If you define constraints
        /// for the parameter, you must specify a value that adheres to those constraints.
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Description. A string of up to 4,000 characters that describes
        /// the parameter.
        /// </summary>
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
        /// Gets and sets the property MaxLength. An integer value that determines the largest
        /// number of characters you want to allow for String types.
        /// </summary>
        public int MaxLength
        {
            get { return this._maxLength.GetValueOrDefault(); }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxValue. A numeric value that determines the largest numeric
        /// value you want to allow for Number types.
        /// </summary>
        public int MaxValue
        {
            get { return this._maxValue.GetValueOrDefault(); }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLength. An integer value that determines the smallest
        /// number of characters you want to allow for String types.
        /// </summary>
        public int MinLength
        {
            get { return this._minLength.GetValueOrDefault(); }
            set { this._minLength = value; }
        }

        // Check to see if MinLength property is set
        internal bool IsSetMinLength()
        {
            return this._minLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinValue. A numeric value that determines the smallest
        /// numeric value you want to allow for Number types.
        /// </summary>
        public int MinValue
        {
            get { return this._minValue.GetValueOrDefault(); }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the parameter.
        /// </summary>
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
        /// Gets and sets the property NoEcho. Whether to mask the parameter value whenever anyone
        /// makes a call that describes the stack. If you set the\n value to true, the parameter
        /// value is masked with asterisks (*****).
        /// </summary>
        public bool NoEcho
        {
            get { return this._noEcho.GetValueOrDefault(); }
            set { this._noEcho = value; }
        }

        // Check to see if NoEcho property is set
        internal bool IsSetNoEcho()
        {
            return this._noEcho.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReferencedByResources. A list of SAM resources that use
        /// this parameter.
        /// </summary>
        public List<string> ReferencedByResources
        {
            get { return this._referencedByResources; }
            set { this._referencedByResources = value; }
        }

        // Check to see if ReferencedByResources property is set
        internal bool IsSetReferencedByResources()
        {
            return this._referencedByResources != null && this._referencedByResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. The type of the parameter.\nValid values: String
        /// | Number | List<Number> | CommaDelimitedList \n \n\n String : A literal string.\nFor
        /// example, users could specify "MyUserName" .\n\n Number : An integer or float. AWS
        /// CloudFormation validates the parameter value as a number; however, when you use the\n
        /// parameter elsewhere in your template (for example, by using the Ref intrinsic function),
        /// the parameter value becomes a string.\nFor example, users could specify "8888" .\n\n
        /// List<Number> : An array of integers or floats that are separated by commas. AWS CloudFormation
        /// validates the parameter value as numbers; however, when\n you use the parameter elsewhere
        /// in your template (for example, by using the Ref intrinsic function), the parameter
        /// value becomes a list of strings.\nFor example, users could specify "80,20", and a
        /// Ref results in ["80","20"] .\n\n CommaDelimitedList : An array of literal strings
        /// that are separated by commas. The total number of strings should be one more than
        /// the total number of commas.\n Also, each member string is space-trimmed.\nFor example,
        /// users could specify "test,dev,prod", and a Ref results in ["test","dev","prod"] .
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}