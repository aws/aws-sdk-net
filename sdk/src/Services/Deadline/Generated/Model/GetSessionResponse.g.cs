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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EndedAt. The date and time the resource ended running.
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FleetId. The fleet ID for the session.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property HostProperties. Provides the Amazon EC2 properties of the
        /// host.
        /// </summary>
        public HostPropertiesResponse HostProperties { get; set; }

        /// <summary>
        /// Checks to see if the HostProperties property is set.
        /// </summary>
        internal bool IsSetHostProperties() => this.HostProperties != null;

        /// <summary>
        /// Gets and sets the property LifecycleStatus. The life cycle status of the session.
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStatus property is set.
        /// </summary>
        internal bool IsSetLifecycleStatus() => this.LifecycleStatus != null;

        /// <summary>
        /// Gets and sets the property Log. The session log.
        /// </summary>
        [AWSProperty(Required = true)]
        public LogConfiguration Log { get; set; }

        /// <summary>
        /// Checks to see if the Log property is set.
        /// </summary>
        internal bool IsSetLog() => this.Log != null;

        /// <summary>
        /// Gets and sets the property SessionId. The session ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. The date and time the resource started running.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetLifecycleStatus. The life cycle status with which
        /// the session started.
        /// </summary>
        public SessionLifecycleTargetStatus TargetLifecycleStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetLifecycleStatus property is set.
        /// </summary>
        internal bool IsSetTargetLifecycleStatus() => this.TargetLifecycleStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The date and time the resource was updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. The user or system that updated this resource.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;

        /// <summary>
        /// Gets and sets the property WorkerId. The worker ID for the session.
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;

        /// <summary>
        /// Gets and sets the property WorkerLog. The worker log for the session.
        /// </summary>
        public LogConfiguration WorkerLog { get; set; }

        /// <summary>
        /// Checks to see if the WorkerLog property is set.
        /// </summary>
        internal bool IsSetWorkerLog() => this.WorkerLog != null;
    }
}
