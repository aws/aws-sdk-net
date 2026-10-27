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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The detection result for a single sensitive information entity found in the evaluated
    /// messages.
    /// </summary>
    public partial class GuardrailChecksSensitiveInformationResultEntry
    {
        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The start character offset of the detected entity within the content block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? BeginOffset { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffset property is set.
        /// </summary>
        internal bool IsSetBeginOffset() => this.BeginOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ConfidenceScore. 
        /// <para>
        /// The confidence score for the detection, ranging from 0.0 to 1.0. Higher values indicate
        /// greater confidence.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? ConfidenceScore { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceScore property is set.
        /// </summary>
        internal bool IsSetConfidenceScore() => this.ConfidenceScore.HasValue;

        /// <summary>
        /// Gets and sets the property ContentIndex. 
        /// <para>
        /// The zero-based index of the content block within the message where the entity was
        /// detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// Checks to see if the ContentIndex property is set.
        /// </summary>
        internal bool IsSetContentIndex() => this.ContentIndex.HasValue;

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The end character offset of the detected entity within the content block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? EndOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndOffset property is set.
        /// </summary>
        internal bool IsSetEndOffset() => this.EndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property MessageIndex. 
        /// <para>
        /// The zero-based index of the message in the input messages array where the entity was
        /// detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MessageIndex { get; set; }

        /// <summary>
        /// Checks to see if the MessageIndex property is set.
        /// </summary>
        internal bool IsSetMessageIndex() => this.MessageIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The PII entity type that was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailChecksSensitiveInformationEntityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
