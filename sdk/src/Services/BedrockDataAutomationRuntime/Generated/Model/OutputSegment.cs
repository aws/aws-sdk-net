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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
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
namespace Amazon.BedrockDataAutomationRuntime.Model
{
    /// <summary>
    /// Results for an output segment
    /// </summary>
    public partial class OutputSegment
    {
        private string _customOutput;
        private CustomOutputStatus _customOutputStatus;
        private string _standardOutput;

        /// <summary>
        /// Gets and sets the property CustomOutput. 
        /// <para>
        /// Custom output response
        /// </para>
        /// </summary>
        public string CustomOutput
        {
            get { return this._customOutput; }
            set { this._customOutput = value; }
        }

        // Check to see if CustomOutput property is set
        internal bool IsSetCustomOutput()
        {
            return this._customOutput != null;
        }

        /// <summary>
        /// Gets and sets the property CustomOutputStatus. 
        /// <para>
        /// Status of blueprint match
        /// </para>
        /// </summary>
        public CustomOutputStatus CustomOutputStatus
        {
            get { return this._customOutputStatus; }
            set { this._customOutputStatus = value; }
        }

        // Check to see if CustomOutputStatus property is set
        internal bool IsSetCustomOutputStatus()
        {
            return this._customOutputStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StandardOutput. 
        /// <para>
        /// Standard output response
        /// </para>
        /// </summary>
        public string StandardOutput
        {
            get { return this._standardOutput; }
            set { this._standardOutput = value; }
        }

        // Check to see if StandardOutput property is set
        internal bool IsSetStandardOutput()
        {
            return this._standardOutput != null;
        }

    }
}