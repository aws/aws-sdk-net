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
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches a resource-based policy to a data stream or registered consumer. If you are
    /// using an identity other than the root user of the Amazon Web Services account that
    /// owns the resource, the calling identity must have the <c>PutResourcePolicy</c> permissions
    /// on the specified Kinesis Data Streams resource and belong to the owner's account in
    /// order to use this operation. If you don't have <c>PutResourcePolicy</c> permissions,
    /// Amazon Kinesis Data Streams returns a <c>403 Access Denied error</c>. If you receive
    /// a <c>ResourceNotFoundException</c>, check to see if you passed a valid stream or consumer
    /// resource. 
    /// 
    ///  
    /// <para>
    ///  Request patterns can be one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Data stream pattern: <c>arn:aws.*:kinesis:.*:\d{12}:.*stream/\S+</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Consumer pattern: <c>^(arn):aws.*:kinesis:.*:\d{12}:.*stream\/[a-zA-Z0-9_.-]+\/consumer\/[a-zA-Z0-9_.-]+:[0-9]+</c>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
    /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
    /// </para>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonKinesisRequest
    {
        private string _policy;
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Details of the resource policy. It must include the identity of the principal and
        /// the actions allowed on this resource. This is formatted as a JSON string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data stream or consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

    }
}