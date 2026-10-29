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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The status of the instance fleet.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceFleetStatus
    {
        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// A code representing the instance fleet status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONING</c>—The instance fleet is provisioning Amazon EC2 resources and is
        /// not yet ready to run jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOOTSTRAPPING</c>—Amazon EC2 instances and other resources have been provisioned
        /// and the bootstrap actions specified for the instances are underway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>—Amazon EC2 instances and other resources are running. They are either
        /// executing jobs or waiting to execute jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESIZING</c>—A resize operation is underway. Amazon EC2 instances are either being
        /// added or removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c>—A resize operation could not complete. Existing Amazon EC2 instances
        /// are running, but instances can't be added or removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATING</c>—The instance fleet is terminating Amazon EC2 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATED</c>—The instance fleet is no longer active, and all Amazon EC2 instances
        /// have been terminated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceFleetState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// Provides status change reason details for the instance fleet.
        /// </para>
        /// </summary>
        public InstanceFleetStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeReason property is set.
        /// </summary>
        internal bool IsSetStateChangeReason() => this.StateChangeReason != null;

        /// <summary>
        /// Gets and sets the property Timeline. 
        /// <para>
        /// Provides historical timestamps for the instance fleet, including the time of creation,
        /// the time it became ready to run jobs, and the time of termination.
        /// </para>
        /// </summary>
        public InstanceFleetTimeline Timeline { get; set; }

        /// <summary>
        /// Checks to see if the Timeline property is set.
        /// </summary>
        internal bool IsSetTimeline() => this.Timeline != null;
    }
}
