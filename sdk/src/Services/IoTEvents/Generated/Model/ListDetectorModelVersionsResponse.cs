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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// This is the response object from the ListDetectorModelVersions operation.
    /// </summary>
    public partial class ListDetectorModelVersionsResponse : AmazonWebServiceResponse
    {
        private List<DetectorModelVersionSummary> _detectorModelVersionSummaries = new List<DetectorModelVersionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DetectorModelVersionSummaries. 
        /// <para>
        /// Summary information about the detector model versions.
        /// </para>
        /// </summary>
        public List<DetectorModelVersionSummary> DetectorModelVersionSummaries
        {
            get { return this._detectorModelVersionSummaries; }
            set { this._detectorModelVersionSummaries = value; }
        }

        // Check to see if DetectorModelVersionSummaries property is set
        internal bool IsSetDetectorModelVersionSummaries()
        {
            return this._detectorModelVersionSummaries != null && this._detectorModelVersionSummaries.Count > 0; 
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