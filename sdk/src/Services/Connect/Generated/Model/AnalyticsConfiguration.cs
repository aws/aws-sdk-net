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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The configuration for conversational analytics.
    /// </summary>
    public partial class AnalyticsConfiguration
    {
        private LanguageConfiguration _languageConfiguration;
        private RedactionConfiguration _redactionConfiguration;
        private RulesConfiguration _rulesConfiguration;
        private SentimentConfiguration _sentimentConfiguration;
        private SummaryConfiguration _summaryConfiguration;

        /// <summary>
        /// Gets and sets the property LanguageConfiguration. 
        /// <para>
        /// The language configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageConfiguration LanguageConfiguration
        {
            get { return this._languageConfiguration; }
            set { this._languageConfiguration = value; }
        }

        // Check to see if LanguageConfiguration property is set
        internal bool IsSetLanguageConfiguration()
        {
            return this._languageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RedactionConfiguration. 
        /// <para>
        /// The redaction configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedactionConfiguration RedactionConfiguration
        {
            get { return this._redactionConfiguration; }
            set { this._redactionConfiguration = value; }
        }

        // Check to see if RedactionConfiguration property is set
        internal bool IsSetRedactionConfiguration()
        {
            return this._redactionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RulesConfiguration. 
        /// <para>
        /// The rules configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RulesConfiguration RulesConfiguration
        {
            get { return this._rulesConfiguration; }
            set { this._rulesConfiguration = value; }
        }

        // Check to see if RulesConfiguration property is set
        internal bool IsSetRulesConfiguration()
        {
            return this._rulesConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentConfiguration. 
        /// <para>
        /// The sentiment configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SummaryConfiguration. 
        /// <para>
        /// The summary configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SummaryConfiguration SummaryConfiguration
        {
            get { return this._summaryConfiguration; }
            set { this._summaryConfiguration = value; }
        }

        // Check to see if SummaryConfiguration property is set
        internal bool IsSetSummaryConfiguration()
        {
            return this._summaryConfiguration != null;
        }

    }
}