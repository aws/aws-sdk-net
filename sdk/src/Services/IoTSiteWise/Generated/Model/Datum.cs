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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Represents a single data point in a query result.
    /// </summary>
    public partial class Datum
    {
        private List<Datum> _arrayValue = AWSConfigs.InitializeCollections ? new List<Datum>() : null;
        private bool? _nullValue;
        private Row _rowValue;
        private string _scalarValue;

        /// <summary>
        /// Gets and sets the property ArrayValue. 
        /// <para>
        /// Indicates if the data point is an array. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Datum> ArrayValue
        {
            get { return this._arrayValue; }
            set { this._arrayValue = value; }
        }

        // Check to see if ArrayValue property is set
        internal bool IsSetArrayValue()
        {
            return this._arrayValue != null && (this._arrayValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NullValue. 
        /// <para>
        /// Indicates if the data point is null.
        /// </para>
        /// </summary>
        public bool? NullValue
        {
            get { return this._nullValue; }
            set { this._nullValue = value; }
        }

        // Check to see if NullValue property is set
        internal bool IsSetNullValue()
        {
            return this._nullValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowValue. 
        /// <para>
        /// Indicates if the data point is a row.
        /// </para>
        /// </summary>
        public Row RowValue
        {
            get { return this._rowValue; }
            set { this._rowValue = value; }
        }

        // Check to see if RowValue property is set
        internal bool IsSetRowValue()
        {
            return this._rowValue != null;
        }

        /// <summary>
        /// Gets and sets the property ScalarValue. 
        /// <para>
        /// Indicates if the data point is a scalar value such as integer, string, double, or
        /// Boolean. 
        /// </para>
        /// </summary>
        public string ScalarValue
        {
            get { return this._scalarValue; }
            set { this._scalarValue = value; }
        }

        // Check to see if ScalarValue property is set
        internal bool IsSetScalarValue()
        {
            return this._scalarValue != null;
        }

    }
}