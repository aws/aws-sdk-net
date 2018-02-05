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
    /// Container for the parameters to the DecreaseStreamRetentionPeriod operation.
    /// Decreases the Kinesis data stream's retention period, which is the length of time
    /// data records are accessible after they are added to the stream. The minimum value
    /// of a stream's retention period is 24 hours.
    /// 
    ///  
    /// <para>
    /// This operation may result in lost data. For example, if the stream's retention period
    /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
    /// than 24 hours is inaccessible.
    /// </para>
    /// </summary>
    public partial class DecreaseStreamRetentionPeriodRequest : AmazonKinesisRequest
    {
        private int? _retentionPeriodHours;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property RetentionPeriodHours. 
        /// <para>
        /// The new retention period of the stream, in hours. Must be less than the current retention
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