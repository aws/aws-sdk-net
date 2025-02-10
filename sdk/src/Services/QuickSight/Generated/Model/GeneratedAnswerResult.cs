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
    /// The QA result that is made from generated answer.
    /// </summary>
    public partial class GeneratedAnswerResult
    {
        private string _answerId;
        private GeneratedAnswerStatus _answerStatus;
        private string _questionId;
        private string _questionText;
        private string _questionUrl;
        private string _restatement;
        private string _topicId;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property AnswerId. 
        /// <para>
        /// The ID of the answer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AnswerId
        {
            get { return this._answerId; }
            set { this._answerId = value; }
        }

        // Check to see if AnswerId property is set
        internal bool IsSetAnswerId()
        {
            return this._answerId != null;
        }

        /// <summary>
        /// Gets and sets the property AnswerStatus. 
        /// <para>
        /// The answer status of the generated answer.
        /// </para>
        /// </summary>
        public GeneratedAnswerStatus AnswerStatus
        {
            get { return this._answerStatus; }
            set { this._answerStatus = value; }
        }

        // Check to see if AnswerStatus property is set
        internal bool IsSetAnswerStatus()
        {
            return this._answerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionId. 
        /// <para>
        /// The ID of the question.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string QuestionId
        {
            get { return this._questionId; }
            set { this._questionId = value; }
        }

        // Check to see if QuestionId property is set
        internal bool IsSetQuestionId()
        {
            return this._questionId != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionText. 
        /// <para>
        /// The question text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string QuestionText
        {
            get { return this._questionText; }
            set { this._questionText = value; }
        }

        // Check to see if QuestionText property is set
        internal bool IsSetQuestionText()
        {
            return this._questionText != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionUrl. 
        /// <para>
        /// The URL of the question.
        /// </para>
        /// </summary>
        public string QuestionUrl
        {
            get { return this._questionUrl; }
            set { this._questionUrl = value; }
        }

        // Check to see if QuestionUrl property is set
        internal bool IsSetQuestionUrl()
        {
            return this._questionUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Restatement. 
        /// <para>
        /// The restatement for the answer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Restatement
        {
            get { return this._restatement; }
            set { this._restatement = value; }
        }

        // Check to see if Restatement property is set
        internal bool IsSetRestatement()
        {
            return this._restatement != null;
        }

        /// <summary>
        /// Gets and sets the property TopicId. 
        /// <para>
        /// The ID of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}