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
    /// Contains information about the status of a session.
    /// </summary>
    public partial class SessionStatus
    {
        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that the session ended.
        /// </para>
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdleSinceDateTime. 
        /// <para>
        /// The date and time starting at which the session became idle. Can be empty if the session
        /// is not currently idle.
        /// </para>
        /// </summary>
        public DateTime? IdleSinceDateTime { get; set; }

        /// <summary>
        /// Checks to see if the IdleSinceDateTime property is set.
        /// </summary>
        internal bool IsSetIdleSinceDateTime() => this.IdleSinceDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDateTime. 
        /// <para>
        /// The most recent date and time that the session was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDateTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedDateTime() => this.LastModifiedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that the session started.
        /// </para>
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the session. A description of each state follows.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATING</c> - The session is being started, including acquiring resources.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATED</c> - The session has been started.
        /// </para>
        ///  
        /// <para>
        ///  <c>IDLE</c> - The session is able to accept a calculation.
        /// </para>
        ///  
        /// <para>
        ///  <c>BUSY</c> - The session is processing another task and is unable to accept a calculation.
        /// </para>
        ///  
        /// <para>
        ///  <c>TERMINATING</c> - The session is in the process of shutting down.
        /// </para>
        ///  
        /// <para>
        ///  <c>TERMINATED</c> - The session and its resources are no longer running.
        /// </para>
        ///  
        /// <para>
        ///  <c>DEGRADED</c> - The session has no healthy coordinators.
        /// </para>
        ///  
        /// <para>
        ///  <c>FAILED</c> - Due to a failure, the session and its resources are no longer running.
        /// </para>
        /// </summary>
        public SessionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason for the session state change (for example, canceled because the session
        /// was terminated).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeReason property is set.
        /// </summary>
        internal bool IsSetStateChangeReason() => this.StateChangeReason != null;
    }
}
