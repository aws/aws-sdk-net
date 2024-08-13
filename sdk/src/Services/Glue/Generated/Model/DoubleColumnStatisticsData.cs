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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines column statistics supported for floating-point number data columns.
    /// </summary>
    public partial class DoubleColumnStatisticsData
    {
        private double? _maximumValue;
        private double? _minimumValue;
        private long? _numberOfDistinctValues;
        private long? _numberOfNulls;

        /// <summary>
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The highest value in the column.
        /// </para>
        /// </summary>
        public double? MaximumValue
        {
            get { return this._maximumValue; }
            set { this._maximumValue = value; }
        }

        // Check to see if MaximumValue property is set
        internal bool IsSetMaximumValue()
        {
            return this._maximumValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumValue. 
        /// <para>
        /// The lowest value in the column.
        /// </para>
        /// </summary>
        public double? MinimumValue
        {
            get { return this._minimumValue; }
            set { this._minimumValue = value; }
        }

        // Check to see if MinimumValue property is set
        internal bool IsSetMinimumValue()
        {
            return this._minimumValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDistinctValues. 
        /// <para>
        /// The number of distinct values in a column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? NumberOfDistinctValues
        {
            get { return this._numberOfDistinctValues; }
            set { this._numberOfDistinctValues = value; }
        }

        // Check to see if NumberOfDistinctValues property is set
        internal bool IsSetNumberOfDistinctValues()
        {
            return this._numberOfDistinctValues.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfNulls. 
        /// <para>
        /// The number of null values in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? NumberOfNulls
        {
            get { return this._numberOfNulls; }
            set { this._numberOfNulls = value; }
        }

        // Check to see if NumberOfNulls property is set
        internal bool IsSetNumberOfNulls()
        {
            return this._numberOfNulls.HasValue; 
        }

    }
}