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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Execution result information, such as the external execution ID.
    /// </summary>
    public partial class ActionExecutionResult
    {
        /// <summary>
        /// Gets and sets the property ErrorDetails.
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The action provider's external ID for the action execution.
        /// </para>
        /// </summary>
        public string ExternalExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalExecutionId property is set.
        /// </summary>
        internal bool IsSetExternalExecutionId() => this.ExternalExecutionId != null;

        /// <summary>
        /// Gets and sets the property ExternalExecutionSummary. 
        /// <para>
        /// The action provider's summary for the action execution.
        /// </para>
        /// </summary>
        public string ExternalExecutionSummary { get; set; }

        /// <summary>
        /// Checks to see if the ExternalExecutionSummary property is set.
        /// </summary>
        internal bool IsSetExternalExecutionSummary() => this.ExternalExecutionSummary != null;

        /// <summary>
        /// Gets and sets the property ExternalExecutionUrl. 
        /// <para>
        /// The deepest external link to the external resource (for example, a repository URL
        /// or deployment endpoint) that is used when running the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExternalExecutionUrl { get; set; }

        /// <summary>
        /// Checks to see if the ExternalExecutionUrl property is set.
        /// </summary>
        internal bool IsSetExternalExecutionUrl() => this.ExternalExecutionUrl != null;

        /// <summary>
        /// Gets and sets the property LogStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log stream for the action compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string LogStreamARN { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamARN property is set.
        /// </summary>
        internal bool IsSetLogStreamARN() => this.LogStreamARN != null;
    }
}
