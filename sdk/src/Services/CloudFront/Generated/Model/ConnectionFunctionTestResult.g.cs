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
    /// A connection function test result.
    /// </summary>
    public partial class ConnectionFunctionTestResult
    {
        /// <summary>
        /// Gets and sets the property ComputeUtilization. 
        /// <para>
        /// The connection function compute utilization.
        /// </para>
        /// </summary>
        public string ComputeUtilization { get; set; }

        /// <summary>
        /// Checks to see if the ComputeUtilization property is set.
        /// </summary>
        internal bool IsSetComputeUtilization() => this.ComputeUtilization != null;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionErrorMessage. 
        /// <para>
        /// The connection function error message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ConnectionFunctionErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionFunctionErrorMessage property is set.
        /// </summary>
        internal bool IsSetConnectionFunctionErrorMessage() => this.ConnectionFunctionErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionExecutionLogs. 
        /// <para>
        /// The connection function execution logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> ConnectionFunctionExecutionLogs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionFunctionExecutionLogs property is set.
        /// </summary>
        internal bool IsSetConnectionFunctionExecutionLogs() => this.ConnectionFunctionExecutionLogs != null && (this.ConnectionFunctionExecutionLogs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionFunctionOutput. 
        /// <para>
        /// The connection function output.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ConnectionFunctionOutput { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionFunctionOutput property is set.
        /// </summary>
        internal bool IsSetConnectionFunctionOutput() => this.ConnectionFunctionOutput != null;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionSummary. 
        /// <para>
        /// The connection function summary.
        /// </para>
        /// </summary>
        public ConnectionFunctionSummary ConnectionFunctionSummary { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionFunctionSummary property is set.
        /// </summary>
        internal bool IsSetConnectionFunctionSummary() => this.ConnectionFunctionSummary != null;
    }
}
