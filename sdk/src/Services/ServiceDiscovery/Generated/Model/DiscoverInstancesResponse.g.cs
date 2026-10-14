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

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// This is the response object from the DiscoverInstances operation.
    /// </summary>
    public partial class DiscoverInstancesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// A complex type that contains one <c>HttpInstanceSummary</c> for each registered instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HttpInstanceSummary> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<HttpInstanceSummary>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstancesRevision. 
        /// <para>
        /// The increasing revision associated to the response Instances list. If a new instance
        /// is registered or deregistered, the <c>InstancesRevision</c> updates. The health status
        /// updates don't update <c>InstancesRevision</c>.
        /// </para>
        /// </summary>
        public long? InstancesRevision { get; set; }

        /// <summary>
        /// Checks to see if the InstancesRevision property is set.
        /// </summary>
        internal bool IsSetInstancesRevision() => this.InstancesRevision.HasValue;
    }
}
