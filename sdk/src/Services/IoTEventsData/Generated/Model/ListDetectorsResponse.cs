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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// This is the response object from the ListDetectors operation.
    /// </summary>
    public partial class ListDetectorsResponse : AmazonWebServiceResponse
    {
        private List<DetectorSummary> _detectorSummaries = new List<DetectorSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DetectorSummaries. 
        /// <para>
        /// A list of summary information about the detectors (instances).
        /// </para>
        /// </summary>
        public List<DetectorSummary> DetectorSummaries
        {
            get { return this._detectorSummaries; }
            set { this._detectorSummaries = value; }
        }

        // Check to see if DetectorSummaries property is set
        internal bool IsSetDetectorSummaries()
        {
            return this._detectorSummaries != null && this._detectorSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to retrieve the next set of results, or <code>null</code> if there are no
        /// additional results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}