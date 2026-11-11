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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommandExecutions operation. List all command
    /// executions. <important> <ul> <li> <para> You must provide only the <c>startedTimeFilter</c>
    /// or the <c>completedTimeFilter</c> information. If you provide both time filters, the
    /// API will generate an error. You can use this information to retrieve a list of command
    /// executions within a specific timeframe. </para> </li> <li> <para> You must provide
    /// only the <c>commandArn</c> or the <c>thingArn</c> information depending on whether
    /// you want to list executions for a specific command or an IoT thing. If you provide
    /// both fields, the API will generate an error. </para> </li> </ul> <para> For more information
    /// about considerations for using this API, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-remote-command-execution-start-monitor.html#iot-remote-command-execution-list-cli">List
    /// command executions in your account (CLI)</a>. </para> </important>
    /// </summary>
    public partial class ListCommandExecutionsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. You can use this information to list
        /// all command executions for a particular command.
        /// </para>
        /// </summary>
        public string CommandArn { get; set; }

        /// <summary>
        /// Checks to see if the CommandArn property is set.
        /// </summary>
        internal bool IsSetCommandArn() => this.CommandArn != null;

        /// <summary>
        /// Gets and sets the property CompletedTimeFilter. 
        /// <para>
        /// List all command executions that completed any time before or after the date and time
        /// that you specify. The date and time uses the format <c>yyyy-MM-dd'T'HH:mm</c>.
        /// </para>
        /// </summary>
        public TimeFilter CompletedTimeFilter { get; set; }

        /// <summary>
        /// Checks to see if the CompletedTimeFilter property is set.
        /// </summary>
        internal bool IsSetCompletedTimeFilter() => this.CompletedTimeFilter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the command.
        /// </para>
        /// </summary>
        public CommandNamespace Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <c>null</c> to receive the first set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specify whether to list the command executions that were created in the ascending
        /// or descending order. By default, the API returns all commands in the descending order
        /// based on the start time or completion time of the executions, that are determined
        /// by the <c>startTimeFilter</c> and <c>completeTimeFilter</c> parameters.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StartedTimeFilter. 
        /// <para>
        /// List all command executions that started any time before or after the date and time
        /// that you specify. The date and time uses the format <c>yyyy-MM-dd'T'HH:mm</c>.
        /// </para>
        /// </summary>
        public TimeFilter StartedTimeFilter { get; set; }

        /// <summary>
        /// Checks to see if the StartedTimeFilter property is set.
        /// </summary>
        internal bool IsSetStartedTimeFilter() => this.StartedTimeFilter != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// List all command executions for the device that have a particular status. For example,
        /// you can filter the list to display only command executions that have failed or timed
        /// out.
        /// </para>
        /// </summary>
        public CommandExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the target device. You can use this information
        /// to list all command executions for a particular device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
