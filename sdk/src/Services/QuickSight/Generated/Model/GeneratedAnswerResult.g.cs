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
    /// The QA result that is made from generated answer.
    /// </summary>
    public partial class GeneratedAnswerResult
    {
        /// <summary>
        /// Gets and sets the property AnswerId. 
        /// <para>
        /// The ID of the answer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AnswerId { get; set; }

        /// <summary>
        /// Checks to see if the AnswerId property is set.
        /// </summary>
        internal bool IsSetAnswerId() => this.AnswerId != null;

        /// <summary>
        /// Gets and sets the property AnswerStatus. 
        /// <para>
        /// The answer status of the generated answer.
        /// </para>
        /// </summary>
        public GeneratedAnswerStatus AnswerStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnswerStatus property is set.
        /// </summary>
        internal bool IsSetAnswerStatus() => this.AnswerStatus != null;

        /// <summary>
        /// Gets and sets the property QuestionId. 
        /// <para>
        /// The ID of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionId property is set.
        /// </summary>
        internal bool IsSetQuestionId() => this.QuestionId != null;

        /// <summary>
        /// Gets and sets the property QuestionText. 
        /// <para>
        /// The question text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string QuestionText { get; set; }

        /// <summary>
        /// Checks to see if the QuestionText property is set.
        /// </summary>
        internal bool IsSetQuestionText() => this.QuestionText != null;

        /// <summary>
        /// Gets and sets the property QuestionUrl. 
        /// <para>
        /// The URL of the question.
        /// </para>
        /// </summary>
        public string QuestionUrl { get; set; }

        /// <summary>
        /// Checks to see if the QuestionUrl property is set.
        /// </summary>
        internal bool IsSetQuestionUrl() => this.QuestionUrl != null;

        /// <summary>
        /// Gets and sets the property Restatement. 
        /// <para>
        /// The restatement for the answer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Restatement { get; set; }

        /// <summary>
        /// Checks to see if the Restatement property is set.
        /// </summary>
        internal bool IsSetRestatement() => this.Restatement != null;

        /// <summary>
        /// Gets and sets the property TopicId. 
        /// <para>
        /// The ID of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TopicId { get; set; }

        /// <summary>
        /// Checks to see if the TopicId property is set.
        /// </summary>
        internal bool IsSetTopicId() => this.TopicId != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
