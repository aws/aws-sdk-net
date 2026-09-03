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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The <c>ulimit</c> settings to pass to the container. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_Ulimit.html">Ulimit</a>.
    /// 
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Ulimit
    {
        /// <summary>
        /// Gets and sets the property HardLimit. 
        /// <para>
        /// The hard limit for the <c>ulimit</c> type. 
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
        /// The <c>type</c> of the <c>ulimit</c>. Valid values are: <c>core</c> | <c>cpu</c> |
        /// <c>data</c> | <c>fsize</c> | <c>locks</c> | <c>memlock</c> | <c>msgqueue</c> | <c>nice</c>
        /// | <c>nofile</c> | <c>nproc</c> | <c>rss</c> | <c>rtprio</c> | <c>rttime</c> | <c>sigpending</c>
        /// | <c>stack</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SoftLimit. 
        /// <para>
        /// The soft limit for the <c>ulimit</c> type.
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
