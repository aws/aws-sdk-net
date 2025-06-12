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
    /// Container for the parameters to the DescribeConfigRuleEvaluationStatus operation.
    /// Returns status information for each of your Config managed rules. The status includes
    /// information such as the last time Config invoked the rule, the last time Config failed
    /// to invoke the rule, and the related error for the last failure.
    /// </summary>
    public partial class DescribeConfigRuleEvaluationStatusRequest : AmazonConfigServiceRequest
    {
        private List<string> _configRuleNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// The name of the Config managed rules for which you want status information. If you
        /// do not specify any names, Config returns status information for all Config managed
        /// rules that you use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._configRuleNames != null && (this._configRuleNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The number of rule evaluation results that you want returned.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if the rule limit for your account is more than the default
        /// of 1000 rules.
        /// </para>
        ///  
        /// <para>
        /// For information about requesting a rule limit increase, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_config">Config
        /// Limits</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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