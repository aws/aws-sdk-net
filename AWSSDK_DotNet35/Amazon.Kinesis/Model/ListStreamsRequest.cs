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
    /// Container for the parameters to the ListStreams operation.
    /// <para> This operation returns an array of the names of all the streams that are associated with the AWS account making the
    /// <c>ListStreams</c> request. A given AWS account can have many streams active at one time. </para> <para> The number of streams may be too
    /// large to return from a single call to <c>ListStreams</c> .
    /// You can limit the number of returned streams using the <c>Limit</c> parameter. If you do not specify a value for the
    /// <c>Limit</c> parameter, Amazon Kinesis uses the default limit, which is currently 10.</para> <para> You can detect if there are more streams
    /// available to list by using the <c>HasMoreStreams</c> flag from the returned output. If there are more streams available, you can request
    /// more streams by using the name of the last stream returned by the <c>ListStreams</c> request in the <c>ExclusiveStartStreamName</c>
    /// parameter in a subsequent request to <c>ListStreams</c> .
    /// The group of stream names returned by the subsequent request is then added to the list. You can continue this process until all
    /// the stream names have been collected in the list. </para> <para> <c>ListStreams</c> has a limit of 5 transactions per second per
    /// account.</para>
    /// </summary>
    public partial class ListStreamsRequest : AmazonKinesisRequest
    {
        private int? limit;
        private string exclusiveStartStreamName;


        /// <summary>
        /// The maximum number of streams to list.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 10000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

        /// <summary>
        /// The name of the stream to start the list with.
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
        public string ExclusiveStartStreamName
        {
            get { return this.exclusiveStartStreamName; }
            set { this.exclusiveStartStreamName = value; }
        }

        // Check to see if ExclusiveStartStreamName property is set
        internal bool IsSetExclusiveStartStreamName()
        {
            return this.exclusiveStartStreamName != null;
        }

    }
}
    
