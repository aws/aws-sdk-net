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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the steps for a candidate and what step it is working on.
    /// </summary>
    public partial class AutoMLCandidateStep
    {
        /// <summary>
        /// Gets and sets the property CandidateStepArn. 
        /// <para>
        /// The ARN for the candidate's step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string CandidateStepArn { get; set; }

        /// <summary>
        /// Checks to see if the CandidateStepArn property is set.
        /// </summary>
        internal bool IsSetCandidateStepArn() => this.CandidateStepArn != null;

        /// <summary>
        /// Gets and sets the property CandidateStepName. 
        /// <para>
        /// The name for the candidate's step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CandidateStepName { get; set; }

        /// <summary>
        /// Checks to see if the CandidateStepName property is set.
        /// </summary>
        internal bool IsSetCandidateStepName() => this.CandidateStepName != null;

        /// <summary>
        /// Gets and sets the property CandidateStepType. 
        /// <para>
        /// Whether the candidate is at the transform, training, or processing step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CandidateStepType CandidateStepType { get; set; }

        /// <summary>
        /// Checks to see if the CandidateStepType property is set.
        /// </summary>
        internal bool IsSetCandidateStepType() => this.CandidateStepType != null;
    }
}
