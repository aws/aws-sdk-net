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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A detailed status of the parent step.
    /// </summary>
    public partial class ParentStepDetails
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The name of the automation action.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Iteration. 
        /// <para>
        /// The current repetition of the loop represented by an integer.
        /// </para>
        /// </summary>
        public int? Iteration { get; set; }

        /// <summary>
        /// Checks to see if the Iteration property is set.
        /// </summary>
        internal bool IsSetIteration() => this.Iteration.HasValue;

        /// <summary>
        /// Gets and sets the property IteratorValue. 
        /// <para>
        /// The current value of the specified iterator in the loop.
        /// </para>
        /// </summary>
        public string IteratorValue { get; set; }

        /// <summary>
        /// Checks to see if the IteratorValue property is set.
        /// </summary>
        internal bool IsSetIteratorValue() => this.IteratorValue != null;

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique ID of a step execution.
        /// </para>
        /// </summary>
        public string StepExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the StepExecutionId property is set.
        /// </summary>
        internal bool IsSetStepExecutionId() => this.StepExecutionId != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;
    }
}
