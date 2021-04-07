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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Request to describe Job log filters.
    /// </summary>
    public partial class DescribeJobsRequestFilters
    {
        private string _fromDate;
        private List<string> _jobiDs = new List<string>();
        private string _toDate;

        /// <summary>
        /// Gets and sets the property FromDate. 
        /// <para>
        /// Request to describe Job log filters by date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        // Check to see if FromDate property is set
        internal bool IsSetFromDate()
        {
            return this._fromDate != null;
        }

        /// <summary>
        /// Gets and sets the property JobIDs. 
        /// <para>
        /// Request to describe Job log filters by job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> JobIDs
        {
            get { return this._jobiDs; }
            set { this._jobiDs = value; }
        }

        // Check to see if JobIDs property is set
        internal bool IsSetJobIDs()
        {
            return this._jobiDs != null && this._jobiDs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ToDate. 
        /// <para>
        /// Request to describe Job log by last date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        // Check to see if ToDate property is set
        internal bool IsSetToDate()
        {
            return this._toDate != null;
        }

    }
}