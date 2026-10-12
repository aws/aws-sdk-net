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
    /// Information about the vehicle to create.
    /// </summary>
    public partial class CreateVehicleRequestItem
    {
        /// <summary>
        /// Gets and sets the property AssociationBehavior. 
        /// <para>
        /// An option to create a new Amazon Web Services IoT thing when creating a vehicle, or
        /// to validate an existing thing as a vehicle.
        /// </para>
        /// </summary>
        public VehicleAssociationBehavior AssociationBehavior { get; set; }

        /// <summary>
        /// Checks to see if the AssociationBehavior property is set.
        /// </summary>
        internal bool IsSetAssociationBehavior() => this.AssociationBehavior != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Static information about a vehicle in a key-value pair. For example: <c>"engine Type"</c>
        /// : <c>"v6"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DecoderManifestArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a decoder manifest associated with the vehicle to
        /// create. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DecoderManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the DecoderManifestArn property is set.
        /// </summary>
        internal bool IsSetDecoderManifestArn() => this.DecoderManifestArn != null;

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        /// The ARN of the vehicle model (model manifest) to create the vehicle from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelManifestArn property is set.
        /// </summary>
        internal bool IsSetModelManifestArn() => this.ModelManifestArn != null;

        /// <summary>
        /// Gets and sets the property StateTemplates. 
        /// <para>
        /// Associate state templates to track the state of the vehicle. State templates determine
        /// which signal updates the vehicle sends to the cloud.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<StateTemplateAssociation> StateTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<StateTemplateAssociation>() : null;

        /// <summary>
        /// Checks to see if the StateTemplates property is set.
        /// </summary>
        internal bool IsSetStateTemplates() => this.StateTemplates != null && (this.StateTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the vehicle.
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

        /// <summary>
        /// Gets and sets the property VehicleName. 
        /// <para>
        /// The unique ID of the vehicle to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string VehicleName { get; set; }

        /// <summary>
        /// Checks to see if the VehicleName property is set.
        /// </summary>
        internal bool IsSetVehicleName() => this.VehicleName != null;
    }
}
