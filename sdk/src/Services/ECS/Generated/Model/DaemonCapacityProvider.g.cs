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
    /// Information about a capacity provider associated with a daemon revision.
    /// </summary>
    public partial class DaemonCapacityProvider
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of daemon tasks running on this capacity provider.
        /// </para>
        /// </summary>
        public int? RunningCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningCount property is set.
        /// </summary>
        internal bool IsSetRunningCount() => this.RunningCount.HasValue;

        /// <summary>
        /// Gets and sets the property WithoutDaemonCount. 
        /// <para>
        /// The number of instances on this capacity provider that are running without the daemon
        /// task. This applies to daemons that aren't critical, where the instance remains available
        /// for your other tasks even if the daemon task can't start or stops. These instances
        /// aren't included in <c>runningCount</c>.
        /// </para>
        /// </summary>
        public int? WithoutDaemonCount { get; set; }

        /// <summary>
        /// Checks to see if the WithoutDaemonCount property is set.
        /// </summary>
        internal bool IsSetWithoutDaemonCount() => this.WithoutDaemonCount.HasValue;
    }
}
