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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Options for configuring service software updates for a domain.
    /// </summary>
    public partial class SoftwareUpdateOptions
    {
        /// <summary>
        /// Gets and sets the property AutoSoftwareUpdateEnabled. 
        /// <para>
        /// Whether automatic service software updates are enabled for the domain.
        /// </para>
        /// </summary>
        public bool? AutoSoftwareUpdateEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoSoftwareUpdateEnabled property is set.
        /// </summary>
        internal bool IsSetAutoSoftwareUpdateEnabled() => this.AutoSoftwareUpdateEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property UseLatestServiceSoftwareForBlueGreen. 
        /// <para>
        /// Whether the domain should use the latest service software version during a blue/green
        /// deployment. If enabled, the domain will automatically use the latest available service
        /// software when a blue/green deployment is triggered.
        /// </para>
        /// </summary>
        public bool? UseLatestServiceSoftwareForBlueGreen { get; set; }

        /// <summary>
        /// Checks to see if the UseLatestServiceSoftwareForBlueGreen property is set.
        /// </summary>
        internal bool IsSetUseLatestServiceSoftwareForBlueGreen() => this.UseLatestServiceSoftwareForBlueGreen.HasValue;
    }
}
