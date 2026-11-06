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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether S3 Replication Time Control (S3 RTC) is enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationTimeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// A container that specifies the time by which replication should be complete for all
        /// objects and operations on objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationTimeValue Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null;
    }
}
