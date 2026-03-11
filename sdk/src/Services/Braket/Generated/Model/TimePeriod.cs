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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Defines a time range for spending limits, specifying when the limit is active.
    /// </summary>
    public partial class TimePeriod
    {
        private DateTime? _endAt;
        private DateTime? _startAt;

        /// <summary>
        /// Gets and sets the property EndAt. 
        /// <para>
        /// The end date and time for the spending limit period, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndAt
        {
            get { return this._endAt; }
            set { this._endAt = value; }
        }

        // Check to see if EndAt property is set
        internal bool IsSetEndAt()
        {
            return this._endAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The start date and time for the spending limit period, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartAt
        {
            get { return this._startAt; }
            set { this._startAt = value; }
        }

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this._startAt.HasValue; 
        }

    }
}