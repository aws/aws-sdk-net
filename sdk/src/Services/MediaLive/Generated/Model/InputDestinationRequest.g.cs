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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Endpoint settings for a PUSH type input.
    /// </summary>
    public partial class InputDestinationRequest
    {
        /// <summary>
        /// Gets and sets the property Network. If the push input has an input location of ON-PREM,
        /// ID the ID of the attached network.
        /// </summary>
        public string Network { get; set; }

        /// <summary>
        /// Checks to see if the Network property is set.
        /// </summary>
        internal bool IsSetNetwork() => this.Network != null;

        /// <summary>
        /// Gets and sets the property NetworkRoutes. If the push input has an input location
        /// of ON-PREM it's a requirement to specify what the route of the input is going to be
        /// on the customer local network.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputRequestDestinationRoute> NetworkRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<InputRequestDestinationRoute>() : null;

        /// <summary>
        /// Checks to see if the NetworkRoutes property is set.
        /// </summary>
        internal bool IsSetNetworkRoutes() => this.NetworkRoutes != null && (this.NetworkRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StaticIpAddress. If the push input has an input location
        /// of ON-PREM it's optional to specify what the ip address of the input is going to be
        /// on the customer local network.
        /// </summary>
        public string StaticIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the StaticIpAddress property is set.
        /// </summary>
        internal bool IsSetStaticIpAddress() => this.StaticIpAddress != null;

        /// <summary>
        /// Gets and sets the property StreamName. A unique name for the location the RTMP stream
        /// is being pushed to.
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
