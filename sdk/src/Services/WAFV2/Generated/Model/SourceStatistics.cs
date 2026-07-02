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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
        private string _amount;
        private string _groupByValue;
        private string _intent;
        private string _organization;
        private double? _percentage;
        private long? _requestCount;
        private string _sourceCategory;
        private string _sourceName;
        private bool? _verified;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The total revenue amount from this source in the specified currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property GroupByValue. 
        /// <para>
        /// The value for the group-by dimension, when grouping is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GroupByValue
        {
            get { return this._groupByValue; }
            set { this._groupByValue = value; }
        }

        // Check to see if GroupByValue property is set
        internal bool IsSetGroupByValue()
        {
            return this._groupByValue != null;
        }

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The declared intent of the AI bot (for example, summarize, index, or train).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The organization associated with the AI bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of total revenue from this source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public double? Percentage
        {
            get { return this._percentage; }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestCount. 
        /// <para>
        /// The number of monetized requests from this source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? RequestCount
        {
            get { return this._requestCount; }
            set { this._requestCount = value; }
        }

        // Check to see if RequestCount property is set
        internal bool IsSetRequestCount()
        {
            return this._requestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceCategory. 
        /// <para>
        /// The category of this AI bot source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SourceCategory
        {
            get { return this._sourceCategory; }
            set { this._sourceCategory = value; }
        }

        // Check to see if SourceCategory property is set
        internal bool IsSetSourceCategory()
        {
            return this._sourceCategory != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the AI bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

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
        public bool? Verified
        {
            get { return this._verified; }
            set { this._verified = value; }
        }

        // Check to see if Verified property is set
        internal bool IsSetVerified()
        {
            return this._verified.HasValue; 
        }

    }
}