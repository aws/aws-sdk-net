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
    /// Information about one of the entities found by targeted sentiment analysis.
    /// 
    ///  
    /// <para>
    /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
    /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetedSentimentEntity
    {
        private List<int> _descriptiveMentionIndex = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<TargetedSentimentMention> _mentions = AWSConfigs.InitializeCollections ? new List<TargetedSentimentMention>() : null;

        /// <summary>
        /// Gets and sets the property DescriptiveMentionIndex. 
        /// <para>
        /// One or more index into the Mentions array that provides the best name for the entity
        /// group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DescriptiveMentionIndex
        {
            get { return this._descriptiveMentionIndex; }
            set { this._descriptiveMentionIndex = value; }
        }

        // Check to see if DescriptiveMentionIndex property is set
        internal bool IsSetDescriptiveMentionIndex()
        {
            return this._descriptiveMentionIndex != null && (this._descriptiveMentionIndex.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Mentions. 
        /// <para>
        /// An array of mentions of the entity in the document. The array represents a co-reference
        /// group. See <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html#how-targeted-sentiment-values">
        /// Co-reference group</a> for an example. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetedSentimentMention> Mentions
        {
            get { return this._mentions; }
            set { this._mentions = value; }
        }

        // Check to see if Mentions property is set
        internal bool IsSetMentions()
        {
            return this._mentions != null && (this._mentions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}