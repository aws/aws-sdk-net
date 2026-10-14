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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the TestState operation.
    /// </summary>
    public partial class TestStateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// A detailed explanation of the cause for the error when the execution of a state fails.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 32768)]
        public string Cause { get; set; }

        /// <summary>
        /// Checks to see if the Cause property is set.
        /// </summary>
        internal bool IsSetCause() => this.Cause != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error returned when the execution of a state fails.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property InspectionData. 
        /// <para>
        /// Returns additional details about the state's execution, including its input and output
        /// data processing flow, and HTTP request and response information. The <c>inspectionLevel</c>
        /// request parameter specifies which details are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public InspectionData InspectionData { get; set; }

        /// <summary>
        /// Checks to see if the InspectionData property is set.
        /// </summary>
        internal bool IsSetInspectionData() => this.InspectionData != null;

        /// <summary>
        /// Gets and sets the property NextState. 
        /// <para>
        /// The name of the next state to transition to. If you haven't defined a next state in
        /// your definition or if the execution of the state fails, this field doesn't contain
        /// a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string NextState { get; set; }

        /// <summary>
        /// Checks to see if the NextState property is set.
        /// </summary>
        internal bool IsSetNextState() => this.NextState != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The JSON output data of the state. Length constraints apply to the payload size, and
        /// are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The execution status of the state.
        /// </para>
        /// </summary>
        public TestExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
