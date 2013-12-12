/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DeleteStream operation.
    /// <para>This operation deletes a stream and all of its shards and data. You must shut down any applications that are operating on the stream
    /// before you delete the stream. If an application attempts to operate on a deleted stream, it will receive the exception
    /// <c>ResourceNotFoundException</c> .</para> <para>If the stream is in the ACTIVE state, you can delete it. After a <c>DeleteStream</c>
    /// request, the specified stream is in the DELETING state until Amazon Kinesis completes the deletion.</para> <para> <b>Note:</b> Amazon
    /// Kinesis might continue to accept data read and write operations, such as PutRecord and GetRecords, on a stream in the DELETING state until
    /// the stream deletion is complete.</para> <para>When you delete a stream, any shards in that stream are also deleted.</para> <para>You can use
    /// the DescribeStream operation to check the state of the stream, which is returned in <c>StreamStatus</c> .</para> <para> <c>DeleteStream</c>
    /// has a limit of 5 transactions per second per account.</para>
    /// </summary>
    public partial class DeleteStreamRequest : AmazonKinesisRequest
    {
        private string streamName;


        /// <summary>
        /// The name of the stream to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this.streamName; }
            set { this.streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this.streamName != null;
        }

    }
}
    
