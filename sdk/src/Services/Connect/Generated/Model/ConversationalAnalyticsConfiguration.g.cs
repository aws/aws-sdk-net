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
    /// The conversational analytics configuration settings for a contact.
    /// </summary>
    public partial class ConversationalAnalyticsConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChannelConfiguration. 
        /// <para>
        /// The per-channel conversational analytics settings for the contact.
        /// </para>
        /// </summary>
        public ContactLensChannelConfiguration ChannelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChannelConfiguration property is set.
        /// </summary>
        internal bool IsSetChannelConfiguration() => this.ChannelConfiguration != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether conversational analytics is enabled for the contact.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageLocale. 
        /// <para>
        /// The language locale that conversational analytics uses to analyze the contact (for
        /// example, <c>en-US</c>).
        /// </para>
        /// </summary>
        public string LanguageLocale { get; set; }

        /// <summary>
        /// Checks to see if the LanguageLocale property is set.
        /// </summary>
        internal bool IsSetLanguageLocale() => this.LanguageLocale != null;

        /// <summary>
        /// Gets and sets the property LanguageLocales. 
        /// <para>
        /// The language locales that conversational analytics uses to analyze the contact (for
        /// example, <c>en-US</c> and <c>es-ES</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> LanguageLocales { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LanguageLocales property is set.
        /// </summary>
        internal bool IsSetLanguageLocales() => this.LanguageLocales != null && (this.LanguageLocales.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RedactionConfiguration. 
        /// <para>
        /// The redaction configuration for the contact transcript.
        /// </para>
        /// </summary>
        public ContactLensRedactionConfiguration RedactionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedactionConfiguration property is set.
        /// </summary>
        internal bool IsSetRedactionConfiguration() => this.RedactionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SentimentConfiguration. 
        /// <para>
        /// The sentiment analysis configuration for the contact.
        /// </para>
        /// </summary>
        public ContactLensSentimentConfiguration SentimentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SentimentConfiguration property is set.
        /// </summary>
        internal bool IsSetSentimentConfiguration() => this.SentimentConfiguration != null;

        /// <summary>
        /// Gets and sets the property SummaryConfiguration. 
        /// <para>
        /// The summary configuration for the contact.
        /// </para>
        /// </summary>
        public ContactLensSummaryConfiguration SummaryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SummaryConfiguration property is set.
        /// </summary>
        internal bool IsSetSummaryConfiguration() => this.SummaryConfiguration != null;
    }
}
