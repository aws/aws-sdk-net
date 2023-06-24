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
    /// Information about the vehicle to update.
    /// </summary>
    public partial class UpdateVehicleRequestItem
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private UpdateMode _attributeUpdateMode;
        private string _decoderManifestArn;
        private string _modelManifestArn;
        private string _vehicleName;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Static information about a vehicle in a key-value pair. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"engineType"</code> : <code>"1.3 L R2"</code> 
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
        /// Gets and sets the property AttributeUpdateMode. 
        /// <para>
        /// The method the specified attributes will update the existing attributes on the vehicle.
        /// Use<code>Overwite</code> to replace the vehicle attributes with the specified attributes.
        /// Or use <code>Merge</code> to combine all attributes.
        /// </para>
        ///  
        /// <para>
        /// This is required if attributes are present in the input.
        /// </para>
        /// </summary>
        public UpdateMode AttributeUpdateMode
        {
            get { return this._attributeUpdateMode; }
            set { this._attributeUpdateMode = value; }
        }

        // Check to see if AttributeUpdateMode property is set
        internal bool IsSetAttributeUpdateMode()
        {
            return this._attributeUpdateMode != null;
        }

        /// <summary>
        /// Gets and sets the property DecoderManifestArn. 
        /// <para>
        /// The ARN of the signal decoder manifest associated with the vehicle to update.
        /// </para>
        /// </summary>
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
        /// The ARN of the vehicle model (model manifest) associated with the vehicle to update.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VehicleName. 
        /// <para>
        /// The unique ID of the vehicle to update.
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