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
    /// Defines column statistics supported for character sequence data values.
    /// </summary>
    public partial class StringColumnStatisticsData
    {
        private double? _averageLength;
        private long? _maximumLength;
        private long? _numberOfDistinctValues;
        private long? _numberOfNulls;

        /// <summary>
        /// Gets and sets the property AverageLength. 
        /// <para>
        /// The average string length in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? AverageLength
        {
            get { return this._averageLength; }
            set { this._averageLength = value; }
        }

        // Check to see if AverageLength property is set
        internal bool IsSetAverageLength()
        {
            return this._averageLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumLength. 
        /// <para>
        /// The size of the longest string in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? MaximumLength
        {
            get { return this._maximumLength; }
            set { this._maximumLength = value; }
        }

        // Check to see if MaximumLength property is set
        internal bool IsSetMaximumLength()
        {
            return this._maximumLength.HasValue; 
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