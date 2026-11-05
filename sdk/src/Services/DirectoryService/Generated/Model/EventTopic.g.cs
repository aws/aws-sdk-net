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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Information about Amazon SNS topic and Directory Service directory associations.
    /// </summary>
    public partial class EventTopic
    {
        /// <summary>
        /// Gets and sets the property CreatedDateTime. 
        /// <para>
        /// The date and time of when you associated your directory with the Amazon SNS topic.
        /// </para>
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDateTime property is set.
        /// </summary>
        internal bool IsSetCreatedDateTime() => this.CreatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of an Directory Service directory that will publish status messages
        /// to an Amazon SNS topic.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The topic registration status.
        /// </para>
        /// </summary>
        public TopicStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon SNS topic ARN (Amazon Resource Name).
        /// </para>
        /// </summary>
        public string TopicArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicArn property is set.
        /// </summary>
        internal bool IsSetTopicArn() => this.TopicArn != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of an Amazon SNS topic the receives status messages from the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
