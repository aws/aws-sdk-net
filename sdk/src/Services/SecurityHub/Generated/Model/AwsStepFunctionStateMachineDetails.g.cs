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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Step Functions state machine, which is a workflow consisting
    /// of a series of event- driven steps.
    /// </summary>
    public partial class AwsStepFunctionStateMachineDetails
    {
        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  A user-defined or an auto-generated string that identifies a <c>Map</c> state. This
        /// parameter is present only if the <c>stateMachineArn</c> specified in input is a qualified
        /// state machine ARN. 
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        ///  Used to set CloudWatch Logs options. 
        /// </para>
        /// </summary>
        public AwsStepFunctionStateMachineLoggingConfigurationDetails LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the state machine. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role used when creating this state machine.
        /// 
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        ///  The ARN that identifies the state machine. 
        /// </para>
        /// </summary>
        public string StateMachineArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineArn property is set.
        /// </summary>
        internal bool IsSetStateMachineArn() => this.StateMachineArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the state machine. 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TracingConfiguration. 
        /// <para>
        ///  Specifies whether X-Ray tracing is enabled. 
        /// </para>
        /// </summary>
        public AwsStepFunctionStateMachineTracingConfigurationDetails TracingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TracingConfiguration property is set.
        /// </summary>
        internal bool IsSetTracingConfiguration() => this.TracingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the state machine (STANDARD or EXPRESS). 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
