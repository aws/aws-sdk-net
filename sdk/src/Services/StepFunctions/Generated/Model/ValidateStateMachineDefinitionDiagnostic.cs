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
    /// Describes potential issues found during state machine validation. Rather than raise
    /// an exception, validation will return a list of <b>diagnostic elements</b> containing
    /// diagnostic information. 
    /// 
    ///  <note> 
    /// <para>
    /// The <a href="https://docs.aws.amazon.com/step-functions/latest/apireference/API_ValidateStateMachineDefinition.html">ValidateStateMachineDefinitionlAPI</a>
    /// might add new diagnostics in the future, adjust diagnostic codes, or change the message
    /// wording. Your automated processes should only rely on the value of the <b>result</b>
    /// field value (OK, FAIL). Do <b>not</b> rely on the exact order, count, or wording of
    /// diagnostic messages.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>List of warning codes</b> 
    /// </para>
    ///  <dl> <dt>NO_DOLLAR</dt> <dd> 
    /// <para>
    /// No <c>.$</c> on a field that appears to be a JSONPath or Intrinsic Function.
    /// </para>
    ///  </dd> <dt>NO_PATH</dt> <dd> 
    /// <para>
    /// Field value looks like a path, but field name does not end with 'Path'.
    /// </para>
    ///  </dd> <dt>PASS_RESULT_IS_STATIC</dt> <dd> 
    /// <para>
    /// Attempt to use a path in the result of a pass state.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    ///  <b>List of error codes</b> 
    /// </para>
    ///  <dl> <dt>INVALID_JSON_DESCRIPTION</dt> <dd> 
    /// <para>
    /// JSON syntax problem found.
    /// </para>
    ///  </dd> <dt>MISSING_DESCRIPTION</dt> <dd> 
    /// <para>
    /// Received a null or empty workflow input.
    /// </para>
    ///  </dd> <dt>SCHEMA_VALIDATION_FAILED</dt> <dd> 
    /// <para>
    /// Schema validation reported errors.
    /// </para>
    ///  </dd> <dt>INVALID_RESOURCE</dt> <dd> 
    /// <para>
    /// The value of a Task-state resource field is invalid.
    /// </para>
    ///  </dd> <dt>MISSING_END_STATE</dt> <dd> 
    /// <para>
    /// The workflow does not have a terminal state.
    /// </para>
    ///  </dd> <dt>DUPLICATE_STATE_NAME</dt> <dd> 
    /// <para>
    /// The same state name appears more than once.
    /// </para>
    ///  </dd> <dt>INVALID_STATE_NAME</dt> <dd> 
    /// <para>
    /// The state name does not follow the naming convention.
    /// </para>
    ///  </dd> <dt>STATE_MACHINE_NAME_EMPTY</dt> <dd> 
    /// <para>
    /// The state machine name has not been specified.
    /// </para>
    ///  </dd> <dt>STATE_MACHINE_NAME_INVALID</dt> <dd> 
    /// <para>
    /// The state machine name does not follow the naming convention.
    /// </para>
    ///  </dd> <dt>STATE_MACHINE_NAME_TOO_LONG</dt> <dd> 
    /// <para>
    /// The state name exceeds the allowed length.
    /// </para>
    ///  </dd> <dt>STATE_MACHINE_NAME_ALREADY_EXISTS</dt> <dd> 
    /// <para>
    /// The state name already exists.
    /// </para>
    ///  </dd> <dt>DUPLICATE_LABEL_NAME</dt> <dd> 
    /// <para>
    /// A label name appears more than once.
    /// </para>
    ///  </dd> <dt>INVALID_LABEL_NAME</dt> <dd> 
    /// <para>
    /// You have provided an invalid label name.
    /// </para>
    ///  </dd> <dt>MISSING_TRANSITION_TARGET</dt> <dd> 
    /// <para>
    /// The value of "Next" field doesn't match a known state name.
    /// </para>
    ///  </dd> <dt>TOO_DEEPLY_NESTED</dt> <dd> 
    /// <para>
    /// The states are too deeply nested.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class ValidateStateMachineDefinitionDiagnostic
    {
        private string _code;
        private string _location;
        private string _message;
        private ValidateStateMachineDefinitionSeverity _severity;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Identifying code for the diagnostic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Location of the issue in the state machine, if available.
        /// </para>
        ///  
        /// <para>
        /// For errors specific to a field, the location could be in the format: <c>/States/&lt;StateName&gt;/&lt;FieldName&gt;</c>,
        /// for example: <c>/States/FailState/ErrorPath</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Message describing the diagnostic condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// A value of <c>ERROR</c> means that you cannot create or update a state machine with
        /// this definition.
        /// </para>
        ///  
        /// <para>
        ///  <c>WARNING</c> level diagnostics alert you to potential issues, but they will not
        /// prevent you from creating or updating your state machine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}