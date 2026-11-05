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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about the required target engine settings.
    /// </summary>
    public partial class RecommendationSettings
    {
        /// <summary>
        /// Gets and sets the property InstanceSizingType. 
        /// <para>
        /// The size of your target instance. Fleet Advisor calculates this value based on your
        /// data collection type, such as total capacity and resource utilization. Valid values
        /// include <c>"total-capacity"</c> and <c>"utilization"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceSizingType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceSizingType property is set.
        /// </summary>
        internal bool IsSetInstanceSizingType() => this.InstanceSizingType != null;

        /// <summary>
        /// Gets and sets the property WorkloadType. 
        /// <para>
        /// The deployment option for your target engine. For production databases, Fleet Advisor
        /// chooses Multi-AZ deployment. For development or test databases, Fleet Advisor chooses
        /// Single-AZ deployment. Valid values include <c>"development"</c> and <c>"production"</c>.
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
