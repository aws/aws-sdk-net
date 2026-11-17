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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// An enablement expression source item.
    /// </summary>
    public partial class EvaluationFormItemEnablementSource
    {
        /// <summary>
        /// Gets and sets the property AiMetricsField. 
        /// <para>
        /// The AI metrics field to use as the source. Use when <c>Type</c> is <c>AI_METRICS</c>.
        /// </para>
        /// </summary>
        public EvaluationFormAiMetricsField AiMetricsField { get; set; }

        /// <summary>
        /// Checks to see if the AiMetricsField property is set.
        /// </summary>
        internal bool IsSetAiMetricsField() => this.AiMetricsField != null;

        /// <summary>
        /// Gets and sets the property ContactAttributeKey. 
        /// <para>
        /// The key of the contact attribute to use as the source. Use when <c>Type</c> is <c>CONTACT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32767)]
        public string ContactAttributeKey { get; set; }

        /// <summary>
        /// Checks to see if the ContactAttributeKey property is set.
        /// </summary>
        internal bool IsSetContactAttributeKey() => this.ContactAttributeKey != null;

        /// <summary>
        /// Gets and sets the property ContactField. 
        /// <para>
        /// The contact field to use as the source, such as <c>CHANNEL</c>, <c>QUEUE_ARN</c>,
        /// <c>OVERALL_CUSTOMER_SENTIMENT_SCORE</c>, or <c>RECORDING_MEDIA_STREAM_TYPES</c>. Use
        /// when <c>Type</c> is <c>CONTACT</c>.
        /// </para>
        /// </summary>
        public EvaluationFormContactField ContactField { get; set; }

        /// <summary>
        /// Checks to see if the ContactField property is set.
        /// </summary>
        internal bool IsSetContactField() => this.ContactField != null;

        /// <summary>
        /// Gets and sets the property EvaluationMetadataField. 
        /// <para>
        /// The evaluation metadata field to use as the source. Use when <c>Type</c> is <c>EVALUATION_METADATA</c>.
        /// </para>
        /// </summary>
        public EvaluationFormEvaluationMetadataField EvaluationMetadataField { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMetadataField property is set.
        /// </summary>
        internal bool IsSetEvaluationMetadataField() => this.EvaluationMetadataField != null;

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// A referenceId of the source item. Use when <c>Type</c> is <c>QUESTION_REF_ID</c>.
        /// </para>
        /// </summary>
        public string RefId { get; set; }

        /// <summary>
        /// Checks to see if the RefId property is set.
        /// </summary>
        internal bool IsSetRefId() => this.RefId != null;

        /// <summary>
        /// Gets and sets the property SegmentAttributeKey. 
        /// <para>
        /// The key of the contact segment attribute to use as the source. Use when <c>Type</c>
        /// is <c>CONTACT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SegmentAttributeKey { get; set; }

        /// <summary>
        /// Checks to see if the SegmentAttributeKey property is set.
        /// </summary>
        internal bool IsSetSegmentAttributeKey() => this.SegmentAttributeKey != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A type of source item. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>QUESTION_REF_ID</c> - The answer to another question in the evaluation form.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTACT</c> - Data from the evaluated contact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EVALUATION_METADATA</c> - Metadata of the evaluation, such as the evaluation type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AI_METRICS</c> - Metrics about AI agents, AI sessions, and AI tools on the contact.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormItemEnablementSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
