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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommandInvocations operation. An invocation
    /// is copy of a command sent to a specific managed node. A command can apply to one or
    /// more managed nodes. A command invocation applies to one managed node. For example,
    /// if a user runs <c>SendCommand</c> against three managed nodes, then a command invocation
    /// is created for each requested managed node ID. <c>ListCommandInvocations</c> provide
    /// status about command execution.
    /// </summary>
    public partial class ListCommandInvocationsRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ListCommandInvocationsRequest() { }

        /// <summary>
        /// Instantiates ListCommandInvocationsRequest with the parameterized properties
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        public ListCommandInvocationsRequest(string commandId)
        {
            this.CommandId = commandId;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// (Optional) The invocations for a specific command ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// (Optional) If set this returns the response of the command executions and any command
        /// output. The default value is <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// (Optional) One or more filters. Use a filter to return a more specific list of results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<CommandFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<CommandFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// (Optional) The command execution details for a specific managed node ID.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) The maximum number of items to return for this call. The call also returns
        /// a token that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// (Optional) The token for the next set of items to return. (You received this token
        /// from a previous call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
