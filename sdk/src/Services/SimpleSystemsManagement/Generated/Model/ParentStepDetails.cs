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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private string _action;
        private int? _iteration;
        private string _iteratorValue;
        private string _stepExecutionId;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The name of the automation action.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Iteration. 
        /// <para>
        /// The current repetition of the loop represented by an integer.
        /// </para>
        /// </summary>
        public int? Iteration
        {
            get { return this._iteration; }
            set { this._iteration = value; }
        }

        // Check to see if Iteration property is set
        internal bool IsSetIteration()
        {
            return this._iteration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IteratorValue. 
        /// <para>
        /// The current value of the specified iterator in the loop.
        /// </para>
        /// </summary>
        public string IteratorValue
        {
            get { return this._iteratorValue; }
            set { this._iteratorValue = value; }
        }

        // Check to see if IteratorValue property is set
        internal bool IsSetIteratorValue()
        {
            return this._iteratorValue != null;
        }

        /// <summary>
        /// Gets and sets the property StepExecutionId. 
        /// <para>
        /// The unique ID of a step execution.
        /// </para>
        /// </summary>
        public string StepExecutionId
        {
            get { return this._stepExecutionId; }
            set { this._stepExecutionId = value; }
        }

        // Check to see if StepExecutionId property is set
        internal bool IsSetStepExecutionId()
        {
            return this._stepExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}