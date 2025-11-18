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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the DescribeTopicPartitions operation.
    /// </summary>
    public partial class DescribeTopicPartitionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TopicPartitionInfo> _partitions = AWSConfigs.InitializeCollections ? new List<TopicPartitionInfo>() : null;

        /// <summary>
        /// Gets and sets the property NextToken.             
        /// <para>
        /// The paginated results marker. When the result of a DescribeTopicPartitions operation
        /// is truncated, the call returns NextToken in the response.                To get another
        /// batch of configurations, provide this token in your next request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Partitions. 
        /// <para>
        /// The list of partition information for the topic.
        /// </para>
        /// </summary>
        public List<TopicPartitionInfo> Partitions
        {
            get { return this._partitions; }
            set { this._partitions = value; }
        }

        // Check to see if Partitions property is set
        internal bool IsSetPartitions()
        {
            return this._partitions != null && (this._partitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}