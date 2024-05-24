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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _label;
        private AwsStepFunctionStateMachineLoggingConfigurationDetails _loggingConfiguration;
        private string _name;
        private string _roleArn;
        private string _stateMachineArn;
        private string _status;
        private AwsStepFunctionStateMachineTracingConfigurationDetails _tracingConfiguration;
        private string _type;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  A user-defined or an auto-generated string that identifies a <c>Map</c> state. This
        /// parameter is present only if the <c>stateMachineArn</c> specified in input is a qualified
        /// state machine ARN. 
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        ///  Used to set CloudWatch Logs options. 
        /// </para>
        /// </summary>
        public AwsStepFunctionStateMachineLoggingConfigurationDetails LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the state machine. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role used when creating this state machine.
        /// 
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        ///  The ARN that identifies the state machine. 
        /// </para>
        /// </summary>
        public string StateMachineArn
        {
            get { return this._stateMachineArn; }
            set { this._stateMachineArn = value; }
        }

        // Check to see if StateMachineArn property is set
        internal bool IsSetStateMachineArn()
        {
            return this._stateMachineArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the state machine. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TracingConfiguration. 
        /// <para>
        ///  Specifies whether X-Ray tracing is enabled. 
        /// </para>
        /// </summary>
        public AwsStepFunctionStateMachineTracingConfigurationDetails TracingConfiguration
        {
            get { return this._tracingConfiguration; }
            set { this._tracingConfiguration = value; }
        }

        // Check to see if TracingConfiguration property is set
        internal bool IsSetTracingConfiguration()
        {
            return this._tracingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the state machine (STANDARD or EXPRESS). 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}