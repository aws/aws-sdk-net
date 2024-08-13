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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
        private long? _count;
        private string _max;
        private string _mean;
        private string _min;
        private long? _missing;
        private double? _stddev;
        private double? _sum;
        private double? _sumOfSquares;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of documents that contain a value in the specified field in the result
        /// set.
        /// </para>
        /// </summary>
        public long? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

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
        public string Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max != null;
        }

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
        public string Mean
        {
            get { return this._mean; }
            set { this._mean = value; }
        }

        // Check to see if Mean property is set
        internal bool IsSetMean()
        {
            return this._mean != null;
        }

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
        public string Min
        {
            get { return this._min; }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min != null;
        }

        /// <summary>
        /// Gets and sets the property Missing. 
        /// <para>
        /// The number of documents that do not contain a value in the specified field in the
        /// result set.
        /// </para>
        /// </summary>
        public long? Missing
        {
            get { return this._missing; }
            set { this._missing = value; }
        }

        // Check to see if Missing property is set
        internal bool IsSetMissing()
        {
            return this._missing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stddev. 
        /// <para>
        /// The standard deviation of the values in the specified field in the result set.
        /// </para>
        /// </summary>
        public double? Stddev
        {
            get { return this._stddev; }
            set { this._stddev = value; }
        }

        // Check to see if Stddev property is set
        internal bool IsSetStddev()
        {
            return this._stddev.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the field values across the documents in the result set. <c>null</c> for
        /// date fields.
        /// </para>
        /// </summary>
        public double? Sum
        {
            get { return this._sum; }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SumOfSquares. 
        /// <para>
        /// The sum of all field values in the result set squared.
        /// </para>
        /// </summary>
        public double? SumOfSquares
        {
            get { return this._sumOfSquares; }
            set { this._sumOfSquares = value; }
        }

        // Check to see if SumOfSquares property is set
        internal bool IsSetSumOfSquares()
        {
            return this._sumOfSquares.HasValue; 
        }

    }
}