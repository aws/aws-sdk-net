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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Specifies the words or phrases that trigger an alert.
    /// </summary>
    public partial class RealTimeAlertRule
    {
        private IssueDetectionConfiguration _issueDetectionConfiguration;
        private KeywordMatchConfiguration _keywordMatchConfiguration;
        private SentimentConfiguration _sentimentConfiguration;
        private RealTimeAlertRuleType _type;

        /// <summary>
        /// Gets and sets the property IssueDetectionConfiguration. 
        /// <para>
        /// Specifies the issue detection settings for a real-time alert rule.
        /// </para>
        /// </summary>
        public IssueDetectionConfiguration IssueDetectionConfiguration
        {
            get { return this._issueDetectionConfiguration; }
            set { this._issueDetectionConfiguration = value; }
        }

        // Check to see if IssueDetectionConfiguration property is set
        internal bool IsSetIssueDetectionConfiguration()
        {
            return this._issueDetectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KeywordMatchConfiguration. 
        /// <para>
        /// Specifies the settings for matching the keywords in a real-time alert rule.
        /// </para>
        /// </summary>
        public KeywordMatchConfiguration KeywordMatchConfiguration
        {
            get { return this._keywordMatchConfiguration; }
            set { this._keywordMatchConfiguration = value; }
        }

        // Check to see if KeywordMatchConfiguration property is set
        internal bool IsSetKeywordMatchConfiguration()
        {
            return this._keywordMatchConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentConfiguration. 
        /// <para>
        /// Specifies the settings for predicting sentiment in a real-time alert rule.
        /// </para>
        /// </summary>
        public SentimentConfiguration SentimentConfiguration
        {
            get { return this._sentimentConfiguration; }
            set { this._sentimentConfiguration = value; }
        }

        // Check to see if SentimentConfiguration property is set
        internal bool IsSetSentimentConfiguration()
        {
            return this._sentimentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of alert rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RealTimeAlertRuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}