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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the DescribeConformancePackCompliance operation.
    /// </summary>
    public partial class DescribeConformancePackComplianceResponse : AmazonWebServiceResponse
    {
        private string _conformancePackName;
        private List<ConformancePackRuleCompliance> _conformancePackRuleComplianceList = new List<ConformancePackRuleCompliance>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConformancePackName
        {
            get { return this._conformancePackName; }
            set { this._conformancePackName = value; }
        }

        // Check to see if ConformancePackName property is set
        internal bool IsSetConformancePackName()
        {
            return this._conformancePackName != null;
        }

        /// <summary>
        /// Gets and sets the property ConformancePackRuleComplianceList. 
        /// <para>
        /// Returns a list of <code>ConformancePackRuleCompliance</code> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<ConformancePackRuleCompliance> ConformancePackRuleComplianceList
        {
            get { return this._conformancePackRuleComplianceList; }
            set { this._conformancePackRuleComplianceList = value; }
        }

        // Check to see if ConformancePackRuleComplianceList property is set
        internal bool IsSetConformancePackRuleComplianceList()
        {
            return this._conformancePackRuleComplianceList != null && this._conformancePackRuleComplianceList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned in a previous request that you use to request
        /// the next page of results in a paginated response.
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