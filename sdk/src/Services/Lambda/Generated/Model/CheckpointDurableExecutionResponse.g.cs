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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the CheckpointDurableExecution operation.
    /// </summary>
    public partial class CheckpointDurableExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CheckpointToken. 
        /// <para>
        /// A new checkpoint token to use for the next checkpoint operation. This token replaces
        /// the one provided in the request and must be used for subsequent checkpoints to maintain
        /// proper ordering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CheckpointToken { get; set; }

        /// <summary>
        /// Checks to see if the CheckpointToken property is set.
        /// </summary>
        internal bool IsSetCheckpointToken() => this.CheckpointToken != null;

        /// <summary>
        /// Gets and sets the property NewExecutionState. 
        /// <para>
        /// Updated execution state information that includes any changes that occurred since
        /// the last checkpoint, such as completed callbacks or expired timers. This allows the
        /// SDK to update its internal state during replay.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CheckpointUpdatedExecutionState NewExecutionState { get; set; }

        /// <summary>
        /// Checks to see if the NewExecutionState property is set.
        /// </summary>
        internal bool IsSetNewExecutionState() => this.NewExecutionState != null;
    }
}
