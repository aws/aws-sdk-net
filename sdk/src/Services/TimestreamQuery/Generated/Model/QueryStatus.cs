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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Information about the status of the query, including progress and bytes scanned.
    /// </summary>
    public partial class QueryStatus
    {
        private long? _cumulativeBytesMetered;
        private long? _cumulativeBytesScanned;
        private double? _progressPercentage;

        /// <summary>
        /// Gets and sets the property CumulativeBytesMetered. 
        /// <para>
        /// The amount of data scanned by the query in bytes that you will be charged for. This
        /// is a cumulative sum and represents the total amount of data that you will be charged
        /// for since the query was started. The charge is applied only once and is either applied
        /// when the query completes running or when the query is cancelled. 
        /// </para>
        /// </summary>
        public long? CumulativeBytesMetered
        {
            get { return this._cumulativeBytesMetered; }
            set { this._cumulativeBytesMetered = value; }
        }

        // Check to see if CumulativeBytesMetered property is set
        internal bool IsSetCumulativeBytesMetered()
        {
            return this._cumulativeBytesMetered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CumulativeBytesScanned. 
        /// <para>
        /// The amount of data scanned by the query in bytes. This is a cumulative sum and represents
        /// the total amount of bytes scanned since the query was started. 
        /// </para>
        /// </summary>
        public long? CumulativeBytesScanned
        {
            get { return this._cumulativeBytesScanned; }
            set { this._cumulativeBytesScanned = value; }
        }

        // Check to see if CumulativeBytesScanned property is set
        internal bool IsSetCumulativeBytesScanned()
        {
            return this._cumulativeBytesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The progress of the query, expressed as a percentage.
        /// </para>
        /// </summary>
        public double? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }

        // Check to see if ProgressPercentage property is set
        internal bool IsSetProgressPercentage()
        {
            return this._progressPercentage.HasValue; 
        }

    }
}