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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private string _candidateStepArn;
        private string _candidateStepName;
        private CandidateStepType _candidateStepType;

        /// <summary>
        /// Gets and sets the property CandidateStepArn. 
        /// <para>
        /// The ARN for the candidate's step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string CandidateStepArn
        {
            get { return this._candidateStepArn; }
            set { this._candidateStepArn = value; }
        }

        // Check to see if CandidateStepArn property is set
        internal bool IsSetCandidateStepArn()
        {
            return this._candidateStepArn != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateStepName. 
        /// <para>
        /// The name for the candidate's step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CandidateStepName
        {
            get { return this._candidateStepName; }
            set { this._candidateStepName = value; }
        }

        // Check to see if CandidateStepName property is set
        internal bool IsSetCandidateStepName()
        {
            return this._candidateStepName != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateStepType. 
        /// <para>
        /// Whether the candidate is at the transform, training, or processing step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CandidateStepType CandidateStepType
        {
            get { return this._candidateStepType; }
            set { this._candidateStepType = value; }
        }

        // Check to see if CandidateStepType property is set
        internal bool IsSetCandidateStepType()
        {
            return this._candidateStepType != null;
        }

    }
}