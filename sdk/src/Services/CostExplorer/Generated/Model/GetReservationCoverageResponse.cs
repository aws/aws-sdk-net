/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetReservationCoverage operation.
    /// </summary>
    public partial class GetReservationCoverageResponse : AmazonWebServiceResponse
    {
        private List<CoverageByTime> _coveragesByTime = new List<CoverageByTime>();
        private string _nextPageToken;
        private Coverage _total;

        /// <summary>
        /// Gets and sets the property CoveragesByTime. 
        /// <para>
        /// The amount of time that your reservations covered.
        /// </para>
        /// </summary>
        public List<CoverageByTime> CoveragesByTime
        {
            get { return this._coveragesByTime; }
            set { this._coveragesByTime = value; }
        }

        // Check to see if CoveragesByTime property is set
        internal bool IsSetCoveragesByTime()
        {
            return this._coveragesByTime != null && this._coveragesByTime.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next set of retrievable results. AWS provides the token when the
        /// response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total amount of instance usage covered by a reservation.
        /// </para>
        /// </summary>
        public Coverage Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total != null;
        }

    }
}