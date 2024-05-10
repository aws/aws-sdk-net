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
    /// Determines how many replica container groups that Amazon GameLift deploys to each
    /// instance in a container fleet. 
    /// </para>
    ///  
    /// <para>
    /// Amazon GameLift calculates the maximum possible replica groups per instance based
    /// on the instance 's CPU and memory resources. When deploying a fleet, Amazon GameLift
    /// places replica container groups on each fleet instance based on the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If no desired value is set, Amazon GameLift places the calculated maximum. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If a desired number is set to a value higher than the calculated maximum, Amazon GameLift
    /// places the calculated maximum.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If a desired number is set to a value lower than the calculated maximum, Amazon GameLift
    /// places the desired number.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Part of:</b> <a>ContainerGroupsConfiguration</a>, <a>ContainerGroupsAttributes</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a>DescribeFleetAttributes</a>, <a>CreateFleet</a> 
    /// </para>
    /// </summary>
    public partial class ContainerGroupsPerInstance
    {
        private int? _desiredReplicaContainerGroupsPerInstance;
        private int? _maxReplicaContainerGroupsPerInstance;

        /// <summary>
        /// Gets and sets the property DesiredReplicaContainerGroupsPerInstance. 
        /// <para>
        /// The desired number of replica container groups to place on each fleet instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? DesiredReplicaContainerGroupsPerInstance
        {
            get { return this._desiredReplicaContainerGroupsPerInstance; }
            set { this._desiredReplicaContainerGroupsPerInstance = value; }
        }

        // Check to see if DesiredReplicaContainerGroupsPerInstance property is set
        internal bool IsSetDesiredReplicaContainerGroupsPerInstance()
        {
            return this._desiredReplicaContainerGroupsPerInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxReplicaContainerGroupsPerInstance. 
        /// <para>
        /// The maximum possible number of replica container groups that each fleet instance can
        /// have.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? MaxReplicaContainerGroupsPerInstance
        {
            get { return this._maxReplicaContainerGroupsPerInstance; }
            set { this._maxReplicaContainerGroupsPerInstance = value; }
        }

        // Check to see if MaxReplicaContainerGroupsPerInstance property is set
        internal bool IsSetMaxReplicaContainerGroupsPerInstance()
        {
            return this._maxReplicaContainerGroupsPerInstance.HasValue; 
        }

    }
}