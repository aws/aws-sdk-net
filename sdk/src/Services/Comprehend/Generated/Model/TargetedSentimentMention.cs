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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
        private int? _beginOffset;
        private int? _endOffset;
        private float? _groupScore;
        private MentionSentiment _mentionSentiment;
        private float? _score;
        private string _text;
        private TargetedSentimentEntityType _type;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The offset into the document text where the mention begins.
        /// </para>
        /// </summary>
        public int? BeginOffset
        {
            get { return this._beginOffset; }
            set { this._beginOffset = value; }
        }

        // Check to see if BeginOffset property is set
        internal bool IsSetBeginOffset()
        {
            return this._beginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The offset into the document text where the mention ends.
        /// </para>
        /// </summary>
        public int? EndOffset
        {
            get { return this._endOffset; }
            set { this._endOffset = value; }
        }

        // Check to see if EndOffset property is set
        internal bool IsSetEndOffset()
        {
            return this._endOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupScore. 
        /// <para>
        /// The confidence that all the entities mentioned in the group relate to the same entity.
        /// </para>
        /// </summary>
        public float? GroupScore
        {
            get { return this._groupScore; }
            set { this._groupScore = value; }
        }

        // Check to see if GroupScore property is set
        internal bool IsSetGroupScore()
        {
            return this._groupScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MentionSentiment. 
        /// <para>
        /// Contains the sentiment and sentiment score for the mention.
        /// </para>
        /// </summary>
        public MentionSentiment MentionSentiment
        {
            get { return this._mentionSentiment; }
            set { this._mentionSentiment = value; }
        }

        // Check to see if MentionSentiment property is set
        internal bool IsSetMentionSentiment()
        {
            return this._mentionSentiment != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// Model confidence that the entity is relevant. Value range is zero to one, where one
        /// is highest confidence.
        /// </para>
        /// </summary>
        public float? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text in the document that identifies the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the entity. Amazon Comprehend supports a variety of <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html#how-targeted-sentiment-entities">entity
        /// types</a>.
        /// </para>
        /// </summary>
        public TargetedSentimentEntityType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}