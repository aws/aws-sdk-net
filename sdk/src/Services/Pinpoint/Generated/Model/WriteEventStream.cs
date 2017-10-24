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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Request to save an EventStream.
    /// </summary>
    public partial class WriteEventStream
    {
        private string _destinationStreamArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DestinationStreamArn. The Amazon Resource Name (ARN) of
        /// the Amazon Kinesis stream or Firehose delivery stream to which you want to publish
        /// events. Firehose ARN: arn:aws:firehose:REGION:ACCOUNT_ID:deliverystream/STREAM_NAME
        /// Kinesis ARN: arn:aws:kinesis:REGION:ACCOUNT_ID:stream/STREAM_NAME
        /// </summary>
        public string DestinationStreamArn
        {
            get { return this._destinationStreamArn; }
            set { this._destinationStreamArn = value; }
        }

        // Check to see if DestinationStreamArn property is set
        internal bool IsSetDestinationStreamArn()
        {
            return this._destinationStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role that authorizes Amazon Pinpoint to
        /// publish events to the stream in your account.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}