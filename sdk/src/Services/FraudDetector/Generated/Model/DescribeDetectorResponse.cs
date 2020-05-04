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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// This is the response object from the DescribeDetector operation.
    /// </summary>
    public partial class DescribeDetectorResponse : AmazonWebServiceResponse
    {
        private string _detectorId;
        private List<DetectorVersionSummary> _detectorVersionSummaries = new List<DetectorVersionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorVersionSummaries. 
        /// <para>
        /// The status and description for each detector version.
        /// </para>
        /// </summary>
        public List<DetectorVersionSummary> DetectorVersionSummaries
        {
            get { return this._detectorVersionSummaries; }
            set { this._detectorVersionSummaries = value; }
        }

        // Check to see if DetectorVersionSummaries property is set
        internal bool IsSetDetectorVersionSummaries()
        {
            return this._detectorVersionSummaries != null && this._detectorVersionSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token to be used for subsequent requests.
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