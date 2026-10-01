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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTopic operation. Creates a new Q topic.
    /// </summary>
    public partial class CreateTopicRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that you want to create a topic in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomInstructions. 
        /// <para>
        /// Custom instructions for the topic.
        /// </para>
        /// </summary>
        public CustomInstructions CustomInstructions { get; set; }

        /// <summary>
        /// Checks to see if the CustomInstructions property is set.
        /// </summary>
        internal bool IsSetCustomInstructions() => this.CustomInstructions != null;

        /// <summary>
        /// Gets and sets the property FolderArns. 
        /// <para>
        /// The Folder ARN of the folder that you want the topic to reside in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> FolderArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FolderArns property is set.
        /// </summary>
        internal bool IsSetFolderArns() => this.FolderArns != null && (this.FolderArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags that are assigned
        /// to the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The definition of a topic to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TopicDetails Topic { get; set; }

        /// <summary>
        /// Checks to see if the Topic property is set.
        /// </summary>
        internal bool IsSetTopic() => this.Topic != null;

        /// <summary>
        /// Gets and sets the property TopicId. 
        /// <para>
        /// The ID for the topic that you want to create. This ID is unique per Amazon Web Services
        /// Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TopicId { get; set; }

        /// <summary>
        /// Checks to see if the TopicId property is set.
        /// </summary>
        internal bool IsSetTopicId() => this.TopicId != null;
    }
}
