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
    /// Identifies the part of speech represented by the token and gives the confidence that
    /// Amazon Comprehend has that the part of speech was correctly identified. For more information
    /// about the parts of speech that Amazon Comprehend can identify, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
    /// in the Comprehend Developer Guide.
    /// </summary>
    public partial class PartOfSpeechTag
    {
        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The confidence that Amazon Comprehend has that the part of speech was correctly identified.
        /// </para>
        /// </summary>
        public float? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// Identifies the part of speech that the token represents.
        /// </para>
        /// </summary>
        public PartOfSpeechTagType Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;
    }
}
