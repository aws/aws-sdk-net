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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains summary information about an executor.
    /// </summary>
    public partial class ExecutorsSummary
    {
        private string _executorId;
        private long? _executorSize;
        private ExecutorState _executorState;
        private ExecutorType _executorType;
        private long? _startDateTime;
        private long? _terminationDateTime;

        /// <summary>
        /// Gets and sets the property ExecutorId. 
        /// <para>
        /// The UUID of the executor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100000)]
        public string ExecutorId
        {
            get { return this._executorId; }
            set { this._executorId = value; }
        }

        // Check to see if ExecutorId property is set
        internal bool IsSetExecutorId()
        {
            return this._executorId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutorSize. 
        /// <para>
        /// The smallest unit of compute that a session can request from Athena. Size is measured
        /// in data processing unit (DPU) values, a relative measure of processing power.
        /// </para>
        /// </summary>
        public long ExecutorSize
        {
            get { return this._executorSize.GetValueOrDefault(); }
            set { this._executorSize = value; }
        }

        // Check to see if ExecutorSize property is set
        internal bool IsSetExecutorSize()
        {
            return this._executorSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutorState. 
        /// <para>
        /// The processing state of the executor. A description of each state follows.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATING</code> - The executor is being started, including acquiring resources.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATED</code> - The executor has been started.
        /// </para>
        ///  
        /// <para>
        ///  <code>REGISTERED</code> - The executor has been registered.
        /// </para>
        ///  
        /// <para>
        ///  <code>TERMINATING</code> - The executor is in the process of shutting down.
        /// </para>
        ///  
        /// <para>
        ///  <code>TERMINATED</code> - The executor is no longer running.
        /// </para>
        ///  
        /// <para>
        ///  <code>FAILED</code> - Due to a failure, the executor is no longer running.
        /// </para>
        /// </summary>
        public ExecutorState ExecutorState
        {
            get { return this._executorState; }
            set { this._executorState = value; }
        }

        // Check to see if ExecutorState property is set
        internal bool IsSetExecutorState()
        {
            return this._executorState != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutorType. 
        /// <para>
        /// The type of executor used for the application (<code>COORDINATOR</code>, <code>GATEWAY</code>,
        /// or <code>WORKER</code>).
        /// </para>
        /// </summary>
        public ExecutorType ExecutorType
        {
            get { return this._executorType; }
            set { this._executorType = value; }
        }

        // Check to see if ExecutorType property is set
        internal bool IsSetExecutorType()
        {
            return this._executorType != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that the executor started.
        /// </para>
        /// </summary>
        public long StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminationDateTime. 
        /// <para>
        /// The date and time that the executor was terminated.
        /// </para>
        /// </summary>
        public long TerminationDateTime
        {
            get { return this._terminationDateTime.GetValueOrDefault(); }
            set { this._terminationDateTime = value; }
        }

        // Check to see if TerminationDateTime property is set
        internal bool IsSetTerminationDateTime()
        {
            return this._terminationDateTime.HasValue; 
        }

    }
}