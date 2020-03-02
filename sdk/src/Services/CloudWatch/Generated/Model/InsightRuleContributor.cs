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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// One of the unique contributors found by a Contributor Insights rule. If the rule contains
    /// multiple keys, then a unique contributor is a unique combination of values from all
    /// the keys in the rule.
    /// 
    ///  
    /// <para>
    /// If the rule contains a single key, then each unique contributor is each unique value
    /// for this key.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetInsightRuleReport.html">GetInsightRuleReport</a>.
    /// </para>
    /// </summary>
    public partial class InsightRuleContributor
    {
        private double? _approximateAggregateValue;
        private List<InsightRuleContributorDatapoint> _datapoints = new List<InsightRuleContributorDatapoint>();
        private List<string> _keys = new List<string>();

        /// <summary>
        /// Gets and sets the property ApproximateAggregateValue. 
        /// <para>
        /// An approximation of the aggregate value that comes from this contributor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double ApproximateAggregateValue
        {
            get { return this._approximateAggregateValue.GetValueOrDefault(); }
            set { this._approximateAggregateValue = value; }
        }

        // Check to see if ApproximateAggregateValue property is set
        internal bool IsSetApproximateAggregateValue()
        {
            return this._approximateAggregateValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Datapoints. 
        /// <para>
        /// An array of the data points where this contributor is present. Only the data points
        /// when this contributor appeared are included in the array.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InsightRuleContributorDatapoint> Datapoints
        {
            get { return this._datapoints; }
            set { this._datapoints = value; }
        }

        // Check to see if Datapoints property is set
        internal bool IsSetDatapoints()
        {
            return this._datapoints != null && this._datapoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// One of the log entry field keywords that is used to define contributors for this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

    }
}