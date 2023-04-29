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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetColumnStatisticsForTable operation.
    /// </summary>
    public partial class GetColumnStatisticsForTableResponse : AmazonWebServiceResponse
    {
        private List<ColumnStatistics> _columnStatisticsList = new List<ColumnStatistics>();
        private List<ColumnError> _errors = new List<ColumnError>();

        /// <summary>
        /// Gets and sets the property ColumnStatisticsList. 
        /// <para>
        /// List of ColumnStatistics.
        /// </para>
        /// </summary>
        public List<ColumnStatistics> ColumnStatisticsList
        {
            get { return this._columnStatisticsList; }
            set { this._columnStatisticsList = value; }
        }

        // Check to see if ColumnStatisticsList property is set
        internal bool IsSetColumnStatisticsList()
        {
            return this._columnStatisticsList != null && this._columnStatisticsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// List of ColumnStatistics that failed to be retrieved.
        /// </para>
        /// </summary>
        public List<ColumnError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}