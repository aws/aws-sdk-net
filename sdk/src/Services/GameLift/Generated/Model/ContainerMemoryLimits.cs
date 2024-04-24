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
    /// Specifies how much memory is available to a container. You can't change this value
    /// after you create this object. 
    /// 
    ///  
    /// <para>
    ///  <b>Part of: </b> <a>ContainerDefinition$MemoryLimits</a> 
    /// </para>
    /// </summary>
    public partial class ContainerMemoryLimits
    {
        private int? _hardLimit;
        private int? _softLimit;

        /// <summary>
        /// Gets and sets the property HardLimit. 
        /// <para>
        /// The maximum amount of memory that the container can use. If a container attempts to
        /// exceed this limit, the container is stopped. This property is similar to the Amazon
        /// ECS container definition parameter <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#container_definition_memory">memory</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024000)]
        public int HardLimit
        {
            get { return this._hardLimit.GetValueOrDefault(); }
            set { this._hardLimit = value; }
        }

        // Check to see if HardLimit property is set
        internal bool IsSetHardLimit()
        {
            return this._hardLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SoftLimit. 
        /// <para>
        /// The amount of memory that is reserved for a container. When the container group's
        /// shared memory is under contention, the system attempts to maintain the container memory
        /// usage at this soft limit. However, the container can use more memory when needed,
        /// if available. This property is similar to the Amazon ECS container definition parameter
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#ContainerDefinition-memoryReservation">memoryreservation</a>
        /// (<i>Amazon Elastic Container Service Developer Guide</i>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024000)]
        public int SoftLimit
        {
            get { return this._softLimit.GetValueOrDefault(); }
            set { this._softLimit = value; }
        }

        // Check to see if SoftLimit property is set
        internal bool IsSetSoftLimit()
        {
            return this._softLimit.HasValue; 
        }

    }
}