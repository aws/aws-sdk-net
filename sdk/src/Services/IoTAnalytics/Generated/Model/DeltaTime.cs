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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Used to limit data to that which has arrived since the last execution of the action.
    /// </summary>
    public partial class DeltaTime
    {
        private int? _offsetSeconds;
        private string _timeExpression;

        /// <summary>
        /// Gets and sets the property OffsetSeconds. 
        /// <para>
        /// The number of seconds of estimated in-flight lag time of message data. When you create
        /// dataset contents using message data from a specified timeframe, some message data
        /// might still be in flight when processing begins, and so do not arrive in time to be
        /// processed. Use this field to make allowances for the in flight time of your message
        /// data, so that data not processed from a previous timeframe is included with the next
        /// timeframe. Otherwise, missed message data would be excluded from processing during
        /// the next timeframe too, because its timestamp places it within the previous timeframe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? OffsetSeconds
        {
            get { return this._offsetSeconds; }
            set { this._offsetSeconds = value; }
        }

        // Check to see if OffsetSeconds property is set
        internal bool IsSetOffsetSeconds()
        {
            return this._offsetSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeExpression. 
        /// <para>
        /// An expression by which the time of the message data might be determined. This can
        /// be the name of a timestamp field or a SQL expression that is used to derive the time
        /// the message data was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TimeExpression
        {
            get { return this._timeExpression; }
            set { this._timeExpression = value; }
        }

        // Check to see if TimeExpression property is set
        internal bool IsSetTimeExpression()
        {
            return this._timeExpression != null;
        }

    }
}