/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RecencyDimension
    {
        private Duration _duration;
        private RecencyType _recencyType;

        /// <summary>
        /// Gets and sets the property Duration. The length of time during which users have been
        /// active or inactive with your app.Valid values: HR_24, DAY_7, DAY_14, DAY_30
        /// </summary>
        public Duration Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property RecencyType. The recency dimension type:ACTIVE – Users
        /// who have used your app within the specified duration are included in the segment.INACTIVE
        /// – Users who have not used your app within the specified duration are included in the
        /// segment.
        /// </summary>
        public RecencyType RecencyType
        {
            get { return this._recencyType; }
            set { this._recencyType = value; }
        }

        // Check to see if RecencyType property is set
        internal bool IsSetRecencyType()
        {
            return this._recencyType != null;
        }

    }
}