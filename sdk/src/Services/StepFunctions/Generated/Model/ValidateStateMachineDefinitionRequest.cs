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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateStateMachineDefinition operation.
    /// Validates the syntax of a state machine definition.
    /// 
    ///  
    /// <para>
    /// You can validate that a state machine definition is correct without creating a state
    /// machine resource. Step Functions will implicitly perform the same syntax check when
    /// you invoke <c>CreateStateMachine</c> and <c>UpdateStateMachine</c>. State machine
    /// definitions are specified using a JSON-based, structured language. For more information
    /// on Amazon States Language see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
    /// States Language</a> (ASL). 
    /// </para>
    ///  
    /// <para>
    /// Suggested uses for <c>ValidateStateMachineDefinition</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Integrate automated checks into your code review or Continuous Integration (CI) process
    /// to validate state machine definitions before starting deployments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Run the validation from a Git pre-commit hook to check your state machine definitions
    /// before committing them to your source repository.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Errors found in the state machine definition will be returned in the response as a
    /// list of <b>diagnostic elements</b>, rather than raise an exception.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ValidateStateMachineDefinitionRequest : AmazonStepFunctionsRequest
    {
        private string _definition;
        private StateMachineType _type;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The Amazon States Language definition of the state machine. For more information,
        /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> (ASL).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1048576)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The target type of state machine for this definition. The default is <c>STANDARD</c>.
        /// </para>
        /// </summary>
        public StateMachineType Type
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