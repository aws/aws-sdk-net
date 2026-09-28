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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The message data in text type.
    /// </summary>
    public partial class TextMessage
    {
        /// <summary>
        /// Gets and sets the property AiGuardrailAssessment. 
        /// <para>
        /// The AI Guardrail assessment for the text message.
        /// </para>
        /// </summary>
        public AIGuardrailAssessment AiGuardrailAssessment { get; set; }

        /// <summary>
        /// Checks to see if the AiGuardrailAssessment property is set.
        /// </summary>
        internal bool IsSetAiGuardrailAssessment() => this.AiGuardrailAssessment != null;

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// The citations associated with the text message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Citation> Citations { get; set; } = AWSConfigs.InitializeCollections ? new List<Citation>() : null;

        /// <summary>
        /// Checks to see if the Citations property is set.
        /// </summary>
        internal bool IsSetCitations() => this.Citations != null && (this.Citations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the message data in text type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 25000)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
