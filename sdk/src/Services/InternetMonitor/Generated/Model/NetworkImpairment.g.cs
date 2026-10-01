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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Information about the network impairment for a specific network measured by Amazon
    /// CloudWatch Internet Monitor.
    /// </summary>
    public partial class NetworkImpairment
    {
        /// <summary>
        /// Gets and sets the property AsPath. 
        /// <para>
        /// The combination of the Autonomous System Number (ASN) of the network and the name
        /// of the network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Network> AsPath { get; set; } = AWSConfigs.InitializeCollections ? new List<Network>() : null;

        /// <summary>
        /// Checks to see if the AsPath property is set.
        /// </summary>
        internal bool IsSetAsPath() => this.AsPath != null && (this.AsPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkEventType. 
        /// <para>
        /// The type of network impairment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriangulationEventType NetworkEventType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkEventType property is set.
        /// </summary>
        internal bool IsSetNetworkEventType() => this.NetworkEventType != null;

        /// <summary>
        /// Gets and sets the property Networks. 
        /// <para>
        /// The networks that could be impacted by a network impairment event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Network> Networks { get; set; } = AWSConfigs.InitializeCollections ? new List<Network>() : null;

        /// <summary>
        /// Checks to see if the Networks property is set.
        /// </summary>
        internal bool IsSetNetworks() => this.Networks != null && (this.Networks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
