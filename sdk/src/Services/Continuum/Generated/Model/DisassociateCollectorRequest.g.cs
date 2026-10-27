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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateCollector operation. Removes one Collector
    /// association from this Environment, preserving its other associations. The stored Collector
    /// data-access role is cleared when no Collector associations remain. The Environment
    /// owner must have permission to disassociate. A current Collector access grant is not
    /// required, and the Collector does not need to remain active or present, so stale or
    /// revoked associations can be cleaned up.
    /// </summary>
    public partial class DisassociateCollectorRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property CollectorArn. The ARN of the Collector to disassociate
        /// from this Environment.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string CollectorArn { get; set; }

        /// <summary>
        /// Checks to see if the CollectorArn property is set.
        /// </summary>
        internal bool IsSetCollectorArn() => this.CollectorArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The unique identifier of the Environment
        /// whose associations are updated.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;
    }
}
