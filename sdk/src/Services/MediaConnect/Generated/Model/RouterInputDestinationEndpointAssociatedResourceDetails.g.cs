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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The details of the router input that is associated with a destination endpoint.
    /// </summary>
    public partial class RouterInputDestinationEndpointAssociatedResourceDetails
    {
        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate of the router input, in bits per second.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The status messages for the router input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouterInputMessage> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<RouterInputMessage>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterInputState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
