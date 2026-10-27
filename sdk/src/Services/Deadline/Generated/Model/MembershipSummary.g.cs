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
    /// A membership record for a principal on a single Deadline Cloud resource. The summary
    /// identifies the resource that the principal is a member of and the principal's membership
    /// level for that resource.
    /// </summary>
    public partial class MembershipSummary
    {
        /// <summary>
        /// Gets and sets the property Farm. A membership on a farm.
        /// </summary>
        public FarmMember Farm { get; set; }

        /// <summary>
        /// Checks to see if the Farm property is set.
        /// </summary>
        internal bool IsSetFarm() => this.Farm != null;

        /// <summary>
        /// Gets and sets the property Fleet. A membership on a fleet.
        /// </summary>
        public FleetMember Fleet { get; set; }

        /// <summary>
        /// Checks to see if the Fleet property is set.
        /// </summary>
        internal bool IsSetFleet() => this.Fleet != null;

        /// <summary>
        /// Gets and sets the property Job. A membership on a job.
        /// </summary>
        public JobMember Job { get; set; }

        /// <summary>
        /// Checks to see if the Job property is set.
        /// </summary>
        internal bool IsSetJob() => this.Job != null;

        /// <summary>
        /// Gets and sets the property Queue. A membership on a queue.
        /// </summary>
        public QueueMember Queue { get; set; }

        /// <summary>
        /// Checks to see if the Queue property is set.
        /// </summary>
        internal bool IsSetQueue() => this.Queue != null;
    }
}
