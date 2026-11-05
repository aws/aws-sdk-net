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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The configuration for the Amazon MSK cluster to be used as the source for a delivery
    /// stream.
    /// </summary>
    public partial class MSKSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration of the Amazon MSK cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationConfiguration AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfiguration() => this.AuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property MSKClusterARN. 
        /// <para>
        /// The ARN of the Amazon MSK cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string MSKClusterARN { get; set; }

        /// <summary>
        /// Checks to see if the MSKClusterARN property is set.
        /// </summary>
        internal bool IsSetMSKClusterARN() => this.MSKClusterARN != null;

        /// <summary>
        /// Gets and sets the property ReadFromTimestamp. 
        /// <para>
        /// The start date and time in UTC for the offset position within your MSK topic from
        /// where Firehose begins to read. By default, this is set to timestamp when Firehose
        /// becomes Active. 
        /// </para>
        ///  
        /// <para>
        /// If you want to create a Firehose stream with Earliest start position from SDK or CLI,
        /// you need to set the <c>ReadFromTimestamp</c> parameter to Epoch (1970-01-01T00:00:00Z).
        /// 
        /// </para>
        /// </summary>
        public DateTime? ReadFromTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReadFromTimestamp property is set.
        /// </summary>
        internal bool IsSetReadFromTimestamp() => this.ReadFromTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The topic name within the Amazon MSK cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
