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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetCommandExecutions operation.
    /// Gets information about the command executions.
    /// </summary>
    public partial class BatchGetCommandExecutionsRequest : AmazonCodeBuildRequest
    {
        private List<string> _commandExecutionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sandboxId;

        /// <summary>
        /// Gets and sets the property CommandExecutionIds. 
        /// <para>
        /// A comma separated list of <c>commandExecutionIds</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> CommandExecutionIds
        {
            get { return this._commandExecutionIds; }
            set { this._commandExecutionIds = value; }
        }

        // Check to see if CommandExecutionIds property is set
        internal bool IsSetCommandExecutionIds()
        {
            return this._commandExecutionIds != null && (this._commandExecutionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SandboxId. 
        /// <para>
        /// A <c>sandboxId</c> or <c>sandboxArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string SandboxId
        {
            get { return this._sandboxId; }
            set { this._sandboxId = value; }
        }

        // Check to see if SandboxId property is set
        internal bool IsSetSandboxId()
        {
            return this._sandboxId != null;
        }

    }
}