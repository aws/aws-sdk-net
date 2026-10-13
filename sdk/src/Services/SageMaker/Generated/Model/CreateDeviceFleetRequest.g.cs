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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeviceFleet operation. Creates a device
    /// fleet.
    /// </summary>
    public partial class CreateDeviceFleetRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet that the device belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceFleetName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetName property is set.
        /// </summary>
        internal bool IsSetDeviceFleetName() => this.DeviceFleetName != null;

        /// <summary>
        /// Gets and sets the property EnableIotRoleAlias. 
        /// <para>
        /// Whether to create an Amazon Web Services IoT Role Alias during device fleet creation.
        /// The name of the role alias generated will match this pattern: "SageMakerEdge-{DeviceFleetName}".
        /// </para>
        ///  
        /// <para>
        /// For example, if your device fleet is called "demo-fleet", the name of the role alias
        /// will be "SageMakerEdge-demo-fleet".
        /// </para>
        /// </summary>
        public bool? EnableIotRoleAlias { get; set; }

        /// <summary>
        /// Checks to see if the EnableIotRoleAlias property is set.
        /// </summary>
        internal bool IsSetEnableIotRoleAlias() => this.EnableIotRoleAlias.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for storing sample data collected by the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdgeOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that has access to Amazon Web Services Internet of
        /// Things (IoT).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Creates tags for the specified fleet.
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
