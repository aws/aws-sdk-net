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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApproximateAggregateValue. 
        /// <para>
        /// An approximation of the aggregate value that comes from this contributor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? ApproximateAggregateValue { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateAggregateValue property is set.
        /// </summary>
        internal bool IsSetApproximateAggregateValue() => this.ApproximateAggregateValue.HasValue;

        /// <summary>
        /// Gets and sets the property Datapoints. 
        /// <para>
        /// An array of the data points where this contributor is present. Only the data points
        /// when this contributor appeared are included in the array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InsightRuleContributorDatapoint> Datapoints { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightRuleContributorDatapoint>() : null;

        /// <summary>
        /// Checks to see if the Datapoints property is set.
        /// </summary>
        internal bool IsSetDatapoints() => this.Datapoints != null && (this.Datapoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// One of the log entry field keywords that is used to define contributors for this rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Keys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
