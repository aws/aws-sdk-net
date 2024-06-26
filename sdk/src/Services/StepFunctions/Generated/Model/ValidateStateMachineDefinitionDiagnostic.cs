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
    /// Describes an error found during validation. Validation errors found in the definition
    /// return in the response as <b>diagnostic elements</b>, rather than raise an exception.
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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