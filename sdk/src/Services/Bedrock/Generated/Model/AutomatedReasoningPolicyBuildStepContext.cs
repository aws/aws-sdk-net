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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Provides context about what type of operation was being performed during a build step.
    /// </summary>
    public partial class AutomatedReasoningPolicyBuildStepContext
    {
        private AutomatedReasoningPolicyMutation _mutation;
        private AutomatedReasoningPolicyPlanning _planning;

        /// <summary>
        /// Gets and sets the property Mutation. 
        /// <para>
        /// Indicates that this build step involved modifying the policy structure, such as adding
        /// or updating rules, variables, or types.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyMutation Mutation
        {
            get { return this._mutation; }
            set { this._mutation = value; }
        }

        // Check to see if Mutation property is set
        internal bool IsSetMutation()
        {
            return this._mutation != null;
        }

        /// <summary>
        /// Gets and sets the property Planning. 
        /// <para>
        /// Indicates that this build step was part of the planning phase, where the system determines
        /// what operations to perform.
        /// </para>
        /// </summary>
        public AutomatedReasoningPolicyPlanning Planning
        {
            get { return this._planning; }
            set { this._planning = value; }
        }

        // Check to see if Planning property is set
        internal bool IsSetPlanning()
        {
            return this._planning != null;
        }

    }
}