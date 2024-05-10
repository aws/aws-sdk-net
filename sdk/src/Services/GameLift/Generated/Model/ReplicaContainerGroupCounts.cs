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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// <b>This data type is used with the Amazon GameLift containers feature, which is currently
    /// in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// The number and status of replica container groups that are deployed across a fleet
    /// with compute type <c>CONTAINER</c>. This information, combined with the number of
    /// server processes being hosted per container group (see <c>RuntimeConfiguration</c>),
    /// tells you how many game sessions the fleet is currently capable of hosting concurrently.
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a>DescribeFleetCapacity</a>, <a>DescribeFleetLocationCapacity</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ReplicaContainerGroupCounts
    {
        private int? _active;
        private int? _idle;
        private int? _pending;
        private int? _terminating;

        /// <summary>
        /// Gets and sets the property ACTIVE. 
        /// <para>
        ///  The number of container groups that have active game sessions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ACTIVE
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if ACTIVE property is set
        internal bool IsSetACTIVE()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IDLE. 
        /// <para>
        ///  The number of container groups that have no active game sessions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? IDLE
        {
            get { return this._idle; }
            set { this._idle = value; }
        }

        // Check to see if IDLE property is set
        internal bool IsSetIDLE()
        {
            return this._idle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PENDING. 
        /// <para>
        ///  The number of container groups that are starting up but have not yet registered.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PENDING
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if PENDING property is set
        internal bool IsSetPENDING()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TERMINATING. 
        /// <para>
        ///  The number of container groups that are in the process of shutting down. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TERMINATING
        {
            get { return this._terminating; }
            set { this._terminating = value; }
        }

        // Check to see if TERMINATING property is set
        internal bool IsSetTERMINATING()
        {
            return this._terminating.HasValue; 
        }

    }
}