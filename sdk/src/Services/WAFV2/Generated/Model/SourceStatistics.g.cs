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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Revenue statistics for a single AI bot source, including the bot name, revenue amount,
    /// request count, and verification status.
    /// </summary>
    public partial class SourceStatistics
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The total revenue amount from this source in the specified currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property GroupByValue. 
        /// <para>
        /// The value for the group-by dimension, when grouping is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GroupByValue { get; set; }

        /// <summary>
        /// Checks to see if the GroupByValue property is set.
        /// </summary>
        internal bool IsSetGroupByValue() => this.GroupByValue != null;

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The declared intent of the AI bot (for example, summarize, index, or train).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Intent { get; set; }

        /// <summary>
        /// Checks to see if the Intent property is set.
        /// </summary>
        internal bool IsSetIntent() => this.Intent != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The organization associated with the AI bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of total revenue from this source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public double? Percentage { get; set; }

        /// <summary>
        /// Checks to see if the Percentage property is set.
        /// </summary>
        internal bool IsSetPercentage() => this.Percentage.HasValue;

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of monetized requests from this source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? RequestCount { get; set; }

        /// <summary>
        /// Checks to see if the RequestCount property is set.
        /// </summary>
        internal bool IsSetRequestCount() => this.RequestCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceCategory. 
        /// <para>
        /// The category of this AI bot source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// Checks to see if the SourceCategory property is set.
        /// </summary>
        internal bool IsSetSourceCategory() => this.SourceCategory != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the AI bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        /// Indicates whether the AI bot's identity was verified — for example, through a cryptographically
        /// signed request (Web Bot Auth) or another published verification method. This value
        /// is meaningful only when GroupBy is NAME, where each result represents a single, identifiable
        /// bot. For all other GroupBy values (CATEGORY, INTENT, ORGANIZATION, or WEBACL), a result
        /// aggregates multiple bots that may have different verification states, so Verified
        /// is always returned as false and should be ignored. Type and required-ness are unchanged
        /// (Boolean, optional).
        /// </para>
        /// </summary>
        public bool? Verified { get; set; }

        /// <summary>
        /// Checks to see if the Verified property is set.
        /// </summary>
        internal bool IsSetVerified() => this.Verified.HasValue;
    }
}
