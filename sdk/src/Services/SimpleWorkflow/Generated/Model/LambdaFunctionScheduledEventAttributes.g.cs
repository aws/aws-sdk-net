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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>LambdaFunctionScheduled</c> event. It isn't set for
    /// other event types.
    /// </summary>
    public partial class LambdaFunctionScheduledEventAttributes
    {
        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// Data attached to the event that the decider can use in subsequent workflow tasks.
        /// This data isn't sent to the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>LambdaFunctionCompleted</c> event corresponding to the decision that
        /// resulted in scheduling this activity task. To help diagnose issues, use this information
        /// to trace back the chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? DecisionTaskCompletedEventId { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskCompletedEventId property is set.
        /// </summary>
        internal bool IsSetDecisionTaskCompletedEventId() => this.DecisionTaskCompletedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input provided to the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartToCloseTimeout. 
        /// <para>
        /// The maximum amount of time a worker can take to process the Lambda task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string StartToCloseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StartToCloseTimeout property is set.
        /// </summary>
        internal bool IsSetStartToCloseTimeout() => this.StartToCloseTimeout != null;
    }
}
