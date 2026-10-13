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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The target entity to allocate compute resources to.
    /// </summary>
    public partial class ComputeQuotaTarget
    {
        /// <summary>
        /// Gets and sets the property FairShareWeight. 
        /// <para>
        /// Assigned entity fair-share weight. Idle compute will be shared across entities based
        /// on these assigned weights. This weight is only used when <c>FairShare</c> is enabled.
        /// </para>
        ///  
        /// <para>
        /// A weight of 0 is the lowest priority and 100 is the highest. Weight 0 is the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? FairShareWeight { get; set; }

        /// <summary>
        /// Checks to see if the FairShareWeight property is set.
        /// </summary>
        internal bool IsSetFairShareWeight() => this.FairShareWeight.HasValue;

        /// <summary>
        /// Gets and sets the property TeamName. 
        /// <para>
        /// Name of the team to allocate compute resources to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TeamName { get; set; }

        /// <summary>
        /// Checks to see if the TeamName property is set.
        /// </summary>
        internal bool IsSetTeamName() => this.TeamName != null;
    }
}
