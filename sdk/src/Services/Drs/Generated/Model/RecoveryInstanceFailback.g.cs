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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object representing failback related information of the Recovery Instance.
    /// </summary>
    public partial class RecoveryInstanceFailback
    {
        /// <summary>
        /// Gets and sets the property AgentLastSeenByServiceDateTime. 
        /// <para>
        /// The date and time the agent on the Recovery Instance was last seen by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string AgentLastSeenByServiceDateTime { get; set; }

        /// <summary>
        /// Checks to see if the AgentLastSeenByServiceDateTime property is set.
        /// </summary>
        internal bool IsSetAgentLastSeenByServiceDateTime() => this.AgentLastSeenByServiceDateTime != null;

        /// <summary>
        /// Gets and sets the property ElapsedReplicationDuration. 
        /// <para>
        /// The amount of time that the Recovery Instance has been replicating for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string ElapsedReplicationDuration { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedReplicationDuration property is set.
        /// </summary>
        internal bool IsSetElapsedReplicationDuration() => this.ElapsedReplicationDuration != null;

        /// <summary>
        /// Gets and sets the property FailbackClientID. 
        /// <para>
        /// The ID of the failback client that this Recovery Instance is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FailbackClientID { get; set; }

        /// <summary>
        /// Checks to see if the FailbackClientID property is set.
        /// </summary>
        internal bool IsSetFailbackClientID() => this.FailbackClientID != null;

        /// <summary>
        /// Gets and sets the property FailbackClientLastSeenByServiceDateTime. 
        /// <para>
        /// The date and time that the failback client was last seen by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string FailbackClientLastSeenByServiceDateTime { get; set; }

        /// <summary>
        /// Checks to see if the FailbackClientLastSeenByServiceDateTime property is set.
        /// </summary>
        internal bool IsSetFailbackClientLastSeenByServiceDateTime() => this.FailbackClientLastSeenByServiceDateTime != null;

        /// <summary>
        /// Gets and sets the property FailbackInitiationTime. 
        /// <para>
        /// The date and time that the failback initiation started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string FailbackInitiationTime { get; set; }

        /// <summary>
        /// Checks to see if the FailbackInitiationTime property is set.
        /// </summary>
        internal bool IsSetFailbackInitiationTime() => this.FailbackInitiationTime != null;

        /// <summary>
        /// Gets and sets the property FailbackJobID. 
        /// <para>
        /// The Job ID of the last failback log for this Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 24, Max = 24)]
        public string FailbackJobID { get; set; }

        /// <summary>
        /// Checks to see if the FailbackJobID property is set.
        /// </summary>
        internal bool IsSetFailbackJobID() => this.FailbackJobID != null;

        /// <summary>
        /// Gets and sets the property FailbackLaunchType. 
        /// <para>
        /// The launch type (Recovery / Drill) of the last launch for the failback replication
        /// of this recovery instance.
        /// </para>
        /// </summary>
        public FailbackLaunchType FailbackLaunchType { get; set; }

        /// <summary>
        /// Checks to see if the FailbackLaunchType property is set.
        /// </summary>
        internal bool IsSetFailbackLaunchType() => this.FailbackLaunchType != null;

        /// <summary>
        /// Gets and sets the property FailbackToOriginalServer. 
        /// <para>
        /// Whether we are failing back to the original Source Server for this Recovery Instance.
        /// </para>
        /// </summary>
        public bool? FailbackToOriginalServer { get; set; }

        /// <summary>
        /// Checks to see if the FailbackToOriginalServer property is set.
        /// </summary>
        internal bool IsSetFailbackToOriginalServer() => this.FailbackToOriginalServer.HasValue;

        /// <summary>
        /// Gets and sets the property FirstByteDateTime. 
        /// <para>
        /// The date and time of the first byte that was replicated from the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string FirstByteDateTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstByteDateTime property is set.
        /// </summary>
        internal bool IsSetFirstByteDateTime() => this.FirstByteDateTime != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the failback process that this Recovery Instance is in.
        /// </para>
        /// </summary>
        public FailbackState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
