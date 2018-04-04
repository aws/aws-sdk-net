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
    /// Container for the parameters to the GetAggregateComplianceDetailsByConfigRule operation.
    /// Returns the evaluation results for the specified AWS Config rule for a specific resource
    /// in a rule. The results indicate which AWS resources were evaluated by the rule, when
    /// each resource was last evaluated, and whether each resource complies with the rule.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// The results can return an empty result page. But if you have a nextToken, the results
    /// are displayed on the next page.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetAggregateComplianceDetailsByConfigRuleRequest : AmazonConfigServiceRequest
    {
        private string _accountId;
        private string _awsRegion;
        private ComplianceType _complianceType;
        private string _configRuleName;
        private string _configurationAggregatorName;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit account ID of the source account.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The source region from where the data is aggregated.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The resource compliance status.
        /// </para>
        ///  <note> 
        /// <para>
        /// For the <code>GetAggregateComplianceDetailsByConfigRuleRequest</code> data type, AWS
        /// Config supports only the <code>COMPLIANT</code> and <code>NON_COMPLIANT</code>. AWS
        /// Config does not support the <code>NOT_APPLICABLE</code> and <code>INSUFFICIENT_DATA</code>
        /// values.
        /// </para>
        ///  </note>
        /// </summary>
        public ComplianceType ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the AWS Config rule for which you want compliance information.
        /// </para>
        /// </summary>
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of evaluation results returned on each page. The default is 50.
        /// You cannot specify a number greater than 100. If you specify 0, AWS Config uses the
        /// default.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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
        /// The nextToken string returned on a previous page that you use to get the next page
        /// of results in a paginated response.
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