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
    /// Specifies the time window that utterance statistics are returned for. The time window
    /// is always relative to the last time that the that utterances were aggregated. For
    /// example, if the <c>ListAggregatedUtterances</c> operation is called at 1600, the time
    /// window is set to 1 hour, and the last refresh time was 1530, only utterances made
    /// between 1430 and 1530 are returned.
    /// 
    ///  
    /// <para>
    /// You can choose the time window that statistics should be returned for.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Hours</b> - You can request utterance statistics for 1, 3, 6, 12, or 24 hour time
    /// windows. Statistics are refreshed every half hour for 1 hour time windows, and hourly
    /// for the other time windows.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Days</b> - You can request utterance statistics for 3 days. Statistics are refreshed
    /// every 6 hours.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Weeks</b> - You can see statistics for one or two weeks. Statistics are refreshed
    /// every 12 hours for one week time windows, and once per day for two week time windows.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RelativeAggregationDuration
    {
        private TimeDimension _timeDimension;
        private int? _timeValue;

        /// <summary>
        /// Gets and sets the property TimeDimension. 
        /// <para>
        /// The type of time period that the <c>timeValue</c> field represents. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeDimension TimeDimension
        {
            get { return this._timeDimension; }
            set { this._timeDimension = value; }
        }

        // Check to see if TimeDimension property is set
        internal bool IsSetTimeDimension()
        {
            return this._timeDimension != null;
        }

        /// <summary>
        /// Gets and sets the property TimeValue. 
        /// <para>
        /// The period of the time window to gather statistics for. The valid value depends on
        /// the setting of the <c>timeDimension</c> field.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Hours</c> - 1/3/6/12/24
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Days</c> - 3
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Weeks</c> - 1/2
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24)]
        public int? TimeValue
        {
            get { return this._timeValue; }
            set { this._timeValue = value; }
        }

        // Check to see if TimeValue property is set
        internal bool IsSetTimeValue()
        {
            return this._timeValue.HasValue; 
        }

    }
}