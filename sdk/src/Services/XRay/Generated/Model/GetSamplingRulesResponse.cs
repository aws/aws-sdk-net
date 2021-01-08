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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the GetSamplingRules operation.
    /// </summary>
    public partial class GetSamplingRulesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SamplingRuleRecord> _samplingRuleRecords = new List<SamplingRuleRecord>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
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

        /// <summary>
        /// Gets and sets the property SamplingRuleRecords. 
        /// <para>
        /// Rule definitions and metadata.
        /// </para>
        /// </summary>
        public List<SamplingRuleRecord> SamplingRuleRecords
        {
            get { return this._samplingRuleRecords; }
            set { this._samplingRuleRecords = value; }
        }

        // Check to see if SamplingRuleRecords property is set
        internal bool IsSetSamplingRuleRecords()
        {
            return this._samplingRuleRecords != null && this._samplingRuleRecords.Count > 0; 
        }

    }
}