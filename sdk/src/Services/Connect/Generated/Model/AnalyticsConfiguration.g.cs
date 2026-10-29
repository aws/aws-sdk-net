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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The configuration for conversational analytics.
    /// </summary>
    public partial class AnalyticsConfiguration
    {
        /// <summary>
        /// Gets and sets the property LanguageConfiguration. 
        /// <para>
        /// The language configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LanguageConfiguration LanguageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LanguageConfiguration property is set.
        /// </summary>
        internal bool IsSetLanguageConfiguration() => this.LanguageConfiguration != null;

        /// <summary>
        /// Gets and sets the property RedactionConfiguration. 
        /// <para>
        /// The redaction configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RedactionConfiguration RedactionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedactionConfiguration property is set.
        /// </summary>
        internal bool IsSetRedactionConfiguration() => this.RedactionConfiguration != null;

        /// <summary>
        /// Gets and sets the property RulesConfiguration. 
        /// <para>
        /// The rules configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RulesConfiguration RulesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RulesConfiguration property is set.
        /// </summary>
        internal bool IsSetRulesConfiguration() => this.RulesConfiguration != null;

        /// <summary>
        /// Gets and sets the property SentimentConfiguration. 
        /// <para>
        /// The sentiment configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SentimentConfiguration SentimentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SentimentConfiguration property is set.
        /// </summary>
        internal bool IsSetSentimentConfiguration() => this.SentimentConfiguration != null;

        /// <summary>
        /// Gets and sets the property SummaryConfiguration. 
        /// <para>
        /// The summary configuration for conversational analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SummaryConfiguration SummaryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SummaryConfiguration property is set.
        /// </summary>
        internal bool IsSetSummaryConfiguration() => this.SummaryConfiguration != null;
    }
}
