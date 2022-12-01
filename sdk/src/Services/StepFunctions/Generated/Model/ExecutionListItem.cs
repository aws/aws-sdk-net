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
        private DateTime? _startDate;
        private string _stateMachineArn;
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
        /// only if <code>mapRunArn</code> was specified in the <code>ListExecutions</code> API
        /// action. If <code>stateMachineArn</code> was specified in <code>ListExecutions</code>,
        /// the <code>itemCount</code> field isn't returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ItemCount
        {
            get { return this._itemCount.GetValueOrDefault(); }
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
        /// The Amazon Resource Name (ARN) of a Map Run. This field is returned only if <code>mapRunArn</code>
        /// was specified in the <code>ListExecutions</code> API action. If <code>stateMachineArn</code>
        /// was specified in <code>ListExecutions</code>, the <code>mapRunArn</code> isn't returned.
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
        /// brackets <code>&lt; &gt; { } [ ]</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <code>? *</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <code>" # % \ ^ | ~ ` $ &amp; , ; : /</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<code>U+0000-001F</code>, <code>U+007F-009F</code>)
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateMachineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the executed state machine.
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
        public DateTime StopDate
        {
            get { return this._stopDate.GetValueOrDefault(); }
            set { this._stopDate = value; }
        }

        // Check to see if StopDate property is set
        internal bool IsSetStopDate()
        {
            return this._stopDate.HasValue; 
        }

    }
}