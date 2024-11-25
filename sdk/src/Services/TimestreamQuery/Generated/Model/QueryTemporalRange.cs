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
    /// Provides insights into the temporal range of the query, including the table with the
    /// largest (max) time range.
    /// </summary>
    public partial class QueryTemporalRange
    {
        private QueryTemporalRangeMax _max;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// Encapsulates the following properties that provide insights into the most sub-optimal
        /// performing table on the temporal axis:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Value</c> – The maximum duration in nanoseconds between the start and end of the
        /// query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TableArn</c> – The Amazon Resource Name (ARN) of the table which is queried with
        /// the largest time range.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QueryTemporalRangeMax Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max != null;
        }

    }
}