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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Information about one mention of an entity. The mention information includes the location
    /// of the mention in the text and the sentiment of the mention.
    /// 
    ///  
    /// <para>
    /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
    /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetedSentimentMention
    {
        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The offset into the document text where the mention begins.
        /// </para>
        /// </summary>
        public int? BeginOffset { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffset property is set.
        /// </summary>
        internal bool IsSetBeginOffset() => this.BeginOffset.HasValue;

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The offset into the document text where the mention ends.
        /// </para>
        /// </summary>
        public int? EndOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndOffset property is set.
        /// </summary>
        internal bool IsSetEndOffset() => this.EndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property GroupScore. 
        /// <para>
        /// The confidence that all the entities mentioned in the group relate to the same entity.
        /// </para>
        /// </summary>
        public float? GroupScore { get; set; }

        /// <summary>
        /// Checks to see if the GroupScore property is set.
        /// </summary>
        internal bool IsSetGroupScore() => this.GroupScore.HasValue;

        /// <summary>
        /// Gets and sets the property MentionSentiment. 
        /// <para>
        /// Contains the sentiment and sentiment score for the mention.
        /// </para>
        /// </summary>
        public MentionSentiment MentionSentiment { get; set; }

        /// <summary>
        /// Checks to see if the MentionSentiment property is set.
        /// </summary>
        internal bool IsSetMentionSentiment() => this.MentionSentiment != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// Model confidence that the entity is relevant. Value range is zero to one, where one
        /// is highest confidence.
        /// </para>
        /// </summary>
        public float? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text in the document that identifies the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the entity. Amazon Comprehend supports a variety of <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html#how-targeted-sentiment-entities">entity
        /// types</a>.
        /// </para>
        /// </summary>
        public TargetedSentimentEntityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
