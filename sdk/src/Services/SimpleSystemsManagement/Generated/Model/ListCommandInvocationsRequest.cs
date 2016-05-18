/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommandInvocations operation.
    /// An invocation is copy of a command sent to a specific instance. A command can apply
    /// to one or more instances. A command invocation applies to one instance. For example,
    /// if a user executes SendCommand against three instances, then a command invocation
    /// is created for each requested instance ID. ListCommandInvocations provide status about
    /// command execution.
    /// </summary>
    public partial class ListCommandInvocationsRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _commandId;
        private bool? _details;
        private List<CommandFilter> _filters = new List<CommandFilter>();
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListCommandInvocationsRequest() { }

        /// <summary>
        /// Instantiates ListCommandInvocationsRequest with the parameterized properties
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        public ListCommandInvocationsRequest(string commandId)
        {
            _commandId = commandId;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// (Optional) The invocations for a specific command ID.
        /// </para>
        /// </summary>
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// (Optional) If set this returns the response of the command executions and any command
        /// output. By default this is set to False. 
        /// </para>
        /// </summary>
        public bool Details
        {
            get { return this._details.GetValueOrDefault(); }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// (Optional) One or more filters. Use a filter to return a more specific list of results.
        /// </para>
        /// </summary>
        public List<CommandFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// (Optional) The command execution details for a specific instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) The maximum number of items to return for this call. The call also returns
        /// a token that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// (Optional) The token for the next set of items to return. (You received this token
        /// from a previous call.)
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