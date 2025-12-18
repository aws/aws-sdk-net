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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Amazon S3 keys for log objects are partitioned in the following format:
    /// 
    ///  
    /// <para>
    ///  <c>[DestinationPrefix][SourceAccountId]/[SourceRegion]/[SourceBucket]/[YYYY]/[MM]/[DD]/[YYYY]-[MM]-[DD]-[hh]-[mm]-[ss]-[UniqueString]</c>
    /// 
    /// </para>
    ///  
    /// <para>
    /// PartitionedPrefix defaults to EventTime delivery when server access logs are delivered.
    /// </para>
    /// </summary>
    public partial class PartitionedPrefix
    {
        private PartitionDateSource _partitionDateSource;

        /// <summary>
        /// Gets and sets the property PartitionDateSource. 
        /// <para>
        /// Specifies the partition date source for the partitioned prefix. <c>PartitionDateSource</c>
        /// can be <c>EventTime</c> or <c>DeliveryTime</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>DeliveryTime</c>, the time in the log file names corresponds to the delivery
        /// time for the log files. 
        /// </para>
        ///  
        /// <para>
        ///  For <c>EventTime</c>, The logs delivered are for a specific day only. The year, month,
        /// and day correspond to the day on which the event occurred, and the hour, minutes and
        /// seconds are set to 00 in the key.
        /// </para>
        /// </summary>
        public PartitionDateSource PartitionDateSource
        {
            get { return this._partitionDateSource; }
            set { this._partitionDateSource = value; }
        }

        // Check to see if PartitionDateSource property is set
        internal bool IsSetPartitionDateSource()
        {
            return this._partitionDateSource != null;
        }

    }
}