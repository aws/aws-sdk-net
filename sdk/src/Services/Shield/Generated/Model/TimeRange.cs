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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// The time range.
    /// </summary>
    public partial class TimeRange
    {
        private DateTime? _fromInclusive;
        private DateTime? _toExclusive;

        /// <summary>
        /// Gets and sets the property FromInclusive. 
        /// <para>
        /// The start time, in the format 2016-12-16T13:50Z.
        /// </para>
        /// </summary>
        public DateTime FromInclusive
        {
            get { return this._fromInclusive.GetValueOrDefault(); }
            set { this._fromInclusive = value; }
        }

        // Check to see if FromInclusive property is set
        internal bool IsSetFromInclusive()
        {
            return this._fromInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToExclusive. 
        /// <para>
        /// The end time, in the format 2016-12-16T15:50Z.
        /// </para>
        /// </summary>
        public DateTime ToExclusive
        {
            get { return this._toExclusive.GetValueOrDefault(); }
            set { this._toExclusive = value; }
        }

        // Check to see if ToExclusive property is set
        internal bool IsSetToExclusive()
        {
            return this._toExclusive.HasValue; 
        }

    }
}