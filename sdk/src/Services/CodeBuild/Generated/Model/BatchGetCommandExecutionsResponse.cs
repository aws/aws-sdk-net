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
    /// This is the response object from the BatchGetCommandExecutions operation.
    /// </summary>
    public partial class BatchGetCommandExecutionsResponse : AmazonWebServiceResponse
    {
        private List<CommandExecution> _commandExecutions = AWSConfigs.InitializeCollections ? new List<CommandExecution>() : null;
        private List<string> _commandExecutionsNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property CommandExecutionsNotFound. 
        /// <para>
        /// The IDs of command executions for which information could not be found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> CommandExecutionsNotFound
        {
            get { return this._commandExecutionsNotFound; }
            set { this._commandExecutionsNotFound = value; }
        }

        // Check to see if CommandExecutionsNotFound property is set
        internal bool IsSetCommandExecutionsNotFound()
        {
            return this._commandExecutionsNotFound != null && (this._commandExecutionsNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}