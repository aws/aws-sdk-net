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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataRetention operation. Increases or decreases
    /// the stream's data retention period by the value that you specify. To indicate whether
    /// you want to increase or decrease the data retention period, specify the <c>Operation</c>
    /// parameter in the request body. In the request, you must specify either the <c>StreamName</c>
    /// or the <c>StreamARN</c>. <para> This operation requires permission for the <c>KinesisVideo:UpdateDataRetention</c>
    /// action. </para> <para> Changing the data retention period affects the data in the
    /// stream as follows: </para> <ul> <li> <para> If the data retention period is increased,
    /// existing data is retained for the new retention period. For example, if the data retention
    /// period is increased from one hour to seven hours, all existing data is retained for
    /// seven hours. </para> </li> <li> <para> If the data retention period is decreased,
    /// existing data is retained for the new retention period. For example, if the data retention
    /// period is decreased from seven hours to one hour, all existing data is retained for
    /// one hour, and any data older than one hour is deleted immediately. </para> </li> </ul>
    /// </summary>
    public partial class UpdateDataRetentionRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the stream whose retention period you want to change. To get the version,
        /// call either the <c>DescribeStream</c> or the <c>ListStreams</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property DataRetentionChangeInHours. 
        /// <para>
        /// The number of hours to adjust the current retention by. The value you specify is added
        /// to or subtracted from the current value, depending on the <c>operation</c>.
        /// </para>
        ///  
        /// <para>
        /// The minimum value for data retention is 0 and the maximum value is 87600 (ten years).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? DataRetentionChangeInHours { get; set; }

        /// <summary>
        /// Checks to see if the DataRetentionChangeInHours property is set.
        /// </summary>
        internal bool IsSetDataRetentionChangeInHours() => this.DataRetentionChangeInHours.HasValue;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// Indicates whether you want to increase or decrease the retention period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateDataRetentionOperation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream whose retention period you want to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream whose retention period you want to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
