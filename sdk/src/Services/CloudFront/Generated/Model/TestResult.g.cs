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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains the result of testing a CloudFront function with <c>TestFunction</c>.
    /// </summary>
    public partial class TestResult
    {
        /// <summary>
        /// Gets and sets the property ComputeUtilization. 
        /// <para>
        /// The amount of time that the function took to run as a percentage of the maximum allowed
        /// time. For example, a compute utilization of 35 means that the function completed in
        /// 35% of the maximum allowed time.
        /// </para>
        /// </summary>
        public string ComputeUtilization { get; set; }

        /// <summary>
        /// Checks to see if the ComputeUtilization property is set.
        /// </summary>
        internal bool IsSetComputeUtilization() => this.ComputeUtilization != null;

        /// <summary>
        /// Gets and sets the property FunctionErrorMessage. 
        /// <para>
        /// If the result of testing the function was an error, this field contains the error
        /// message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FunctionErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the FunctionErrorMessage property is set.
        /// </summary>
        internal bool IsSetFunctionErrorMessage() => this.FunctionErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FunctionExecutionLogs. 
        /// <para>
        /// Contains the log lines that the function wrote (if any) when running the test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> FunctionExecutionLogs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FunctionExecutionLogs property is set.
        /// </summary>
        internal bool IsSetFunctionExecutionLogs() => this.FunctionExecutionLogs != null && (this.FunctionExecutionLogs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FunctionOutput. 
        /// <para>
        /// The event object returned by the function. For more information about the structure
        /// of the event object, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/functions-event-structure.html">Event
        /// object structure</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FunctionOutput { get; set; }

        /// <summary>
        /// Checks to see if the FunctionOutput property is set.
        /// </summary>
        internal bool IsSetFunctionOutput() => this.FunctionOutput != null;

        /// <summary>
        /// Gets and sets the property FunctionSummary. 
        /// <para>
        /// Contains configuration information and metadata about the CloudFront function that
        /// was tested.
        /// </para>
        /// </summary>
        public FunctionSummary FunctionSummary { get; set; }

        /// <summary>
        /// Checks to see if the FunctionSummary property is set.
        /// </summary>
        internal bool IsSetFunctionSummary() => this.FunctionSummary != null;
    }
}
