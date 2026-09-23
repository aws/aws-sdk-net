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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Specifies the words or phrases that trigger an alert.
    /// </summary>
    public partial class RealTimeAlertRule
    {
        /// <summary>
        /// Gets and sets the property IssueDetectionConfiguration. 
        /// <para>
        /// Specifies the issue detection settings for a real-time alert rule.
        /// </para>
        /// </summary>
        public IssueDetectionConfiguration IssueDetectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IssueDetectionConfiguration property is set.
        /// </summary>
        internal bool IsSetIssueDetectionConfiguration() => this.IssueDetectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property KeywordMatchConfiguration. 
        /// <para>
        /// Specifies the settings for matching the keywords in a real-time alert rule.
        /// </para>
        /// </summary>
        public KeywordMatchConfiguration KeywordMatchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KeywordMatchConfiguration property is set.
        /// </summary>
        internal bool IsSetKeywordMatchConfiguration() => this.KeywordMatchConfiguration != null;

        /// <summary>
        /// Gets and sets the property SentimentConfiguration. 
        /// <para>
        /// Specifies the settings for predicting sentiment in a real-time alert rule.
        /// </para>
        /// </summary>
        public SentimentConfiguration SentimentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SentimentConfiguration property is set.
        /// </summary>
        internal bool IsSetSentimentConfiguration() => this.SentimentConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of alert rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RealTimeAlertRuleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
