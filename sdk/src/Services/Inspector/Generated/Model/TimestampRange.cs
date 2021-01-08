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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used in the <a>AssessmentRunFilter</a> data type.
    /// </summary>
    public partial class TimestampRange
    {
        private DateTime? _beginDate;
        private DateTime? _endDate;

        /// <summary>
        /// Gets and sets the property BeginDate. 
        /// <para>
        /// The minimum value of the timestamp range.
        /// </para>
        /// </summary>
        public DateTime BeginDate
        {
            get { return this._beginDate.GetValueOrDefault(); }
            set { this._beginDate = value; }
        }

        // Check to see if BeginDate property is set
        internal bool IsSetBeginDate()
        {
            return this._beginDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The maximum value of the timestamp range.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

    }
}