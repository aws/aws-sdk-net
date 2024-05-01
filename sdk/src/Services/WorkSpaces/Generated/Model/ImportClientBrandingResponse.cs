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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the ImportClientBranding operation.
    /// </summary>
    public partial class ImportClientBrandingResponse : AmazonWebServiceResponse
    {
        private DefaultClientBrandingAttributes _deviceTypeAndroid;
        private IosClientBrandingAttributes _deviceTypeIos;
        private DefaultClientBrandingAttributes _deviceTypeLinux;
        private DefaultClientBrandingAttributes _deviceTypeOsx;
        private DefaultClientBrandingAttributes _deviceTypeWeb;
        private DefaultClientBrandingAttributes _deviceTypeWindows;

        /// <summary>
        /// Gets and sets the property DeviceTypeAndroid. 
        /// <para>
        /// The branding information configured for Android devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeAndroid
        {
            get { return this._deviceTypeAndroid; }
            set { this._deviceTypeAndroid = value; }
        }

        // Check to see if DeviceTypeAndroid property is set
        internal bool IsSetDeviceTypeAndroid()
        {
            return this._deviceTypeAndroid != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeIos. 
        /// <para>
        /// The branding information configured for iOS devices.
        /// </para>
        /// </summary>
        public IosClientBrandingAttributes DeviceTypeIos
        {
            get { return this._deviceTypeIos; }
            set { this._deviceTypeIos = value; }
        }

        // Check to see if DeviceTypeIos property is set
        internal bool IsSetDeviceTypeIos()
        {
            return this._deviceTypeIos != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeLinux. 
        /// <para>
        /// The branding information configured for Linux devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeLinux
        {
            get { return this._deviceTypeLinux; }
            set { this._deviceTypeLinux = value; }
        }

        // Check to see if DeviceTypeLinux property is set
        internal bool IsSetDeviceTypeLinux()
        {
            return this._deviceTypeLinux != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeOsx. 
        /// <para>
        /// The branding information configured for macOS devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeOsx
        {
            get { return this._deviceTypeOsx; }
            set { this._deviceTypeOsx = value; }
        }

        // Check to see if DeviceTypeOsx property is set
        internal bool IsSetDeviceTypeOsx()
        {
            return this._deviceTypeOsx != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeWeb. 
        /// <para>
        /// The branding information configured for web access.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeWeb
        {
            get { return this._deviceTypeWeb; }
            set { this._deviceTypeWeb = value; }
        }

        // Check to see if DeviceTypeWeb property is set
        internal bool IsSetDeviceTypeWeb()
        {
            return this._deviceTypeWeb != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeWindows. 
        /// <para>
        /// The branding information configured for Windows devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeWindows
        {
            get { return this._deviceTypeWindows; }
            set { this._deviceTypeWindows = value; }
        }

        // Check to see if DeviceTypeWindows property is set
        internal bool IsSetDeviceTypeWindows()
        {
            return this._deviceTypeWindows != null;
        }

    }
}