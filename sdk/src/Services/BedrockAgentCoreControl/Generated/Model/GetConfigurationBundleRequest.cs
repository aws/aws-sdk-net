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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfigurationBundle operation.
    /// Gets the latest version of a configuration bundle. By default, returns the latest
    /// version on the mainline branch. Use <c>GetConfigurationBundleVersion</c> to retrieve
    /// a specific historical version.
    /// </summary>
    public partial class GetConfigurationBundleRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _branchName;
        private string _bundleId;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The branch name to get the latest version from. If not specified, returns the latest
        /// version on the mainline branch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The unique identifier of the configuration bundle to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

    }
}