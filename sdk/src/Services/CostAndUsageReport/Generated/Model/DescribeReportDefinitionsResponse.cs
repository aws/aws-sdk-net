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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// If the action is successful, the service sends back an HTTP 200 response.
    /// </summary>
    public partial class DescribeReportDefinitionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReportDefinition> _reportDefinitions = new List<ReportDefinition>();

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property ReportDefinitions. 
        /// <para>
        /// A list of AWS Cost and Usage reports owned by the account.
        /// </para>
        /// </summary>
        public List<ReportDefinition> ReportDefinitions
        {
            get { return this._reportDefinitions; }
            set { this._reportDefinitions = value; }
        }

        // Check to see if ReportDefinitions property is set
        internal bool IsSetReportDefinitions()
        {
            return this._reportDefinitions != null && this._reportDefinitions.Count > 0; 
        }

    }
}