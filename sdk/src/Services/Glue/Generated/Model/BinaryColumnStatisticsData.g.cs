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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines column statistics supported for bit sequence data values.
    /// </summary>
    public partial class BinaryColumnStatisticsData
    {
        /// <summary>
        /// Gets and sets the property AverageLength. 
        /// <para>
        /// The average bit sequence length in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? AverageLength { get; set; }

        /// <summary>
        /// Checks to see if the AverageLength property is set.
        /// </summary>
        internal bool IsSetAverageLength() => this.AverageLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumLength. 
        /// <para>
        /// The size of the longest bit sequence in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? MaximumLength { get; set; }

        /// <summary>
        /// Checks to see if the MaximumLength property is set.
        /// </summary>
        internal bool IsSetMaximumLength() => this.MaximumLength.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfNulls. 
        /// <para>
        /// The number of null values in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? NumberOfNulls { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNulls property is set.
        /// </summary>
        internal bool IsSetNumberOfNulls() => this.NumberOfNulls.HasValue;
    }
}
