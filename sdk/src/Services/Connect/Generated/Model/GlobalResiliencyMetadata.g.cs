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
    /// Information about the global resiliency configuration for the contact, including traffic
    /// distribution details.
    /// </summary>
    public partial class GlobalResiliencyMetadata
    {
        /// <summary>
        /// Gets and sets the property ActiveRegion. 
        /// <para>
        /// The current AWS region in which the contact is active. This indicates where the contact
        /// is being processed in real-time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ActiveRegion { get; set; }

        /// <summary>
        /// Checks to see if the ActiveRegion property is set.
        /// </summary>
        internal bool IsSetActiveRegion() => this.ActiveRegion != null;

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// The AWS region where the contact was originally created and initiated. This may differ
        /// from the ActiveRegion if the contact has been transferred across regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OriginRegion { get; set; }

        /// <summary>
        /// Checks to see if the OriginRegion property is set.
        /// </summary>
        internal bool IsSetOriginRegion() => this.OriginRegion != null;

        /// <summary>
        /// Gets and sets the property TrafficDistributionGroupId. 
        /// <para>
        /// The identifier of the traffic distribution group.
        /// </para>
        /// </summary>
        public string TrafficDistributionGroupId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficDistributionGroupId property is set.
        /// </summary>
        internal bool IsSetTrafficDistributionGroupId() => this.TrafficDistributionGroupId != null;
    }
}
