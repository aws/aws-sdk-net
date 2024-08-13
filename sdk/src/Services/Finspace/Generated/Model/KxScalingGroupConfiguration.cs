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
    /// The structure that stores the capacity configuration details of a scaling group.
    /// </summary>
    public partial class KxScalingGroupConfiguration
    {
        private double? _cpu;
        private int? _memoryLimit;
        private int? _memoryReservation;
        private int? _nodeCount;
        private string _scalingGroupName;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The number of vCPUs that you want to reserve for each node of this kdb cluster on
        /// the scaling group host. 
        /// </para>
        /// </summary>
        public double? Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryLimit. 
        /// <para>
        ///  An optional hard limit on the amount of memory a kdb cluster can use. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=6)]
        public int? MemoryLimit
        {
            get { return this._memoryLimit; }
            set { this._memoryLimit = value; }
        }

        // Check to see if MemoryLimit property is set
        internal bool IsSetMemoryLimit()
        {
            return this._memoryLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        ///  A reservation of the minimum amount of memory that should be available on the scaling
        /// group for a kdb cluster to be successfully placed in a scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6)]
        public int? MemoryReservation
        {
            get { return this._memoryReservation; }
            set { this._memoryReservation = value; }
        }

        // Check to see if MemoryReservation property is set
        internal bool IsSetMemoryReservation()
        {
            return this._memoryReservation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        ///  The number of kdb cluster nodes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? NodeCount
        {
            get { return this._nodeCount; }
            set { this._nodeCount = value; }
        }

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this._nodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingGroupName. 
        /// <para>
        /// A unique identifier for the kdb scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ScalingGroupName
        {
            get { return this._scalingGroupName; }
            set { this._scalingGroupName = value; }
        }

        // Check to see if ScalingGroupName property is set
        internal bool IsSetScalingGroupName()
        {
            return this._scalingGroupName != null;
        }

    }
}