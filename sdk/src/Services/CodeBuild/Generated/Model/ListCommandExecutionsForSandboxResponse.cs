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
    /// This is the response object from the ListCommandExecutionsForSandbox operation.
    /// </summary>
    public partial class ListCommandExecutionsForSandboxResponse : AmazonWebServiceResponse
    {
        private List<CommandExecution> _commandExecutions = AWSConfigs.InitializeCollections ? new List<CommandExecution>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CommandExecutions. 
        /// <para>
        /// Information about the requested command executions.
        /// </para>
        /// </summary>
        public List<CommandExecution> CommandExecutions
        {
            get { return this._commandExecutions; }
            set { this._commandExecutions = value; }
        }

        // Check to see if CommandExecutions property is set
        internal bool IsSetCommandExecutions()
        {
            return this._commandExecutions != null && (this._commandExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Information about the next token to get paginated results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}