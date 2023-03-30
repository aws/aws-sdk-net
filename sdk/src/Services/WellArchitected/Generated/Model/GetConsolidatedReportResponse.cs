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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the GetConsolidatedReport operation.
    /// </summary>
    public partial class GetConsolidatedReportResponse : AmazonWebServiceResponse
    {
        private string _base64String;
        private List<ConsolidatedReportMetric> _metrics = new List<ConsolidatedReportMetric>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Base64String.
        /// </summary>
        public string Base64String
        {
            get { return this._base64String; }
            set { this._base64String = value; }
        }

        // Check to see if Base64String property is set
        internal bool IsSetBase64String()
        {
            return this._base64String != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics that make up the consolidated report.
        /// </para>
        ///  
        /// <para>
        /// Only returned when <code>JSON</code> format is requested.
        /// </para>
        /// </summary>
        public List<ConsolidatedReportMetric> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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