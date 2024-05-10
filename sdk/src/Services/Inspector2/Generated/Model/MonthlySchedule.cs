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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A monthly schedule.
    /// </summary>
    public partial class MonthlySchedule
    {
        private Day _day;
        private Time _startTime;

        /// <summary>
        /// Gets and sets the property Day. 
        /// <para>
        /// The monthly schedule's day.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Day Day
        {
            get { return this._day; }
            set { this._day = value; }
        }

        // Check to see if Day property is set
        internal bool IsSetDay()
        {
            return this._day != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The monthly schedule's start time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Time StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}