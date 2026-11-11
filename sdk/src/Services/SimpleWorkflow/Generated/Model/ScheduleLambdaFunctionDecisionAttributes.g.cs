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
    /// Decision attributes specified in <c>scheduleLambdaFunctionDecisionAttributes</c> within
    /// the list of decisions <c>decisions</c> passed to <a>RespondDecisionTaskCompleted</a>.
    /// </summary>
    public partial class ScheduleLambdaFunctionDecisionAttributes
    {
        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// The data attached to the event that the decider can use in subsequent workflow tasks.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A string that identifies the Lambda function execution in the event history.
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
        /// The optional input data to be supplied to the Lambda function.
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
        /// The name, or ARN, of the Lambda function to schedule.
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
        /// The timeout value, in seconds, after which the Lambda function is considered to be
        /// failed once it has started. This can be any integer from 1-900 (1s-15m).
        /// </para>
        ///  
        /// <para>
        /// If no value is supplied, then a default value of 900s is assumed.
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
