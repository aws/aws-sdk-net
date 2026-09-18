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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details for an S3 bucket notification configuration.
    /// </summary>
    public partial class AwsS3BucketNotificationConfigurationDetail
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The ARN of the Lambda function, Amazon SQS queue, or Amazon SNS topic that generates
        /// the notification.
        /// </para>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The list of events that trigger a notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filters that determine which S3 buckets generate notifications.
        /// </para>
        /// </summary>
        public AwsS3BucketNotificationConfigurationFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates the type of notification. Notifications can be generated using Lambda functions,
        /// Amazon SQS queues, or Amazon SNS topics, with corresponding valid values as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LambdaConfiguration</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QueueConfiguration</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TopicConfiguration</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
