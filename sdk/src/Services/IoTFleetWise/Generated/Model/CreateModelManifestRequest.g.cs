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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateModelManifest operation. Creates a vehicle
    /// model (model manifest) that specifies signals (attributes, branches, sensors, and
    /// actuators). <para> For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/vehicle-models.html">Vehicle
    /// models</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateModelManifestRequest : AmazonIoTFleetWiseRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the vehicle model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the vehicle model to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        ///  A list of nodes, which are a general abstraction of signals. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 500)]
        public List<string> Nodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Nodes property is set.
        /// </summary>
        internal bool IsSetNodes() => this.Nodes != null && (this.Nodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a signal catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SignalCatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the SignalCatalogArn property is set.
        /// </summary>
        internal bool IsSetSignalCatalogArn() => this.SignalCatalogArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the vehicle model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
