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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// The URL to an external resource.
    /// </summary>
    public partial class RouteWebLink
    {
        private string _anchorText;
        private string _description;
        private RouteWebLinkDeviceType _deviceType;
        private string _url;

        /// <summary>
        /// Gets and sets the property AnchorText. 
        /// <para>
        /// The interactive or clickable portion of the text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AnchorText
        {
            get { return this._anchorText; }
            set { this._anchorText = value; }
        }

        // Check to see if AnchorText property is set
        internal bool IsSetAnchorText()
        {
            return this._anchorText != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Text describing the URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// Device type for which the link is intended.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteWebLinkDeviceType DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}