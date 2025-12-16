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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The comparison operand used to compare the defined value against the value supplied
    /// in request.
    /// </summary>
    public partial class CommandParameterValueComparisonOperand
    {
        private string _number;
        private CommandParameterValueNumberRange _numberRange;
        private List<string> _numbers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _string;
        private List<string> _strings = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// An operand of number value type, defined as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Number
        {
            get { return this._number; }
            set { this._number = value; }
        }

        // Check to see if Number property is set
        internal bool IsSetNumber()
        {
            return this._number != null;
        }

        /// <summary>
        /// Gets and sets the property NumberRange. 
        /// <para>
        /// An operand of numerical range value type.
        /// </para>
        /// </summary>
        public CommandParameterValueNumberRange NumberRange
        {
            get { return this._numberRange; }
            set { this._numberRange = value; }
        }

        // Check to see if NumberRange property is set
        internal bool IsSetNumberRange()
        {
            return this._numberRange != null;
        }

        /// <summary>
        /// Gets and sets the property Numbers. 
        /// <para>
        /// A List of operands of numerical value type, defined as strings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Numbers
        {
            get { return this._numbers; }
            set { this._numbers = value; }
        }

        // Check to see if Numbers property is set
        internal bool IsSetNumbers()
        {
            return this._numbers != null && (this._numbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// An operand of string value type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

        /// <summary>
        /// Gets and sets the property Strings. 
        /// <para>
        /// A List of operands of string value type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Strings
        {
            get { return this._strings; }
            set { this._strings = value; }
        }

        // Check to see if Strings property is set
        internal bool IsSetStrings()
        {
            return this._strings != null && (this._strings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}