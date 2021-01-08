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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <code>DescribeStream</code>.
    /// </summary>
    public partial class DescribeStreamResponse : AmazonWebServiceResponse
    {
        private StreamDescription _streamDescription;

        /// <summary>
        /// Gets and sets the property StreamDescription. 
        /// <para>
        /// The current status of the stream, the stream Amazon Resource Name (ARN), an array
        /// of shard objects that comprise the stream, and whether there are more shards available.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamDescription StreamDescription
        {
            get { return this._streamDescription; }
            set { this._streamDescription = value; }
        }

        // Check to see if StreamDescription property is set
        internal bool IsSetStreamDescription()
        {
            return this._streamDescription != null;
        }

    }
}