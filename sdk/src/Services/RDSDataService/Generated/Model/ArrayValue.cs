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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
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
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Contains an array.
    /// </summary>
    public partial class ArrayValue
    {
        private List<ArrayValue> _arrayValues = AWSConfigs.InitializeCollections ? new List<ArrayValue>() : null;
        private List<bool> _booleanValues = AWSConfigs.InitializeCollections ? new List<bool>() : null;
        private List<double> _doubleValues = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<long> _longValues = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private List<string> _stringValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ArrayValues. 
        /// <para>
        /// An array of arrays.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArrayValue> ArrayValues
        {
            get { return this._arrayValues; }
            set { this._arrayValues = value; }
        }

        // Check to see if ArrayValues property is set
        internal bool IsSetArrayValues()
        {
            return this._arrayValues != null && (this._arrayValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BooleanValues. 
        /// <para>
        /// An array of Boolean values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool> BooleanValues
        {
            get { return this._booleanValues; }
            set { this._booleanValues = value; }
        }

        // Check to see if BooleanValues property is set
        internal bool IsSetBooleanValues()
        {
            return this._booleanValues != null && (this._booleanValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DoubleValues. 
        /// <para>
        /// An array of floating-point numbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> DoubleValues
        {
            get { return this._doubleValues; }
            set { this._doubleValues = value; }
        }

        // Check to see if DoubleValues property is set
        internal bool IsSetDoubleValues()
        {
            return this._doubleValues != null && (this._doubleValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LongValues. 
        /// <para>
        /// An array of integers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long> LongValues
        {
            get { return this._longValues; }
            set { this._longValues = value; }
        }

        // Check to see if LongValues property is set
        internal bool IsSetLongValues()
        {
            return this._longValues != null && (this._longValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// An array of strings.
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