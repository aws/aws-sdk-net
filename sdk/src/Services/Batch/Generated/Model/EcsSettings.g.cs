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
    /// The Amazon ECS settings for a compute environment, including the CloudWatch Container
    /// Insights mode. Use this structure with <c>CreateComputeEnvironment</c> and <c>UpdateComputeEnvironment</c>.
    /// </summary>
    public partial class EcsSettings
    {
        /// <summary>
        /// Gets and sets the property ContainerInsights. 
        /// <para>
        /// Specifies the CloudWatch Container Insights mode for the compute environment. Valid
        /// values are:
        /// </para>
        ///  <dl> <dt>ENABLED</dt> <dd> 
        /// <para>
        /// Turns on standard Container Insights, which collects CPU, memory, disk, and network
        /// utilization metrics for the compute environment.
        /// </para>
        ///  </dd> <dt>ENHANCED</dt> <dd> 
        /// <para>
        /// Turns on enhanced Container Insights, which collects the standard metrics along with
        /// additional per-task observability metrics.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        /// Turns off Container Insights for the compute environment.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// If you don't specify a value, the default is <c>DISABLED</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/cloudwatch-container-insights.html">Container
        /// Insights</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ContainerInsights ContainerInsights { get; set; }

        /// <summary>
        /// Checks to see if the ContainerInsights property is set.
        /// </summary>
        internal bool IsSetContainerInsights() => this.ContainerInsights != null;
    }
}
