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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// A set of filters by which to return Jobs.
    /// </summary>
    public partial class DescribeJobsRequestFilters
    {
        private string _fromDate;
        private List<string> _jobiDs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _toDate;

        /// <summary>
        /// Gets and sets the property FromDate. 
        /// <para>
        /// The start date in a date range query.
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
        /// An array of Job IDs that should be returned. An empty array means all jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._jobiDs != null && (this._jobiDs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToDate. 
        /// <para>
        /// The end date in a date range query.
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