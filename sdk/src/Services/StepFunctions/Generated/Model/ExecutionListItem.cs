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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about an execution.
    /// </summary>
    public partial class ExecutionListItem
    {
        private string _executionArn;
        private int? _itemCount;
        private string _mapRunArn;
        private string _name;
        private int? _redriveCount;
        private DateTime? _redriveDate;
        private DateTime? _startDate;
        private string _stateMachineAliasArn;
        private string _stateMachineArn;
        private string _stateMachineVersionArn;
        private ExecutionStatus _status;
        private DateTime? _stopDate;

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExecutionArn
        {
            get { return this._executionArn; }
            set { this._executionArn = value; }
        }

        // Check to see if ExecutionArn property is set
        internal bool IsSetExecutionArn()
        {
            return this._executionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The total number of items processed in a child workflow execution. This field is returned
        /// only if <c>mapRunArn</c> was specified in the <c>ListExecutions</c> API action. If
        /// <c>stateMachineArn</c> was specified in <c>ListExecutions</c>, the <c>itemCount</c>
        /// field isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Map Run. This field is returned only if <c>mapRunArn</c>
        /// was specified in the <c>ListExecutions</c> API action. If <c>stateMachineArn</c> was
        /// specified in <c>ListExecutions</c>, the <c>mapRunArn</c> isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string MapRunArn
        {
            get { return this._mapRunArn; }
            set { this._mapRunArn = value; }
        }

        // Check to see if MapRunArn property is set
        internal bool IsSetMapRunArn()
        {
            return this._mapRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the execution.
        /// </para>
        ///  
        /// <para>
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// white space
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <c>&lt; &gt; { } [ ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <c>? *</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <c>" # % \ ^ | ~ ` $ &amp; , ; : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<c>U+0000-001F</c>, <c>U+007F-009F</c>, <c>U+FFFE-FFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// surrogates (<c>U+D800-DFFF</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// invalid characters (<c> U+10FFFF</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable logging with CloudWatch Logs, the name should only contain 0-9, A-Z, a-z,
        /// - and _.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RedriveCount. 
        /// <para>
        /// The number of times you've redriven an execution. If you have not yet redriven an
        /// execution, the <c>redriveCount</c> is 0. This count is only updated when you successfully
        /// redrive an execution.
        /// </para>
        /// </summary>
        public int? RedriveCount
        {
            get { return this._redriveCount; }
            set { this._redriveCount = value; }
        }

        // Check to see if RedriveCount property is set
        internal bool IsSetRedriveCount()
        {
            return this._redriveCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedriveDate. 
        /// <para>
        /// The date the execution was last redriven.
        /// </para>
        /// </summary>
        public DateTime? RedriveDate
        {
            get { return this._redriveDate; }
            set { this._redriveDate = value; }
        }

        // Check to see if RedriveDate property is set
        internal bool IsSetRedriveDate()
        {
            return this._redriveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateMachineAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine alias used to start an execution.
        /// </para>
        ///  
        /// <para>
        /// If the state machine execution was started with an unqualified ARN or a version ARN,
        /// it returns null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateMachineAliasArn
        {
            get { return this._stateMachineAliasArn; }
            set { this._stateMachineAliasArn = value; }
        }

        // Check to see if StateMachineAliasArn property is set
        internal bool IsSetStateMachineAliasArn()
        {
            return this._stateMachineAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine that ran the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StateMachineArn
        {
            get { return this._stateMachineArn; }
            set { this._stateMachineArn = value; }
        }

        // Check to see if StateMachineArn property is set
        internal bool IsSetStateMachineArn()
        {
            return this._stateMachineArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachineVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine version associated with the execution.
        /// </para>
        ///  
        /// <para>
        /// If the state machine execution was started with an unqualified ARN, it returns null.
        /// </para>
        ///  
        /// <para>
        /// If the execution was started using a <c>stateMachineAliasArn</c>, both the <c>stateMachineAliasArn</c>
        /// and <c>stateMachineVersionArn</c> parameters contain the respective values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateMachineVersionArn
        {
            get { return this._stateMachineVersionArn; }
            set { this._stateMachineVersionArn = value; }
        }

        // Check to see if StateMachineVersionArn property is set
        internal bool IsSetStateMachineVersionArn()
        {
            return this._stateMachineVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus Status
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
        /// Gets and sets the property StopDate. 
        /// <para>
        /// If the execution already ended, the date the execution stopped.
        /// </para>
        /// </summary>
        public DateTime? StopDate
        {
            get { return this._stopDate; }
            set { this._stopDate = value; }
        }

        // Check to see if StopDate property is set
        internal bool IsSetStopDate()
        {
            return this._stopDate.HasValue; 
        }

    }
}