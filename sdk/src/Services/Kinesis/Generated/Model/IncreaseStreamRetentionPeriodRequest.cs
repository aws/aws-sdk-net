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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the IncreaseStreamRetentionPeriod operation.
    /// Increases the Kinesis data stream's retention period, which is the length of time
    /// data records are accessible after they are added to the stream. The maximum value
    /// of a stream's retention period is 168 hours (7 days).
    /// 
    ///  
    /// <para>
    /// If you choose a longer stream retention period, this operation increases the time
    /// period during which records that have not yet expired are accessible. However, it
    /// does not make previous, expired data (older than the stream's previous retention period)
    /// accessible after the operation has been called. For example, if a stream's retention
    /// period is set to 24 hours and is increased to 168 hours, any data that is older than
    /// 24 hours remains inaccessible to consumer applications.
    /// </para>
    /// </summary>
    public partial class IncreaseStreamRetentionPeriodRequest : AmazonKinesisRequest
    {
        private int? _retentionPeriodHours;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property RetentionPeriodHours. 
        /// <para>
        /// The new retention period of the stream, in hours. Must be more than the current retention
        /// period.
        /// </para>
        /// </summary>
        public int RetentionPeriodHours
        {
            get { return this._retentionPeriodHours.GetValueOrDefault(); }
            set { this._retentionPeriodHours = value; }
        }

        // Check to see if RetentionPeriodHours property is set
        internal bool IsSetRetentionPeriodHours()
        {
            return this._retentionPeriodHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream to modify.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}