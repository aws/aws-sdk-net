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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The <c>ulimit</c> settings to pass to the container.
    /// 
    ///  
    /// <para>
    /// Amazon ECS tasks hosted on Fargate use the default resource limit values set by the
    /// operating system with the exception of the <c>nofile</c> resource limit parameter
    /// which Fargate overrides. The <c>nofile</c> resource limit sets a restriction on the
    /// number of open files that a container can use. The default <c>nofile</c> soft limit
    /// is <c> 65535</c> and the default hard limit is <c>65535</c>.
    /// </para>
    ///  
    /// <para>
    /// You can specify the <c>ulimit</c> settings for a container in a task definition.
    /// </para>
    /// </summary>
    public partial class Ulimit
    {
        /// <summary>
        /// Gets and sets the property HardLimit. 
        /// <para>
        /// The hard limit for the <c>ulimit</c> type. The value can be specified in bytes, seconds,
        /// or as a count, depending on the <c>type</c> of the <c>ulimit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HardLimit { get; set; }

        /// <summary>
        /// Checks to see if the HardLimit property is set.
        /// </summary>
        internal bool IsSetHardLimit() => this.HardLimit.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The <c>type</c> of the <c>ulimit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UlimitName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SoftLimit. 
        /// <para>
        /// The soft limit for the <c>ulimit</c> type. The value can be specified in bytes, seconds,
        /// or as a count, depending on the <c>type</c> of the <c>ulimit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SoftLimit { get; set; }

        /// <summary>
        /// Checks to see if the SoftLimit property is set.
        /// </summary>
        internal bool IsSetSoftLimit() => this.SoftLimit.HasValue;
    }
}
