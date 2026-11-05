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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the status of an Amazon Lightsail instance.
    /// </summary>
    public partial class InstanceHealthStatus
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The system instance health or instance health.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceHealthStatusDetail> Details { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceHealthStatusDetail>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        ///  
        /// <para>
        /// The following values are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ok</c> - All checks are passing. The instance is reachable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>impaired</c> - One or more checks have failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>initializing</c> - The instance was recently started, and the checks are in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>insufficient-data</c> - There isn't enough data yet to determine the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>not-applicable</c> - The check doesn't apply because the instance isn't running.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceHealthStatusValue Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
