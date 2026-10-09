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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private FarmMember _farm;
        private FleetMember _fleet;
        private JobMember _job;
        private QueueMember _queue;

        /// <summary>
        /// Gets and sets the property Farm. 
        /// <para>
        /// A membership on a farm.
        /// </para>
        /// </summary>
        public FarmMember Farm
        {
            get { return this._farm; }
            set { this._farm = value; }
        }

        // Check to see if Farm property is set
        internal bool IsSetFarm()
        {
            return this._farm != null;
        }

        /// <summary>
        /// Gets and sets the property Fleet. 
        /// <para>
        /// A membership on a fleet.
        /// </para>
        /// </summary>
        public FleetMember Fleet
        {
            get { return this._fleet; }
            set { this._fleet = value; }
        }

        // Check to see if Fleet property is set
        internal bool IsSetFleet()
        {
            return this._fleet != null;
        }

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// A membership on a job.
        /// </para>
        /// </summary>
        public JobMember Job
        {
            get { return this._job; }
            set { this._job = value; }
        }

        // Check to see if Job property is set
        internal bool IsSetJob()
        {
            return this._job != null;
        }

        /// <summary>
        /// Gets and sets the property Queue. 
        /// <para>
        /// A membership on a queue.
        /// </para>
        /// </summary>
        public QueueMember Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

    }
}