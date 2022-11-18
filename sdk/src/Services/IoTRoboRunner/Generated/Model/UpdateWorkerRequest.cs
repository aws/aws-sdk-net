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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTRoboRunner.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorker operation.
    /// Grants permission to update a worker
    /// </summary>
    public partial class UpdateWorkerRequest : AmazonIoTRoboRunnerRequest
    {
        private string _additionalFixedProperties;
        private string _additionalTransientProperties;
        private string _id;
        private string _name;
        private Orientation _orientation;
        private PositionCoordinates _position;
        private VendorProperties _vendorProperties;

        /// <summary>
        /// Gets and sets the property AdditionalFixedProperties.
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string AdditionalFixedProperties
        {
            get { return this._additionalFixedProperties; }
            set { this._additionalFixedProperties = value; }
        }

        // Check to see if AdditionalFixedProperties property is set
        internal bool IsSetAdditionalFixedProperties()
        {
            return this._additionalFixedProperties != null;
        }

        /// <summary>
        /// Gets and sets the property AdditionalTransientProperties.
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string AdditionalTransientProperties
        {
            get { return this._additionalTransientProperties; }
            set { this._additionalTransientProperties = value; }
        }

        // Check to see if AdditionalTransientProperties property is set
        internal bool IsSetAdditionalTransientProperties()
        {
            return this._additionalTransientProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Orientation.
        /// </summary>
        public Orientation Orientation
        {
            get { return this._orientation; }
            set { this._orientation = value; }
        }

        // Check to see if Orientation property is set
        internal bool IsSetOrientation()
        {
            return this._orientation != null;
        }

        /// <summary>
        /// Gets and sets the property Position.
        /// </summary>
        public PositionCoordinates Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property VendorProperties.
        /// </summary>
        public VendorProperties VendorProperties
        {
            get { return this._vendorProperties; }
            set { this._vendorProperties = value; }
        }

        // Check to see if VendorProperties property is set
        internal bool IsSetVendorProperties()
        {
            return this._vendorProperties != null;
        }

    }
}