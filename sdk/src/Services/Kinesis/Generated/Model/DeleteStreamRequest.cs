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
    /// Container for the parameters to the DeleteStream operation.
    /// Deletes a Kinesis data stream and all its shards and data. You must shut down any
    /// applications that are operating on the stream before you delete the stream. If an
    /// application attempts to operate on a deleted stream, it receives the exception <code>ResourceNotFoundException</code>.
    /// 
    ///  
    /// <para>
    /// If the stream is in the <code>ACTIVE</code> state, you can delete it. After a <code>DeleteStream</code>
    /// request, the specified stream is in the <code>DELETING</code> state until Kinesis
    /// Data Streams completes the deletion.
    /// </para>
    ///  
    /// <para>
    ///  <b>Note:</b> Kinesis Data Streams might continue to accept data read and write operations,
    /// such as <a>PutRecord</a>, <a>PutRecords</a>, and <a>GetRecords</a>, on a stream in
    /// the <code>DELETING</code> state until the stream deletion is complete.
    /// </para>
    ///  
    /// <para>
    /// When you delete a stream, any shards in that stream are also deleted, and any tags
    /// are dissociated from the stream.
    /// </para>
    ///  
    /// <para>
    /// You can use the <a>DescribeStream</a> operation to check the state of the stream,
    /// which is returned in <code>StreamStatus</code>.
    /// </para>
    ///  
    /// <para>
    ///  <a>DeleteStream</a> has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class DeleteStreamRequest : AmazonKinesisRequest
    {
        private bool? _enforceConsumerDeletion;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property EnforceConsumerDeletion. 
        /// <para>
        /// If this parameter is unset (<code>null</code>) or if you set it to <code>false</code>,
        /// and the stream has registered consumers, the call to <code>DeleteStream</code> fails
        /// with a <code>ResourceInUseException</code>. 
        /// </para>
        /// </summary>
        public bool EnforceConsumerDeletion
        {
            get { return this._enforceConsumerDeletion.GetValueOrDefault(); }
            set { this._enforceConsumerDeletion = value; }
        }

        // Check to see if EnforceConsumerDeletion property is set
        internal bool IsSetEnforceConsumerDeletion()
        {
            return this._enforceConsumerDeletion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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