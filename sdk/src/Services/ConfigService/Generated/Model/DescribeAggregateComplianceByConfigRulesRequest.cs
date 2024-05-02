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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAggregateComplianceByConfigRules operation.
    /// Returns a list of compliant and noncompliant rules with the number of resources for
    /// compliant and noncompliant rules. Does not display rules that do not have compliance
    /// results. 
    /// 
    ///  <note> 
    /// <para>
    /// The results can return an empty result page, but if you have a <c>nextToken</c>, the
    /// results are displayed on the next page.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeAggregateComplianceByConfigRulesRequest : AmazonConfigServiceRequest
    {
        private string _configurationAggregatorName;
        private ConfigRuleComplianceFilters _filters;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationAggregatorName
        {
            get { return this._configurationAggregatorName; }
            set { this._configurationAggregatorName = value; }
        }

        // Check to see if ConfigurationAggregatorName property is set
        internal bool IsSetConfigurationAggregatorName()
        {
            return this._configurationAggregatorName != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results by ConfigRuleComplianceFilters object. 
        /// </para>
        /// </summary>
        public ConfigRuleComplianceFilters Filters
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of evaluation results returned on each page. The default is maximum.
        /// If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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