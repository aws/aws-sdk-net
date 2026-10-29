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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// The number and status of game server container groups that are deployed across a container
    /// fleet. Combine this count with the number of server processes that each game server
    /// container group runs to learn how many game sessions the fleet is capable of hosting
    /// concurrently. For example, if a fleet has 50 game server container groups, and the
    /// game server container in each group runs 1 game server process, then the fleet has
    /// the capacity to host 50 game sessions at a time. 
    /// 
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetCapacity.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetCapacity.html</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetLocationCapacity.html</a>
    /// 
    /// </para>
    /// </summary>
    public partial class GameServerContainerGroupCounts
    {
        /// <summary>
        /// Gets and sets the property ACTIVE. 
        /// <para>
        ///  The number of container groups that have active game sessions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ACTIVE { get; set; }

        /// <summary>
        /// Checks to see if the ACTIVE property is set.
        /// </summary>
        internal bool IsSetACTIVE() => this.ACTIVE.HasValue;

        /// <summary>
        /// Gets and sets the property IDLE. 
        /// <para>
        ///  The number of container groups that have no active game sessions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? IDLE { get; set; }

        /// <summary>
        /// Checks to see if the IDLE property is set.
        /// </summary>
        internal bool IsSetIDLE() => this.IDLE.HasValue;

        /// <summary>
        /// Gets and sets the property PENDING. 
        /// <para>
        ///  The number of container groups that are starting up but haven't yet registered. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PENDING { get; set; }

        /// <summary>
        /// Checks to see if the PENDING property is set.
        /// </summary>
        internal bool IsSetPENDING() => this.PENDING.HasValue;

        /// <summary>
        /// Gets and sets the property TERMINATING. 
        /// <para>
        ///  The number of container groups that are in the process of shutting down. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TERMINATING { get; set; }

        /// <summary>
        /// Checks to see if the TERMINATING property is set.
        /// </summary>
        internal bool IsSetTERMINATING() => this.TERMINATING.HasValue;
    }
}
