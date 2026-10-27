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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the following details for the step: error (if any), outputs (if any), and
    /// the step type.
    /// </summary>
    public partial class ExecutionStepResult
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Specifies the details for an error, if it occurred during execution of the specified
        /// workflow step.
        /// </para>
        /// </summary>
        public ExecutionError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The values for the key/value pair applied as a tag to the file. Only applicable if
        /// the step type is <c>TAG</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string Outputs { get; set; }

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null;

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        /// One of the available step types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>COPY</c> </b> - Copy the file to another location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CUSTOM</c> </b> - Perform a custom step with an Lambda function target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DECRYPT</c> </b> - Decrypt a file that was encrypted before it was uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DELETE</c> </b> - Delete the file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>TAG</c> </b> - Add a tag to the file.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkflowStepType StepType { get; set; }

        /// <summary>
        /// Checks to see if the StepType property is set.
        /// </summary>
        internal bool IsSetStepType() => this.StepType != null;
    }
}
