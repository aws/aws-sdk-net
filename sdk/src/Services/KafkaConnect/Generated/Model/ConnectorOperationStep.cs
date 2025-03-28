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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Details of a step that is involved in a connector's operation.
    /// </summary>
    public partial class ConnectorOperationStep
    {
        private ConnectorOperationStepState _stepState;
        private ConnectorOperationStepType _stepType;

        /// <summary>
        /// Gets and sets the property StepState. 
        /// <para>
        /// The step state of the operation.
        /// </para>
        /// </summary>
        public ConnectorOperationStepState StepState
        {
            get { return this._stepState; }
            set { this._stepState = value; }
        }

        // Check to see if StepState property is set
        internal bool IsSetStepState()
        {
            return this._stepState != null;
        }

        /// <summary>
        /// Gets and sets the property StepType. 
        /// <para>
        /// The step type of the operation.
        /// </para>
        /// </summary>
        public ConnectorOperationStepType StepType
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