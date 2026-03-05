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
    /// Container for the parameters to the UpdateMaxRecordSize operation.
    /// This allows you to update the <c>MaxRecordSize</c> of a single record that you can
    /// write to, and read from a stream. You can ingest and digest single records up to 10240
    /// KiB.
    /// </summary>
    public partial class UpdateMaxRecordSizeRequest : AmazonKinesisRequest
    {
        private int? _maxRecordSizeInKiB;
        private string _streamARN;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property MaxRecordSizeInKiB. 
        /// <para>
        /// The maximum record size of a single record in KiB that you can write to, and read
        /// from a stream. Specify a value between 1024 and 10240 KiB (1 to 10 MiB). If you specify
        /// a value that is out of this range, <c>UpdateMaxRecordSize</c> sends back an <c>ValidationException</c>
        /// message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1024, Max=10240)]
        public int? MaxRecordSizeInKiB
        {
            get { return this._maxRecordSizeInKiB; }
            set { this._maxRecordSizeInKiB = value; }
        }

        // Check to see if MaxRecordSizeInKiB property is set
        internal bool IsSetMaxRecordSizeInKiB()
        {
            return this._maxRecordSizeInKiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream for the <c>MaxRecordSize</c> update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Not Implemented. Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}