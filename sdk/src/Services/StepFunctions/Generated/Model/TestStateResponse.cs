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
    /// This is the response object from the TestState operation.
    /// </summary>
    public partial class TestStateResponse : AmazonWebServiceResponse
    {
        private string _cause;
        private string _error;
        private InspectionData _inspectionData;
        private string _nextState;
        private string _output;
        private TestExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// A detailed explanation of the cause for the error when the execution of a state fails.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=32768)]
        public string Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error returned when the execution of a state fails.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Error
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
        /// Gets and sets the property InspectionData. 
        /// <para>
        /// Returns additional details about the state's execution, including its input and output
        /// data processing flow, and HTTP request and response information. The <c>inspectionLevel</c>
        /// request parameter specifies which details are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public InspectionData InspectionData
        {
            get { return this._inspectionData; }
            set { this._inspectionData = value; }
        }

        // Check to see if InspectionData property is set
        internal bool IsSetInspectionData()
        {
            return this._inspectionData != null;
        }

        /// <summary>
        /// Gets and sets the property NextState. 
        /// <para>
        /// The name of the next state to transition to. If you haven't defined a next state in
        /// your definition or if the execution of the state fails, this field doesn't contain
        /// a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string NextState
        {
            get { return this._nextState; }
            set { this._nextState = value; }
        }

        // Check to see if NextState property is set
        internal bool IsSetNextState()
        {
            return this._nextState != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The JSON output data of the state. Length constraints apply to the payload size, and
        /// are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The execution status of the state.
        /// </para>
        /// </summary>
        public TestExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}