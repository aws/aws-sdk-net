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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the ListCommandExecutions operation.
    /// List all command executions.
    /// 
    ///  <important> <ul> <li> 
    /// <para>
    /// You must provide only the <c>startedTimeFilter</c> or the <c>completedTimeFilter</c>
    /// information. If you provide both time filters, the API will generate an error. You
    /// can use this information to retrieve a list of command executions within a specific
    /// timeframe.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must provide only the <c>commandArn</c> or the <c>thingArn</c> information depending
    /// on whether you want to list executions for a specific command or an IoT thing. If
    /// you provide both fields, the API will generate an error.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about considerations for using this API, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-remote-command-execution-start-monitor.html#iot-remote-command-execution-list-cli">List
    /// command executions in your account (CLI)</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListCommandExecutionsRequest : AmazonIoTRequest
    {
        private string _commandArn;
        private TimeFilter _completedTimeFilter;
        private int? _maxResults;
        private CommandNamespace _awsNamespace;
        private string _nextToken;
        private SortOrder _sortOrder;
        private TimeFilter _startedTimeFilter;
        private CommandExecutionStatus _status;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. You can use this information to list
        /// all command executions for a particular command.
        /// </para>
        /// </summary>
        public string CommandArn
        {
            get { return this._commandArn; }
            set { this._commandArn = value; }
        }

        // Check to see if CommandArn property is set
        internal bool IsSetCommandArn()
        {
            return this._commandArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedTimeFilter. 
        /// <para>
        /// List all command executions that completed any time before or after the date and time
        /// that you specify. The date and time uses the format <c>yyyy-MM-dd'T'HH:mm</c>.
        /// </para>
        /// </summary>
        public TimeFilter CompletedTimeFilter
        {
            get { return this._completedTimeFilter; }
            set { this._completedTimeFilter = value; }
        }

        // Check to see if CompletedTimeFilter property is set
        internal bool IsSetCompletedTimeFilter()
        {
            return this._completedTimeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the command.
        /// </para>
        /// </summary>
        public CommandNamespace Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <c>null</c> to receive the first set of results.
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

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specify whether to list the command executions that were created in the ascending
        /// or descending order. By default, the API returns all commands in the descending order
        /// based on the start time or completion time of the executions, that are determined
        /// by the <c>startTimeFilter</c> and <c>completeTimeFilter</c> parameters.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StartedTimeFilter. 
        /// <para>
        /// List all command executions that started any time before or after the date and time
        /// that you specify. The date and time uses the format <c>yyyy-MM-dd'T'HH:mm</c>.
        /// </para>
        /// </summary>
        public TimeFilter StartedTimeFilter
        {
            get { return this._startedTimeFilter; }
            set { this._startedTimeFilter = value; }
        }

        // Check to see if StartedTimeFilter property is set
        internal bool IsSetStartedTimeFilter()
        {
            return this._startedTimeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// List all command executions for the device that have a particular status. For example,
        /// you can filter the list to display only command executions that have failed or timed
        /// out.
        /// </para>
        /// </summary>
        public CommandExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the target device. You can use this information
        /// to list all command executions for a particular device.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}