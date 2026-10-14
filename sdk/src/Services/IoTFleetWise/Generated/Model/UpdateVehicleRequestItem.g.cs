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
    /// Information about the vehicle to update.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateVehicleRequestItem
    {
        /// <summary>
        /// Gets and sets the property AttributeUpdateMode. 
        /// <para>
        /// The method the specified attributes will update the existing attributes on the vehicle.
        /// Use<c>Overwite</c> to replace the vehicle attributes with the specified attributes.
        /// Or use <c>Merge</c> to combine all attributes.
        /// </para>
        ///  
        /// <para>
        /// This is required if attributes are present in the input.
        /// </para>
        /// </summary>
        public UpdateMode AttributeUpdateMode { get; set; }

        /// <summary>
        /// Checks to see if the AttributeUpdateMode property is set.
        /// </summary>
        internal bool IsSetAttributeUpdateMode() => this.AttributeUpdateMode != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Static information about a vehicle in a key-value pair. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"engineType"</c> : <c>"1.3 L R2"</c> 
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
        /// The ARN of the signal decoder manifest associated with the vehicle to update.
        /// </para>
        /// </summary>
        public string DecoderManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the DecoderManifestArn property is set.
        /// </summary>
        internal bool IsSetDecoderManifestArn() => this.DecoderManifestArn != null;

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        /// The ARN of the vehicle model (model manifest) associated with the vehicle to update.
        /// </para>
        /// </summary>
        public string ModelManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelManifestArn property is set.
        /// </summary>
        internal bool IsSetModelManifestArn() => this.ModelManifestArn != null;

        /// <summary>
        /// Gets and sets the property StateTemplatesToAdd. 
        /// <para>
        /// Associate additional state templates to track the state of the vehicle. State templates
        /// determine which signal updates the vehicle sends to the cloud.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<StateTemplateAssociation> StateTemplatesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<StateTemplateAssociation>() : null;

        /// <summary>
        /// Checks to see if the StateTemplatesToAdd property is set.
        /// </summary>
        internal bool IsSetStateTemplatesToAdd() => this.StateTemplatesToAdd != null && (this.StateTemplatesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StateTemplatesToRemove. 
        /// <para>
        /// Remove existing state template associations from the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> StateTemplatesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StateTemplatesToRemove property is set.
        /// </summary>
        internal bool IsSetStateTemplatesToRemove() => this.StateTemplatesToRemove != null && (this.StateTemplatesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StateTemplatesToUpdate. 
        /// <para>
        /// Change the <c>stateTemplateUpdateStrategy</c> of state templates already associated
        /// with the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<StateTemplateAssociation> StateTemplatesToUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<StateTemplateAssociation>() : null;

        /// <summary>
        /// Checks to see if the StateTemplatesToUpdate property is set.
        /// </summary>
        internal bool IsSetStateTemplatesToUpdate() => this.StateTemplatesToUpdate != null && (this.StateTemplatesToUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VehicleName. 
        /// <para>
        /// The unique ID of the vehicle to update.
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
