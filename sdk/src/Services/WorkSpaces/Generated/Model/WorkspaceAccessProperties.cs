/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// The device types and operating systems that can be used to access a WorkSpace. For
    /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-network-requirements.html">Amazon
    /// WorkSpaces Client Network Requirements</a>.
    /// </summary>
    public partial class WorkspaceAccessProperties
    {
        private AccessPropertyValue _deviceTypeAndroid;
        private AccessPropertyValue _deviceTypeChromeOs;
        private AccessPropertyValue _deviceTypeIos;
        private AccessPropertyValue _deviceTypeOsx;
        private AccessPropertyValue _deviceTypeWeb;
        private AccessPropertyValue _deviceTypeWindows;
        private AccessPropertyValue _deviceTypeZeroClient;

        /// <summary>
        /// Gets and sets the property DeviceTypeAndroid. 
        /// <para>
        /// Indicates whether users can use Android devices to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeAndroid
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
        /// Gets and sets the property DeviceTypeChromeOs. 
        /// <para>
        /// Indicates whether users can use Chromebooks to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeChromeOs
        {
            get { return this._deviceTypeChromeOs; }
            set { this._deviceTypeChromeOs = value; }
        }

        // Check to see if DeviceTypeChromeOs property is set
        internal bool IsSetDeviceTypeChromeOs()
        {
            return this._deviceTypeChromeOs != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeIos. 
        /// <para>
        /// Indicates whether users can use iOS devices to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeIos
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
        /// Gets and sets the property DeviceTypeOsx. 
        /// <para>
        /// Indicates whether users can use macOS clients to access their WorkSpaces. To restrict
        /// WorkSpaces access to trusted devices (also known as managed devices) with valid certificates,
        /// specify a value of <code>TRUST</code>. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/trusted-devices.html">Restrict
        /// WorkSpaces Access to Trusted Devices</a>. 
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeOsx
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
        /// Indicates whether users can access their WorkSpaces through a web browser.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeWeb
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
        /// Indicates whether users can use Windows clients to access their WorkSpaces. To restrict
        /// WorkSpaces access to trusted devices (also known as managed devices) with valid certificates,
        /// specify a value of <code>TRUST</code>. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/trusted-devices.html">Restrict
        /// WorkSpaces Access to Trusted Devices</a>. 
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeWindows
        {
            get { return this._deviceTypeWindows; }
            set { this._deviceTypeWindows = value; }
        }

        // Check to see if DeviceTypeWindows property is set
        internal bool IsSetDeviceTypeWindows()
        {
            return this._deviceTypeWindows != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceTypeZeroClient. 
        /// <para>
        /// Indicates whether users can use zero client devices to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeZeroClient
        {
            get { return this._deviceTypeZeroClient; }
            set { this._deviceTypeZeroClient = value; }
        }

        // Check to see if DeviceTypeZeroClient property is set
        internal bool IsSetDeviceTypeZeroClient()
        {
            return this._deviceTypeZeroClient != null;
        }

    }
}