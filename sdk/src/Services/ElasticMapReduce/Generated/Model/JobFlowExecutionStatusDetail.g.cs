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
    /// Describes the status of the cluster (job flow).
    /// </summary>
    public partial class JobFlowExecutionStatusDetail
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public JobFlowExecutionStatusDetail() { }

        /// <summary>
        /// Instantiates JobFlowExecutionStatusDetail with the parameterized properties
        /// </summary>
        /// <param name="state">The state of the job flow.</param>
        /// <param name="creationDateTime">The creation date and time of the job flow.</param>
        public JobFlowExecutionStatusDetail(JobFlowExecutionState state, DateTime? creationDateTime)
        {
            this.State = state;
            this.CreationDateTime = creationDateTime;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time of the job flow.
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
        /// The completion date and time of the job flow.
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
        /// Description of the job flow last changed state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LastStateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the LastStateChangeReason property is set.
        /// </summary>
        internal bool IsSetLastStateChangeReason() => this.LastStateChangeReason != null;

        /// <summary>
        /// Gets and sets the property ReadyDateTime. 
        /// <para>
        /// The date and time when the job flow was ready to start running bootstrap actions.
        /// </para>
        /// </summary>
        public DateTime? ReadyDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReadyDateTime property is set.
        /// </summary>
        internal bool IsSetReadyDateTime() => this.ReadyDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The start date and time of the job flow.
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
        /// The state of the job flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobFlowExecutionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
