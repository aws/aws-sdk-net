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
    /// Summary information about an evaluation acknowledgement.
    /// </summary>
    public partial class EvaluationAcknowledgementSummary
    {
        /// <summary>
        /// Gets and sets the property AcknowledgedBy. 
        /// <para>
        /// The agent who acknowledged the evaluation.
        /// </para>
        /// </summary>
        public string AcknowledgedBy { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgedBy property is set.
        /// </summary>
        internal bool IsSetAcknowledgedBy() => this.AcknowledgedBy != null;

        /// <summary>
        /// Gets and sets the property AcknowledgedTime. 
        /// <para>
        /// The time when an agent acknowledged the evaluation.
        /// </para>
        /// </summary>
        public DateTime? AcknowledgedTime { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgedTime property is set.
        /// </summary>
        internal bool IsSetAcknowledgedTime() => this.AcknowledgedTime.HasValue;

        /// <summary>
        /// Gets and sets the property AcknowledgerComment. 
        /// <para>
        /// A comment from the agent when they confirmed they acknowledged the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string AcknowledgerComment { get; set; }

        /// <summary>
        /// Checks to see if the AcknowledgerComment property is set.
        /// </summary>
        internal bool IsSetAcknowledgerComment() => this.AcknowledgerComment != null;
    }
}
