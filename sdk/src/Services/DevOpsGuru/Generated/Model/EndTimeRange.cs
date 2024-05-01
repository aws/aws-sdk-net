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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A range of time that specifies when anomalous behavior in an anomaly or insight ended.
    /// </summary>
    public partial class EndTimeRange
    {
        private DateTime? _fromTime;
        private DateTime? _toTime;

        /// <summary>
        /// Gets and sets the property FromTime. 
        /// <para>
        ///  The earliest end time in the time range. 
        /// </para>
        /// </summary>
        public DateTime? FromTime
        {
            get { return this._fromTime; }
            set { this._fromTime = value; }
        }

        // Check to see if FromTime property is set
        internal bool IsSetFromTime()
        {
            return this._fromTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToTime. 
        /// <para>
        ///  The latest end time in the time range. 
        /// </para>
        /// </summary>
        public DateTime? ToTime
        {
            get { return this._toTime; }
            set { this._toTime = value; }
        }

        // Check to see if ToTime property is set
        internal bool IsSetToTime()
        {
            return this._toTime.HasValue; 
        }

    }
}