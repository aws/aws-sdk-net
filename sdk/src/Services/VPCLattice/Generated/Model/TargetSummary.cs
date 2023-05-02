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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Summary information about a target.
    /// </summary>
    public partial class TargetSummary
    {
        private string _id;
        private int? _port;
        private string _reasonCode;
        private TargetStatus _status;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the target. If the target type of the target group is <code>INSTANCE</code>,
        /// this is an instance ID. If the target type is <code>IP</code> , this is an IP address.
        /// If the target type is <code>LAMBDA</code>, this is the ARN of the Lambda function.
        /// If the target type is <code>ALB</code>, this is the ARN of the Application Load Balancer.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the target is listening.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The code for why the target status is what it is.
        /// </para>
        /// </summary>
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the target.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Draining</code>: The target is being deregistered. No new connections will
        /// be sent to this target while current connections are being drained. Default draining
        /// time is 5 minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Unavailable</code>: Health checks are unavailable for the target group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Healthy</code>: The target is healthy. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Unhealthy</code>: The target is unhealthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Initial</code>: Initial health checks on the target are being performed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Unused</code>: Target group is not used in a service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetStatus Status
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