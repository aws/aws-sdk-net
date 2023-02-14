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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDevice operation.
    /// Creates a new device in a global network. If you specify both a site ID and a location,
    /// the location of the site is used for visualization in the Network Manager console.
    /// </summary>
    public partial class CreateDeviceRequest : AmazonNetworkManagerRequest
    {
        private AWSLocation _awsLocation;
        private string _description;
        private string _globalNetworkId;
        private Location _location;
        private string _model;
        private string _serialNumber;
        private string _siteId;
        private List<Tag> _tags = new List<Tag>();
        private string _type;
        private string _vendor;

        /// <summary>
        /// Gets and sets the property AWSLocation. 
        /// <para>
        /// The Amazon Web Services location of the device, if applicable. For an on-premises
        /// device, you can omit this parameter.
        /// </para>
        /// </summary>
        public AWSLocation AWSLocation
        {
            get { return this._awsLocation; }
            set { this._awsLocation = value; }
        }

        // Check to see if AWSLocation property is set
        internal bool IsSetAWSLocation()
        {
            return this._awsLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SiteId. 
        /// <para>
        /// The ID of the site.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string SiteId
        {
            get { return this._siteId; }
            set { this._siteId = value; }
        }

        // Check to see if SiteId property is set
        internal bool IsSetSiteId()
        {
            return this._siteId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the resource during creation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The vendor of the device.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Vendor
        {
            get { return this._vendor; }
            set { this._vendor = value; }
        }

        // Check to see if Vendor property is set
        internal bool IsSetVendor()
        {
            return this._vendor != null;
        }

    }
}