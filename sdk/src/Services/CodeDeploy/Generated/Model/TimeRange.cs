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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a time range.
    /// </summary>
    public partial class TimeRange
    {
        private DateTime? _end;
        private DateTime? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time of the time range.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify null to leave the end time open-ended.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time of the time range.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify null to leave the start time open-ended.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}