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
    /// Container for the parameters to the DescribeStreamSummary operation.
    /// Provides a summarized description of the specified Kinesis data stream without the
    /// shard list.
    /// 
    ///  
    /// <para>
    /// The information returned includes the stream name, Amazon Resource Name (ARN), status,
    /// record retention period, approximate creation time, monitoring, encryption details,
    /// and open shard count. 
    /// </para>
    /// </summary>
    public partial class DescribeStreamSummaryRequest : AmazonKinesisRequest
    {
        private string _streamName;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream to describe.
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