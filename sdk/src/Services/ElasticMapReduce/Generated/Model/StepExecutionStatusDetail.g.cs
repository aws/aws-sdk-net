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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The execution state of a step.
    /// </summary>
    public partial class StepExecutionStatusDetail
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public StepExecutionStatusDetail() { }

        /// <summary>
        /// Instantiates StepExecutionStatusDetail with the parameterized properties
        /// </summary>
        /// <param name="state">The state of the step.</param>
        /// <param name="creationDateTime">The creation date and time of the step.</param>
        public StepExecutionStatusDetail(StepExecutionState state, DateTime? creationDateTime)
        {
            this.State = state;
            this.CreationDateTime = creationDateTime;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The completion date and time of the step.
        /// </para>
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// A description of the step's current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LastStateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the LastStateChangeReason property is set.
        /// </summary>
        internal bool IsSetLastStateChangeReason() => this.LastStateChangeReason != null;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The start date and time of the step.
        /// </para>
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StepExecutionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
