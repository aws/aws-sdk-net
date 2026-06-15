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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
        private int? _beginOffset;
        private double? _confidenceScore;
        private int? _contentIndex;
        private int? _endOffset;
        private int? _messageIndex;
        private GuardrailChecksSensitiveInformationEntityType _type;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The start character offset of the detected entity within the content block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// Gets and sets the property ConfidenceScore. 
        /// <para>
        /// The confidence score for the detection, ranging from 0.0 to 1.0. Higher values indicate
        /// greater confidence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? ConfidenceScore
        {
            get { return this._confidenceScore; }
            set { this._confidenceScore = value; }
        }

        // Check to see if ConfidenceScore property is set
        internal bool IsSetConfidenceScore()
        {
            return this._confidenceScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentIndex. 
        /// <para>
        /// The zero-based index of the content block within the message where the entity was
        /// detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? ContentIndex
        {
            get { return this._contentIndex; }
            set { this._contentIndex = value; }
        }

        // Check to see if ContentIndex property is set
        internal bool IsSetContentIndex()
        {
            return this._contentIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The end character offset of the detected entity within the content block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// Gets and sets the property MessageIndex. 
        /// <para>
        /// The zero-based index of the message in the input messages array where the entity was
        /// detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? MessageIndex
        {
            get { return this._messageIndex; }
            set { this._messageIndex = value; }
        }

        // Check to see if MessageIndex property is set
        internal bool IsSetMessageIndex()
        {
            return this._messageIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The PII entity type that was detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailChecksSensitiveInformationEntityType Type
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