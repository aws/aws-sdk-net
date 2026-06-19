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
    /// A single data point in a revenue time series, representing aggregated monetization
    /// metrics for a specific time interval.
    /// </summary>
    public partial class DataPointEntry
    {
        private string _category;
        private DateTime? _date;
        private string _groupByValue;
        private string _intent;
        private long? _monetizeServedCount;
        private long? _settledCount;
        private string _totalAmount;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The bot category for this data point, when grouped by category.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The timestamp for this data point.
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupByValue. 
        /// <para>
        /// The group-by dimension value for this data point.
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
        /// The intent classification for this data point, when grouped by intent.
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
        /// Gets and sets the property MonetizeServedCount. 
        /// <para>
        /// The number of HTTP 402 Payment Required responses served during this interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? MonetizeServedCount
        {
            get { return this._monetizeServedCount; }
            set { this._monetizeServedCount = value; }
        }

        // Check to see if MonetizeServedCount property is set
        internal bool IsSetMonetizeServedCount()
        {
            return this._monetizeServedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SettledCount. 
        /// <para>
        /// The number of successfully settled payments during this interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SettledCount
        {
            get { return this._settledCount; }
            set { this._settledCount = value; }
        }

        // Check to see if SettledCount property is set
        internal bool IsSetSettledCount()
        {
            return this._settledCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        /// The total revenue amount during this interval in the specified currency.
        /// </para>
        /// </summary>
        public string TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        // Check to see if TotalAmount property is set
        internal bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
        }

    }
}