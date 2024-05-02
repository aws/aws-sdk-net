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
    /// The parameters for task execution.
    /// </summary>
    public partial class MaintenanceWindowTaskInvocationParameters
    {
        private MaintenanceWindowAutomationParameters _automation;
        private MaintenanceWindowLambdaParameters _lambda;
        private MaintenanceWindowRunCommandParameters _runCommand;
        private MaintenanceWindowStepFunctionsParameters _stepFunctions;

        /// <summary>
        /// Gets and sets the property Automation. 
        /// <para>
        /// The parameters for an <c>AUTOMATION</c> task type.
        /// </para>
        /// </summary>
        public MaintenanceWindowAutomationParameters Automation
        {
            get { return this._automation; }
            set { this._automation = value; }
        }

        // Check to see if Automation property is set
        internal bool IsSetAutomation()
        {
            return this._automation != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The parameters for a <c>LAMBDA</c> task type.
        /// </para>
        /// </summary>
        public MaintenanceWindowLambdaParameters Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property RunCommand. 
        /// <para>
        /// The parameters for a <c>RUN_COMMAND</c> task type.
        /// </para>
        /// </summary>
        public MaintenanceWindowRunCommandParameters RunCommand
        {
            get { return this._runCommand; }
            set { this._runCommand = value; }
        }

        // Check to see if RunCommand property is set
        internal bool IsSetRunCommand()
        {
            return this._runCommand != null;
        }

        /// <summary>
        /// Gets and sets the property StepFunctions. 
        /// <para>
        /// The parameters for a <c>STEP_FUNCTIONS</c> task type.
        /// </para>
        /// </summary>
        public MaintenanceWindowStepFunctionsParameters StepFunctions
        {
            get { return this._stepFunctions; }
            set { this._stepFunctions = value; }
        }

        // Check to see if StepFunctions property is set
        internal bool IsSetStepFunctions()
        {
            return this._stepFunctions != null;
        }

    }
}