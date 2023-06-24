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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container that specifies the time value for S3 Replication Time Control (S3 RTC).
    /// This value is also used for the replication metrics <code>EventThreshold</code> element.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// This is not supported by Amazon S3 on Outposts buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReplicationTimeValue
    {
        private int? _minutes;

        /// <summary>
        /// Gets and sets the property Minutes. 
        /// <para>
        /// Contains an integer that specifies the time period in minutes. 
        /// </para>
        ///  
        /// <para>
        /// Valid value: 15
        /// </para>
        /// </summary>
        public int Minutes
        {
            get { return this._minutes.GetValueOrDefault(); }
            set { this._minutes = value; }
        }

        // Check to see if Minutes property is set
        internal bool IsSetMinutes()
        {
            return this._minutes.HasValue; 
        }

    }
}