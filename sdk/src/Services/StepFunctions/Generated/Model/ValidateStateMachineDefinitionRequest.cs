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
    /// Validates the syntax of a state machine definition specified in <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
    /// States Language</a> (ASL), a JSON-based, structured language.
    /// 
    ///  
    /// <para>
    /// You can validate that a state machine definition is correct without creating a state
    /// machine resource.
    /// </para>
    ///  
    /// <para>
    /// Suggested uses for <c>ValidateStateMachineDefinition</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Integrate automated checks into your code review or Continuous Integration (CI) process
    /// to check state machine definitions before starting deployments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Run validation from a Git pre-commit hook to verify the definition before committing
    /// to your source repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Validation will look for problems in your state machine definition and return a <b>result</b>
    /// and a list of <b>diagnostic elements</b>.
    /// </para>
    ///  
    /// <para>
    /// The <b>result</b> value will be <c>OK</c> when your workflow definition can be successfully
    /// created or updated. Note the result can be <c>OK</c> even when diagnostic warnings
    /// are present in the response. The <b>result</b> value will be <c>FAIL</c> when the
    /// workflow definition contains errors that would prevent you from creating or updating
    /// your state machine. 
    /// </para>
    ///  
    /// <para>
    /// The list of <a href="https://docs.aws.amazon.com/step-functions/latest/apireference/API_ValidateStateMachineDefinitionDiagnostic.html">ValidateStateMachineDefinitionDiagnostic</a>
    /// data elements can contain zero or more <b>WARNING</b> and/or <b>ERROR</b> elements.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <b>ValidateStateMachineDefinition API</b> might add new diagnostics in the future,
    /// adjust diagnostic codes, or change the message wording. Your automated processes should
    /// only rely on the value of the <b>result</b> field value (OK, FAIL). Do <b>not</b>
    /// rely on the exact order, count, or wording of diagnostic messages.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ValidateStateMachineDefinitionRequest : AmazonStepFunctionsRequest
    {
        private string _definition;
        private int? _maxResults;
        private ValidateStateMachineDefinitionSeverity _severity;
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of diagnostics that are returned per call. The default and maximum
        /// value is 100. Setting the value to 0 will also use the default of 100.
        /// </para>
        ///  
        /// <para>
        /// If the number of diagnostics returned in the response exceeds <c>maxResults</c>, the
        /// value of the <c>truncated</c> field in the response will be set to <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Minimum level of diagnostics to return. <c>ERROR</c> returns only <c>ERROR</c> diagnostics,
        /// whereas <c>WARNING</c> returns both <c>WARNING</c> and <c>ERROR</c> diagnostics. The
        /// default is <c>ERROR</c>. 
        /// </para>
        /// </summary>
        public ValidateStateMachineDefinitionSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
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