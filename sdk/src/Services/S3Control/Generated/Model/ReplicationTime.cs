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
    /// A container that specifies S3 Replication Time Control (S3 RTC) related information,
    /// including whether S3 RTC is enabled and the time when all objects and operations on
    /// objects must be replicated.
    /// 
    ///  <note> 
    /// <para>
    /// This is not supported by Amazon S3 on Outposts buckets.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReplicationTime
    {
        private ReplicationTimeStatus _status;
        private ReplicationTimeValue _time;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether S3 Replication Time Control (S3 RTC) is enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationTimeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// A container that specifies the time by which replication should be complete for all
        /// objects and operations on objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationTimeValue Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

    }
}