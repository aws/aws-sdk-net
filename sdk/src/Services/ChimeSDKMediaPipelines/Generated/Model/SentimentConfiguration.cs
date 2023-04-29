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
    /// A structure that contains the configuration settings for a sentiment analysis task.
    /// </summary>
    public partial class SentimentConfiguration
    {
        private string _ruleName;
        private SentimentType _sentimentType;
        private int? _timePeriod;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule in the sentiment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentType. 
        /// <para>
        /// The type of sentiment, <code>POSITIVE</code>, <code>NEGATIVE</code>, or <code>NEUTRAL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SentimentType SentimentType
        {
            get { return this._sentimentType; }
            set { this._sentimentType = value; }
        }

        // Check to see if SentimentType property is set
        internal bool IsSetSentimentType()
        {
            return this._sentimentType != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// Specifies the analysis interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=1800)]
        public int TimePeriod
        {
            get { return this._timePeriod.GetValueOrDefault(); }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod.HasValue; 
        }

    }
}