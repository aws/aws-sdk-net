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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A system prompt sourced from a configuration bundle version.
    /// </summary>
    public partial class SystemPromptConfigurationBundle
    {
        private string _bundleArn;
        private string _systemPromptJsonPath;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleArn
        {
            get { return this._bundleArn; }
            set { this._bundleArn = value; }
        }

        // Check to see if BundleArn property is set
        internal bool IsSetBundleArn()
        {
            return this._bundleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SystemPromptJsonPath. 
        /// <para>
        /// The JSON path within the configuration bundle that contains the system prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SystemPromptJsonPath
        {
            get { return this._systemPromptJsonPath; }
            set { this._systemPromptJsonPath = value; }
        }

        // Check to see if SystemPromptJsonPath property is set
        internal bool IsSetSystemPromptJsonPath()
        {
            return this._systemPromptJsonPath != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version identifier of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}