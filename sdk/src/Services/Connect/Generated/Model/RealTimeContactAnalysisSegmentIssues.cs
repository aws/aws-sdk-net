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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Segment type containing a list of detected issues.
    /// </summary>
    public partial class RealTimeContactAnalysisSegmentIssues
    {
        private List<RealTimeContactAnalysisIssueDetected> _issuesDetected = AWSConfigs.InitializeCollections ? new List<RealTimeContactAnalysisIssueDetected>() : null;

        /// <summary>
        /// Gets and sets the property IssuesDetected. 
        /// <para>
        /// List of the issues detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RealTimeContactAnalysisIssueDetected> IssuesDetected
        {
            get { return this._issuesDetected; }
            set { this._issuesDetected = value; }
        }

        // Check to see if IssuesDetected property is set
        internal bool IsSetIssuesDetected()
        {
            return this._issuesDetected != null && (this._issuesDetected.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}