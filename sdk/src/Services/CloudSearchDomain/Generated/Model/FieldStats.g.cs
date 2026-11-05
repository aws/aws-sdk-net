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

namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// The statistics for a field calculated in the request.
    /// </summary>
    public partial class FieldStats
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of documents that contain a value in the specified field in the result
        /// set.
        /// </para>
        /// </summary>
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum value found in the specified field in the result set.
        /// </para>
        ///  
        /// <para>
        /// If the field is numeric (<c>int</c>, <c>int-array</c>, <c>double</c>, or <c>double-array</c>),
        /// <c>max</c> is the string representation of a double-precision 64-bit floating point
        /// value. If the field is <c>date</c> or <c>date-array</c>, <c>max</c> is the string
        /// representation of a date with the format specified in <a href="http://tools.ietf.org/html/rfc3339">IETF
        /// RFC3339</a>: yyyy-mm-ddTHH:mm:ss.SSSZ.
        /// </para>
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max != null;

        /// <summary>
        /// Gets and sets the property Mean. 
        /// <para>
        /// The average of the values found in the specified field in the result set.
        /// </para>
        ///  
        /// <para>
        /// If the field is numeric (<c>int</c>, <c>int-array</c>, <c>double</c>, or <c>double-array</c>),
        /// <c>mean</c> is the string representation of a double-precision 64-bit floating point
        /// value. If the field is <c>date</c> or <c>date-array</c>, <c>mean</c> is the string
        /// representation of a date with the format specified in <a href="http://tools.ietf.org/html/rfc3339">IETF
        /// RFC3339</a>: yyyy-mm-ddTHH:mm:ss.SSSZ.
        /// </para>
        /// </summary>
        public string Mean { get; set; }

        /// <summary>
        /// Checks to see if the Mean property is set.
        /// </summary>
        internal bool IsSetMean() => this.Mean != null;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum value found in the specified field in the result set.
        /// </para>
        ///  
        /// <para>
        /// If the field is numeric (<c>int</c>, <c>int-array</c>, <c>double</c>, or <c>double-array</c>),
        /// <c>min</c> is the string representation of a double-precision 64-bit floating point
        /// value. If the field is <c>date</c> or <c>date-array</c>, <c>min</c> is the string
        /// representation of a date with the format specified in <a href="http://tools.ietf.org/html/rfc3339">IETF
        /// RFC3339</a>: yyyy-mm-ddTHH:mm:ss.SSSZ.
        /// </para>
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min != null;

        /// <summary>
        /// Gets and sets the property Missing. 
        /// <para>
        /// The number of documents that do not contain a value in the specified field in the
        /// result set.
        /// </para>
        /// </summary>
        public long? Missing { get; set; }

        /// <summary>
        /// Checks to see if the Missing property is set.
        /// </summary>
        internal bool IsSetMissing() => this.Missing.HasValue;

        /// <summary>
        /// Gets and sets the property Stddev. 
        /// <para>
        /// The standard deviation of the values in the specified field in the result set.
        /// </para>
        /// </summary>
        public double? Stddev { get; set; }

        /// <summary>
        /// Checks to see if the Stddev property is set.
        /// </summary>
        internal bool IsSetStddev() => this.Stddev.HasValue;

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the field values across the documents in the result set. <c>null</c> for
        /// date fields.
        /// </para>
        /// </summary>
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;

        /// <summary>
        /// Gets and sets the property SumOfSquares. 
        /// <para>
        /// The sum of all field values in the result set squared.
        /// </para>
        /// </summary>
        public double? SumOfSquares { get; set; }

        /// <summary>
        /// Checks to see if the SumOfSquares property is set.
        /// </summary>
        internal bool IsSetSumOfSquares() => this.SumOfSquares.HasValue;
    }
}
