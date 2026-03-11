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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A connection function test result.
    /// </summary>
    public partial class ConnectionFunctionTestResult
    {
        private string _computeUtilization;
        private string _connectionFunctionErrorMessage;
        private List<string> _connectionFunctionExecutionLogs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _connectionFunctionOutput;
        private ConnectionFunctionSummary _connectionFunctionSummary;

        /// <summary>
        /// Gets and sets the property ComputeUtilization. 
        /// <para>
        /// The connection function compute utilization.
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
        /// Gets and sets the property ConnectionFunctionErrorMessage. 
        /// <para>
        /// The connection function error message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ConnectionFunctionErrorMessage
        {
            get { return this._connectionFunctionErrorMessage; }
            set { this._connectionFunctionErrorMessage = value; }
        }

        // Check to see if ConnectionFunctionErrorMessage property is set
        internal bool IsSetConnectionFunctionErrorMessage()
        {
            return this._connectionFunctionErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionFunctionExecutionLogs. 
        /// <para>
        /// The connection function execution logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> ConnectionFunctionExecutionLogs
        {
            get { return this._connectionFunctionExecutionLogs; }
            set { this._connectionFunctionExecutionLogs = value; }
        }

        // Check to see if ConnectionFunctionExecutionLogs property is set
        internal bool IsSetConnectionFunctionExecutionLogs()
        {
            return this._connectionFunctionExecutionLogs != null && (this._connectionFunctionExecutionLogs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionFunctionOutput. 
        /// <para>
        /// The connection function output.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ConnectionFunctionOutput
        {
            get { return this._connectionFunctionOutput; }
            set { this._connectionFunctionOutput = value; }
        }

        // Check to see if ConnectionFunctionOutput property is set
        internal bool IsSetConnectionFunctionOutput()
        {
            return this._connectionFunctionOutput != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionFunctionSummary. 
        /// <para>
        /// The connection function summary.
        /// </para>
        /// </summary>
        public ConnectionFunctionSummary ConnectionFunctionSummary
        {
            get { return this._connectionFunctionSummary; }
            set { this._connectionFunctionSummary = value; }
        }

        // Check to see if ConnectionFunctionSummary property is set
        internal bool IsSetConnectionFunctionSummary()
        {
            return this._connectionFunctionSummary != null;
        }

    }
}