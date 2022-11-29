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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The exclude period of <code>TimeRangeFilter</code> or <code>RelativeDatesFilter</code>.
    /// </summary>
    public partial class ExcludePeriodConfiguration
    {
        private int? _amount;
        private TimeGranularity _granularity;
        private WidgetStatus _status;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The amount or number of the exclude period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Amount
        {
            get { return this._amount.GetValueOrDefault(); }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The granularity or unit (day, month, year) of the exclude period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeGranularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the exclude period. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WidgetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}