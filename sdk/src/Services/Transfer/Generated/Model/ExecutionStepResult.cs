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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the following details for the step: error (if any), outputs (if any), and
    /// the step type.
    /// </summary>
    public partial class ExecutionStepResult
    {
        private ExecutionError _error;
        private string _outputs;
        private WorkflowStepType _stepType;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Specifies the details for an error, if it occurred during execution of the specified
        /// workflow step.
        /// </para>
        /// </summary>
        public ExecutionError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The values for the key/value pair applied as a tag to the file. Only applicable if
        /// the step type is <code>TAG</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=65536)]
        public string Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null;
        }

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        /// One of the available step types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>COPY</code> </b> - Copy the file to another location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>CUSTOM</code> </b> - Perform a custom step with an Lambda function target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DECRYPT</code> </b> - Decrypt a file that was encrypted before it was uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DELETE</code> </b> - Delete the file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>TAG</code> </b> - Add a tag to the file.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkflowStepType StepType
        {
            get { return this._stepType; }
            set { this._stepType = value; }
        }

        // Check to see if StepType property is set
        internal bool IsSetStepType()
        {
            return this._stepType != null;
        }

    }
}