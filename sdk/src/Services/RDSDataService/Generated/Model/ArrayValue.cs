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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Contains an array.
    /// </summary>
    public partial class ArrayValue
    {
        private List<ArrayValue> _arrayValues = new List<ArrayValue>();
        private List<bool> _booleanValues = new List<bool>();
        private List<double> _doubleValues = new List<double>();
        private List<long> _longValues = new List<long>();
        private List<string> _stringValues = new List<string>();

        /// <summary>
        /// Gets and sets the property ArrayValues. 
        /// <para>
        /// An array of arrays.
        /// </para>
        /// </summary>
        public List<ArrayValue> ArrayValues
        {
            get { return this._arrayValues; }
            set { this._arrayValues = value; }
        }

        // Check to see if ArrayValues property is set
        internal bool IsSetArrayValues()
        {
            return this._arrayValues != null && this._arrayValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BooleanValues. 
        /// <para>
        /// An array of Boolean values.
        /// </para>
        /// </summary>
        public List<bool> BooleanValues
        {
            get { return this._booleanValues; }
            set { this._booleanValues = value; }
        }

        // Check to see if BooleanValues property is set
        internal bool IsSetBooleanValues()
        {
            return this._booleanValues != null && this._booleanValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValues. 
        /// <para>
        /// An array of integers.
        /// </para>
        /// </summary>
        public List<double> DoubleValues
        {
            get { return this._doubleValues; }
            set { this._doubleValues = value; }
        }

        // Check to see if DoubleValues property is set
        internal bool IsSetDoubleValues()
        {
            return this._doubleValues != null && this._doubleValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LongValues. 
        /// <para>
        /// An array of floating point numbers.
        /// </para>
        /// </summary>
        public List<long> LongValues
        {
            get { return this._longValues; }
            set { this._longValues = value; }
        }

        // Check to see if LongValues property is set
        internal bool IsSetLongValues()
        {
            return this._longValues != null && this._longValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// An array of strings.
        /// </para>
        /// </summary>
        public List<string> StringValues
        {
            get { return this._stringValues; }
            set { this._stringValues = value; }
        }

        // Check to see if StringValues property is set
        internal bool IsSetStringValues()
        {
            return this._stringValues != null && this._stringValues.Count > 0; 
        }

    }
}