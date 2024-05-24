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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains the time metric, interval, and method by which to bin the analytics data.
    /// </summary>
    public partial class AnalyticsBinBySpecification
    {
        private AnalyticsInterval _interval;
        private AnalyticsBinByName _name;
        private AnalyticsSortOrder _order;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// Specifies the interval of time by which to bin the analytics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsInterval Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the time metric by which to bin the analytics data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsBinByName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// Specifies whether to bin the analytics data in ascending or descending order. If this
        /// field is left blank, the default order is by the key of the bin in descending order.
        /// </para>
        /// </summary>
        public AnalyticsSortOrder Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

    }
}