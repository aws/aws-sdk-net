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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private SlurmHealthComponent _component;
        private SlurmHealthReason _reason;
        private SlurmHealthStatus _status;

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The Slurm component that the health information describes. The valid value is <c>Slurmdbd</c>,
        /// the Slurm accounting daemon.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlurmHealthComponent Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

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
        public SlurmHealthReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The health of the component. Valid values are <c>Healthy</c> and <c>Unhealthy</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlurmHealthStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}