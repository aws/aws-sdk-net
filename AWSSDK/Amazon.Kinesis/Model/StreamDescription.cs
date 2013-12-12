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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <para>Represents the output of a <c>DescribeStream</c> operation.</para>
    /// </summary>
    public partial class StreamDescription
    {
        
        private string streamName;
        private string streamARN;
        private string streamStatus;
        private List<Shard> shards = new List<Shard>();
        private bool? hasMoreShards;

        /// <summary>
        /// The name of the stream being described.
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

        /// <summary>
        /// Sets the StreamName property
        /// </summary>
        /// <param name="streamName">The value to set for the StreamName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamDescription WithStreamName(string streamName)
        {
            this.streamName = streamName;
            return this;
        }
            

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this.streamName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the stream being described.
        ///  
        /// </summary>
        public string StreamARN
        {
            get { return this.streamARN; }
            set { this.streamARN = value; }
        }

        /// <summary>
        /// Sets the StreamARN property
        /// </summary>
        /// <param name="streamARN">The value to set for the StreamARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamDescription WithStreamARN(string streamARN)
        {
            this.streamARN = streamARN;
            return this;
        }
            

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this.streamARN != null;
        }

        /// <summary>
        /// The current status of the stream being described. The stream status is one of the following states: <ul> <li>CREATING - The stream is being
        /// created. Upon receiving a <a>CreateStream</a> request, Amazon Kinesis immediately returns and sets <c>StreamStatus</c> to CREATING.</li>
        /// <li>DELETING - The stream is being deleted. After a <a>DeleteStream</a> request, the specified stream is in the DELETING state until Amazon
        /// Kinesis completes the deletion.</li> <li>ACTIVE - The stream exists and is ready for read and write operations or deletion. You should
        /// perform read and write operations only on an ACTIVE stream.</li> <li>UPDATING - Shards in the stream are being merged or split. Read and
        /// write operations continue to work while the stream is in the UPDATING state.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATING, DELETING, ACTIVE, UPDATING</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StreamStatus
        {
            get { return this.streamStatus; }
            set { this.streamStatus = value; }
        }

        /// <summary>
        /// Sets the StreamStatus property
        /// </summary>
        /// <param name="streamStatus">The value to set for the StreamStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamDescription WithStreamStatus(string streamStatus)
        {
            this.streamStatus = streamStatus;
            return this;
        }
            

        // Check to see if StreamStatus property is set
        internal bool IsSetStreamStatus()
        {
            return this.streamStatus != null;
        }

        /// <summary>
        /// The shards that comprise the stream.
        ///  
        /// </summary>
        public List<Shard> Shards
        {
            get { return this.shards; }
            set { this.shards = value; }
        }
        /// <summary>
        /// Adds elements to the Shards collection
        /// </summary>
        /// <param name="shards">The values to add to the Shards collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamDescription WithShards(params Shard[] shards)
        {
            foreach (Shard element in shards)
            {
                this.shards.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Shards collection
        /// </summary>
        /// <param name="shards">The values to add to the Shards collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamDescription WithShards(IEnumerable<Shard> shards)
        {
            foreach (Shard element in shards)
            {
                this.shards.Add(element);
            }

            return this;
        }

        // Check to see if Shards property is set
        internal bool IsSetShards()
        {
            return this.shards.Count > 0;
        }

        /// <summary>
        /// If set to <c>true</c> there are more shards in the stream available to describe.
        ///  
        /// </summary>
        public bool HasMoreShards
        {
            get { return this.hasMoreShards ?? default(bool); }
            set { this.hasMoreShards = value; }
        }

        /// <summary>
        /// Sets the HasMoreShards property
        /// </summary>
        /// <param name="hasMoreShards">The value to set for the HasMoreShards property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamDescription WithHasMoreShards(bool hasMoreShards)
        {
            this.hasMoreShards = hasMoreShards;
            return this;
        }
            

        // Check to see if HasMoreShards property is set
        internal bool IsSetHasMoreShards()
        {
            return this.hasMoreShards.HasValue;
        }
    }
}
