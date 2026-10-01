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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataflowEndpointGroupV2 operation. Creates
    /// a <c>DataflowEndpoint</c> group containing the specified list of Ground Station Agent
    /// based endpoints. <para> The <c>name</c> field in each endpoint is used in your mission
    /// profile <c> DataflowEndpointConfig</c> to specify which endpoints to use during a
    /// contact. </para> <para> When a contact uses multiple <c>DataflowEndpointConfig</c>
    /// objects, each <c> Config</c> must match a <c>DataflowEndpoint</c> in the same group.
    /// </para>
    /// </summary>
    public partial class CreateDataflowEndpointGroupV2Request : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property ContactPostPassDurationSeconds. 
        /// <para>
        ///  Amount of time, in seconds, after a contact ends that the Ground Station Dataflow
        /// Endpoint Group will be in a <c>POSTPASS</c> state. A <a href="https://docs.aws.amazon.com/ground-station/latest/ug/monitoring.automating-events.html">Ground
        /// Station Dataflow Endpoint Group State Change event</a> will be emitted when the Dataflow
        /// Endpoint Group enters and exits the <c>POSTPASS</c> state. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 480)]
        public int? ContactPostPassDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ContactPostPassDurationSeconds property is set.
        /// </summary>
        internal bool IsSetContactPostPassDurationSeconds() => this.ContactPostPassDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ContactPrePassDurationSeconds. 
        /// <para>
        ///  Amount of time, in seconds, before a contact starts that the Ground Station Dataflow
        /// Endpoint Group will be in a <c>PREPASS</c> state. A <a href="https://docs.aws.amazon.com/ground-station/latest/ug/monitoring.automating-events.html">Ground
        /// Station Dataflow Endpoint Group State Change event</a> will be emitted when the Dataflow
        /// Endpoint Group enters and exits the <c>PREPASS</c> state. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 480)]
        public int? ContactPrePassDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ContactPrePassDurationSeconds property is set.
        /// </summary>
        internal bool IsSetContactPrePassDurationSeconds() => this.ContactPrePassDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// Dataflow endpoint group's endpoint definitions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 12)]
        public List<CreateEndpointDetails> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateEndpointDetails>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags of a V2 dataflow endpoint group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
