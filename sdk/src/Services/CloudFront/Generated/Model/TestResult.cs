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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains the result of testing a CloudFront function with <code>TestFunction</code>.
    /// </summary>
    public partial class TestResult
    {
        private string _computeUtilization;
        private string _functionErrorMessage;
        private List<string> _functionExecutionLogs = new List<string>();
        private string _functionOutput;
        private FunctionSummary _functionSummary;

        /// <summary>
        /// Gets and sets the property ComputeUtilization. 
        /// <para>
        /// The amount of time that the function took to run as a percentage of the maximum allowed
        /// time. For example, a compute utilization of 35 means that the function completed in
        /// 35% of the maximum allowed time.
        /// </para>
        /// </summary>
        public string ComputeUtilization
        {
            get { return this._computeUtilization; }
            set { this._computeUtilization = value; }
        }

        // Check to see if ComputeUtilization property is set
        internal bool IsSetComputeUtilization()
        {
            return this._computeUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionErrorMessage. 
        /// <para>
        /// If the result of testing the function was an error, this field contains the error
        /// message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FunctionErrorMessage
        {
            get { return this._functionErrorMessage; }
            set { this._functionErrorMessage = value; }
        }

        // Check to see if FunctionErrorMessage property is set
        internal bool IsSetFunctionErrorMessage()
        {
            return this._functionErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionExecutionLogs. 
        /// <para>
        /// Contains the log lines that the function wrote (if any) when running the test.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> FunctionExecutionLogs
        {
            get { return this._functionExecutionLogs; }
            set { this._functionExecutionLogs = value; }
        }

        // Check to see if FunctionExecutionLogs property is set
        internal bool IsSetFunctionExecutionLogs()
        {
            return this._functionExecutionLogs != null && this._functionExecutionLogs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FunctionOutput. 
        /// <para>
        /// The event object returned by the function. For more information about the structure
        /// of the event object, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/functions-event-structure.html">Event
        /// object structure</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FunctionOutput
        {
            get { return this._functionOutput; }
            set { this._functionOutput = value; }
        }

        // Check to see if FunctionOutput property is set
        internal bool IsSetFunctionOutput()
        {
            return this._functionOutput != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionSummary. 
        /// <para>
        /// Contains configuration information and metadata about the CloudFront function that
        /// was tested.
        /// </para>
        /// </summary>
        public FunctionSummary FunctionSummary
        {
            get { return this._functionSummary; }
            set { this._functionSummary = value; }
        }

        // Check to see if FunctionSummary property is set
        internal bool IsSetFunctionSummary()
        {
            return this._functionSummary != null;
        }

    }
}