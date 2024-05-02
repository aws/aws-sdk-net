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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// A structure that stores metadata for a kdb node.
    /// </summary>
    public partial class KxNode
    {
        private string _availabilityZoneId;
        private DateTime? _launchTime;
        private string _nodeId;
        private KxNodeStatus _status;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The identifier of the availability zones where subnets for the environment are created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=12)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time when a particular node is started. The value is determined as epoch time
        /// in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00 PM UTC
        /// is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// A unique identifier for the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Specifies the status of the cluster nodes. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RUNNING</c> – The node is actively serving.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVISIONING</c> – The node is being prepared.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxNodeStatus Status
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