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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A timestamp filter.
    /// </summary>
    public partial class TimestampFilter
    {
        private DateTime? _recordedAfter;
        private DateTime? _recordedBefore;

        /// <summary>
        /// Gets and sets the property RecordedAfter. 
        /// <para>
        /// The timestamp after which statistics should be included in the results.
        /// </para>
        /// </summary>
        public DateTime? RecordedAfter
        {
            get { return this._recordedAfter; }
            set { this._recordedAfter = value; }
        }

        // Check to see if RecordedAfter property is set
        internal bool IsSetRecordedAfter()
        {
            return this._recordedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordedBefore. 
        /// <para>
        /// The timestamp before which statistics should be included in the results.
        /// </para>
        /// </summary>
        public DateTime? RecordedBefore
        {
            get { return this._recordedBefore; }
            set { this._recordedBefore = value; }
        }

        // Check to see if RecordedBefore property is set
        internal bool IsSetRecordedBefore()
        {
            return this._recordedBefore.HasValue; 
        }

    }
}