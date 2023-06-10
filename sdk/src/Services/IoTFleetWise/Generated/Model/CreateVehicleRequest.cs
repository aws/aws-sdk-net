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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVehicle operation.
    /// Creates a vehicle, which is an instance of a vehicle model (model manifest). Vehicles
    /// created from the same vehicle model consist of the same signals inherited from the
    /// vehicle model.
    /// 
    ///  <note> 
    /// <para>
    ///  If you have an existing Amazon Web Services IoT thing, you can use Amazon Web Services
    /// IoT FleetWise to create a vehicle and collect data from your thing. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicle-cli.html">Create
    /// a vehicle (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVehicleRequest : AmazonIoTFleetWiseRequest
    {
        private VehicleAssociationBehavior _associationBehavior;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _decoderManifestArn;
        private string _modelManifestArn;
        private List<Tag> _tags = new List<Tag>();
        private string _vehicleName;

        /// <summary>
        /// Gets and sets the property AssociationBehavior. 
        /// <para>
        ///  An option to create a new Amazon Web Services IoT thing when creating a vehicle,
        /// or to validate an existing Amazon Web Services IoT thing as a vehicle. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code/> 
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
        /// Static information about a vehicle in a key-value pair. For example: <code>"engineType"</code>
        /// : <code>"1.3 L R2"</code> 
        /// </para>
        ///  
        /// <para>
        /// A campaign must include the keys (attribute names) in <code>dataExtraDimensions</code>
        /// for them to display in Amazon Timestream.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DecoderManifestArn. 
        /// <para>
        ///  The ARN of a decoder manifest. 
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
        ///  The Amazon Resource Name ARN of a vehicle model. 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the vehicle.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VehicleName. 
        /// <para>
        ///  The unique ID of the vehicle to create. 
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