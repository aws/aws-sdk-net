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
    /// Container for the parameters to the DescribeConfigRules operation.
    /// Returns details about your Config rules.
    /// </summary>
    public partial class DescribeConfigRulesRequest : AmazonConfigServiceRequest
    {
        private List<string> _configRuleNames = new List<string>();
        private DescribeConfigRulesFilters _filters;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// The names of the Config rules for which you want details. If you do not specify any
        /// names, Config returns details for all your rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> ConfigRuleNames
        {
            get { return this._configRuleNames; }
            set { this._configRuleNames = value; }
        }

        // Check to see if ConfigRuleNames property is set
        internal bool IsSetConfigRuleNames()
        {
            return this._configRuleNames != null && this._configRuleNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Returns a list of Detective or Proactive Config rules. By default, this API returns
        /// an unfiltered list. For more information on Detective or Proactive Config rules, see
        /// <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config-rules.html">
        /// <b>Evaluation Mode</b> </a> in the Config Developer Guide.
        /// </para>
        /// </summary>
        public DescribeConfigRulesFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned on a previous page that you use to get
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