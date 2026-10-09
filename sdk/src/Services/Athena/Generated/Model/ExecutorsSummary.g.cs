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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains summary information about an executor.
    /// </summary>
    public partial class ExecutorsSummary
    {
        /// <summary>
        /// Gets and sets the property ExecutorId. 
        /// <para>
        /// The UUID of the executor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100000)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutorId property is set.
        /// </summary>
        internal bool IsSetExecutorId() => this.ExecutorId != null;

        /// <summary>
        /// Gets and sets the property ExecutorSize. 
        /// <para>
        /// The smallest unit of compute that a session can request from Athena. Size is measured
        /// in data processing unit (DPU) values, a relative measure of processing power.
        /// </para>
        /// </summary>
        public long? ExecutorSize { get; set; }

        /// <summary>
        /// Checks to see if the ExecutorSize property is set.
        /// </summary>
        internal bool IsSetExecutorSize() => this.ExecutorSize.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutorState. 
        /// <para>
        /// The processing state of the executor. A description of each state follows.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATING</c> - The executor is being started, including acquiring resources.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATED</c> - The executor has been started.
        /// </para>
        ///  
        /// <para>
        ///  <c>REGISTERED</c> - The executor has been registered.
        /// </para>
        ///  
        /// <para>
        ///  <c>TERMINATING</c> - The executor is in the process of shutting down.
        /// </para>
        ///  
        /// <para>
        ///  <c>TERMINATED</c> - The executor is no longer running.
        /// </para>
        ///  
        /// <para>
        ///  <c>FAILED</c> - Due to a failure, the executor is no longer running.
        /// </para>
        /// </summary>
        public ExecutorState ExecutorState { get; set; }

        /// <summary>
        /// Checks to see if the ExecutorState property is set.
        /// </summary>
        internal bool IsSetExecutorState() => this.ExecutorState != null;

        /// <summary>
        /// Gets and sets the property ExecutorType. 
        /// <para>
        /// The type of executor used for the application (<c>COORDINATOR</c>, <c>GATEWAY</c>,
        /// or <c>WORKER</c>).
        /// </para>
        /// </summary>
        public ExecutorType ExecutorType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutorType property is set.
        /// </summary>
        internal bool IsSetExecutorType() => this.ExecutorType != null;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that the executor started.
        /// </para>
        /// </summary>
        public long? StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property TerminationDateTime. 
        /// <para>
        /// The date and time that the executor was terminated.
        /// </para>
        /// </summary>
        public long? TerminationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the TerminationDateTime property is set.
        /// </summary>
        internal bool IsSetTerminationDateTime() => this.TerminationDateTime.HasValue;
    }
}
