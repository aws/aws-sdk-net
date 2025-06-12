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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
        private VehicleAssociationBehavior _associationBehavior;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _decoderManifestArn;
        private string _modelManifestArn;
        private List<StateTemplateAssociation> _stateTemplates = AWSConfigs.InitializeCollections ? new List<StateTemplateAssociation>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vehicleName;

        /// <summary>
        /// Gets and sets the property AssociationBehavior. 
        /// <para>
        /// An option to create a new Amazon Web Services IoT thing when creating a vehicle, or
        /// to validate an existing thing as a vehicle.
        /// </para>
        /// </summary>
        public VehicleAssociationBehavior AssociationBehavior
        {
            get { return this._associationBehavior; }
            set { this._associationBehavior = value; }
        }

        // Check to see if AssociationBehavior property is set
        internal bool IsSetAssociationBehavior()
        {
            return this._associationBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Static information about a vehicle in a key-value pair. For example: <c>"engine Type"</c>
        /// : <c>"v6"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DecoderManifestArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a decoder manifest associated with the vehicle to
        /// create. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DecoderManifestArn
        {
            get { return this._decoderManifestArn; }
            set { this._decoderManifestArn = value; }
        }

        // Check to see if DecoderManifestArn property is set
        internal bool IsSetDecoderManifestArn()
        {
            return this._decoderManifestArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        /// The ARN of the vehicle model (model manifest) to create the vehicle from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelManifestArn
        {
            get { return this._modelManifestArn; }
            set { this._modelManifestArn = value; }
        }

        // Check to see if ModelManifestArn property is set
        internal bool IsSetModelManifestArn()
        {
            return this._modelManifestArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateTemplates. 
        /// <para>
        /// Associate state templates to track the state of the vehicle. State templates determine
        /// which signal updates the vehicle sends to the cloud.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<StateTemplateAssociation> StateTemplates
        {
            get { return this._stateTemplates; }
            set { this._stateTemplates = value; }
        }

        // Check to see if StateTemplates property is set
        internal bool IsSetStateTemplates()
        {
            return this._stateTemplates != null && (this._stateTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VehicleName. 
        /// <para>
        /// The unique ID of the vehicle to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string VehicleName
        {
            get { return this._vehicleName; }
            set { this._vehicleName = value; }
        }

        // Check to see if VehicleName property is set
        internal bool IsSetVehicleName()
        {
            return this._vehicleName != null;
        }

    }
}