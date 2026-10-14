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
    /// Represents a work in the input text that was recognized and assigned a part of speech.
    /// There is one syntax token record for each word in the source text.
    /// </summary>
    public partial class SyntaxToken
    {
        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The zero-based offset from the beginning of the source text to the first character
        /// in the word.
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
        /// The zero-based offset from the beginning of the source text to the last character
        /// in the word.
        /// </para>
        /// </summary>
        public int? EndOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndOffset property is set.
        /// </summary>
        internal bool IsSetEndOffset() => this.EndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property PartOfSpeech. 
        /// <para>
        /// Provides the part of speech label and the confidence level that Amazon Comprehend
        /// has that the part of speech was correctly identified. For more information, see <a
        /// href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
        /// in the Comprehend Developer Guide. 
        /// </para>
        /// </summary>
        public PartOfSpeechTag PartOfSpeech { get; set; }

        /// <summary>
        /// Checks to see if the PartOfSpeech property is set.
        /// </summary>
        internal bool IsSetPartOfSpeech() => this.PartOfSpeech != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The word that was recognized in the source text.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property TokenId. 
        /// <para>
        /// A unique identifier for a token.
        /// </para>
        /// </summary>
        public int? TokenId { get; set; }

        /// <summary>
        /// Checks to see if the TokenId property is set.
        /// </summary>
        internal bool IsSetTokenId() => this.TokenId.HasValue;
    }
}
