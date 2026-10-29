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
    /// Information about a Session Manager connection to a managed node.
    /// </summary>
    public partial class Session
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        ///  <c>Standard</c> access type is the default for Session Manager sessions. <c>JustInTime</c>
        /// is the access type for <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-just-in-time-node-access.html">Just-in-time
        /// node access</a>.
        /// </para>
        /// </summary>
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Session Manager SSM document used to define the parameters and plugin
        /// settings for the session. For example, <c>SSM-SessionManagerRunShell</c>.
        /// </para>
        /// </summary>
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, when the session was terminated.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum duration of a session before it terminates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public string MaxSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxSessionDuration property is set.
        /// </summary>
        internal bool IsSetMaxSessionDuration() => this.MaxSessionDuration != null;

        /// <summary>
        /// Gets and sets the property OutputUrl. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SessionManagerOutputUrl OutputUrl { get; set; }

        /// <summary>
        /// Checks to see if the OutputUrl property is set.
        /// </summary>
        internal bool IsSetOutputUrl() => this.OutputUrl != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The ID of the Amazon Web Services user that started the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for connecting to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 96)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, when the session began.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the session. For example, "Connected" or "Terminated".
        /// </para>
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The managed node that the Session Manager session connected to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
