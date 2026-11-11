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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Defines the maximum number of contacts an agent can handle simultaneously for a specific
    /// channel and workload type combination.
    /// </summary>
    public partial class WorkloadTypeConcurrency
    {
        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The maximum number of contacts an agent can handle simultaneously for a specific channel
        /// and workload type combination.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>VOICE</c>: Minimum value of 1. Maximum value of 1.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>CHAT</c>: Minimum value of 1. Maximum value of 10.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>TASK</c>: Minimum value of 1. Maximum value of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Checks to see if the Concurrency property is set.
        /// </summary>
        internal bool IsSetConcurrency() => this.Concurrency.HasValue;

        /// <summary>
        /// Gets and sets the property CrossChannelWorkloadBehavior. 
        /// <para>
        /// Defines the cross-channel and workload type routing behavior for each channel and
        /// workload type combination that is enabled for this Routing Profile.
        /// </para>
        /// </summary>
        public CrossChannelWorkloadBehavior CrossChannelWorkloadBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CrossChannelWorkloadBehavior property is set.
        /// </summary>
        internal bool IsSetCrossChannelWorkloadBehavior() => this.CrossChannelWorkloadBehavior != null;

        /// <summary>
        /// Gets and sets the property WorkloadType. 
        /// <para>
        /// The value of the workload type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadType property is set.
        /// </summary>
        internal bool IsSetWorkloadType() => this.WorkloadType != null;
    }
}
