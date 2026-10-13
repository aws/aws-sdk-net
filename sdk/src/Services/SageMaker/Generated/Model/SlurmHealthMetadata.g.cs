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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Metadata information about the health of a Slurm component on the controller node
    /// of a HyperPod cluster.
    /// </summary>
    public partial class SlurmHealthMetadata
    {
        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The Slurm component that the health information describes. The valid value is <c>Slurmdbd</c>,
        /// the Slurm accounting daemon.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlurmHealthComponent Component { get; set; }

        /// <summary>
        /// Checks to see if the Component property is set.
        /// </summary>
        internal bool IsSetComponent() => this.Component != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the component is unhealthy. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DaemonDown</c>: The daemon is not running, so job accounting records are not being
        /// written.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DaemonDisabled</c>: The daemon is running and its accounting database is responding,
        /// but the daemon is not enabled to start automatically. Job accounting stops the next
        /// time the controller node restarts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DbUnreachable</c>: The daemon is running, but its accounting database did not
        /// respond. Job accounting records might not be written.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This field is omitted when the component is healthy.
        /// </para>
        /// </summary>
        public SlurmHealthReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The health of the component. Valid values are <c>Healthy</c> and <c>Unhealthy</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlurmHealthStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
