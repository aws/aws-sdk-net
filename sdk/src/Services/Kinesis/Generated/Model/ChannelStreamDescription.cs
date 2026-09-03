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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Describes the source stream of a channel.
    /// </summary>
    public partial class ChannelStreamDescription
    {
        private RecordConfiguration _recordConfiguration;
        private string _streamARN;
        private DateTime? _streamCreationTimestamp;

        /// <summary>
        /// Gets and sets the property RecordConfiguration. 
        /// <para>
        /// The record format configuration for the source stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordConfiguration RecordConfiguration
        {
            get { return this._recordConfiguration; }
            set { this._recordConfiguration = value; }
        }

        // Check to see if RecordConfiguration property is set
        internal bool IsSetRecordConfiguration()
        {
            return this._recordConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source Kinesis data stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamCreationTimestamp. 
        /// <para>
        /// The time at which the source stream was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StreamCreationTimestamp
        {
            get { return this._streamCreationTimestamp; }
            set { this._streamCreationTimestamp = value; }
        }

        // Check to see if StreamCreationTimestamp property is set
        internal bool IsSetStreamCreationTimestamp()
        {
            return this._streamCreationTimestamp.HasValue; 
        }

    }
}