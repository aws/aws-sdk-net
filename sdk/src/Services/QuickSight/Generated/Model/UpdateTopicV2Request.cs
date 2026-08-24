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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the UpdateTopicV2 operation.
    /// Updates the definition of a Q topic.
    /// </summary>
    public partial class UpdateTopicV2Request : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private CustomInstructions _customInstructions;
        private TopicV2PublishOption _publishOption;
        private TopicV2Details _topic;
        private string _topicId;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the topic that you want to
        /// update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomInstructions.
        /// </summary>
        public CustomInstructions CustomInstructions
        {
            get { return this._customInstructions; }
            set { this._customInstructions = value; }
        }

        // Check to see if CustomInstructions property is set
        internal bool IsSetCustomInstructions()
        {
            return this._customInstructions != null;
        }

        /// <summary>
        /// Gets and sets the property PublishOption. 
        /// <para>
        /// The publish option for the topic that you want to update.
        /// </para>
        /// </summary>
        public TopicV2PublishOption PublishOption
        {
            get { return this._publishOption; }
            set { this._publishOption = value; }
        }

        // Check to see if PublishOption property is set
        internal bool IsSetPublishOption()
        {
            return this._publishOption != null;
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The definition of the topic that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TopicV2Details Topic
        {
            get { return this._topic; }
            set { this._topic = value; }
        }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this._topic != null;
        }

        /// <summary>
        /// Gets and sets the property TopicId. 
        /// <para>
        /// The ID of the topic that you want to modify. This ID is unique per Amazon Web Services
        /// Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string TopicId
        {
            get { return this._topicId; }
            set { this._topicId = value; }
        }

        // Check to see if TopicId property is set
        internal bool IsSetTopicId()
        {
            return this._topicId != null;
        }

    }
}