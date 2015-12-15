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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeComplianceByConfigRuleResult : AmazonWebServiceResponse
    {
        private List<ComplianceByConfigRule> _complianceByConfigRules = new List<ComplianceByConfigRule>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComplianceByConfigRules. 
        /// <para>
        /// Indicates whether each of the specified AWS Config rules is compliant.
        /// </para>
        /// </summary>
        public List<ComplianceByConfigRule> ComplianceByConfigRules
        {
            get { return this._complianceByConfigRules; }
            set { this._complianceByConfigRules = value; }
        }

        // Check to see if ComplianceByConfigRules property is set
        internal bool IsSetComplianceByConfigRules()
        {
            return this._complianceByConfigRules != null && this._complianceByConfigRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that you use in a subsequent request to get the next page of results in
        /// a paginated response.
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