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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// The device types and operating systems that can be used to access a WorkSpace. For
    /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-network-requirements.html">Amazon
    /// WorkSpaces Client Network Requirements</a>.
    /// </summary>
    public partial class WorkspaceAccessProperties
    {
        /// <summary>
        /// Gets and sets the property AccessEndpointConfig. 
        /// <para>
        /// Specifies the configuration for accessing the WorkSpace.
        /// </para>
        /// </summary>
        public AccessEndpointConfig AccessEndpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the AccessEndpointConfig property is set.
        /// </summary>
        internal bool IsSetAccessEndpointConfig() => this.AccessEndpointConfig != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeAndroid. 
        /// <para>
        /// Indicates whether users can use Android and Android-compatible Chrome OS devices to
        /// access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeAndroid { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeAndroid property is set.
        /// </summary>
        internal bool IsSetDeviceTypeAndroid() => this.DeviceTypeAndroid != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeChromeOs. 
        /// <para>
        /// Indicates whether users can use Chromebooks to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeChromeOs { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeChromeOs property is set.
        /// </summary>
        internal bool IsSetDeviceTypeChromeOs() => this.DeviceTypeChromeOs != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeIos. 
        /// <para>
        /// Indicates whether users can use iOS devices to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeIos { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeIos property is set.
        /// </summary>
        internal bool IsSetDeviceTypeIos() => this.DeviceTypeIos != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeLinux. 
        /// <para>
        /// Indicates whether users can use Linux clients to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeLinux { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeLinux property is set.
        /// </summary>
        internal bool IsSetDeviceTypeLinux() => this.DeviceTypeLinux != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeOsx. 
        /// <para>
        /// Indicates whether users can use macOS clients to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeOsx { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeOsx property is set.
        /// </summary>
        internal bool IsSetDeviceTypeOsx() => this.DeviceTypeOsx != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWeb. 
        /// <para>
        /// Indicates whether users can access their WorkSpaces through a web browser.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeWeb { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWeb property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWeb() => this.DeviceTypeWeb != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWindows. 
        /// <para>
        /// Indicates whether users can use Windows clients to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeWindows { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWindows property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWindows() => this.DeviceTypeWindows != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWorkSpacesThinClient. 
        /// <para>
        /// Indicates whether users can access their WorkSpaces through a WorkSpaces Thin Client.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeWorkSpacesThinClient { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWorkSpacesThinClient property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWorkSpacesThinClient() => this.DeviceTypeWorkSpacesThinClient != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeZeroClient. 
        /// <para>
        /// Indicates whether users can use zero client devices to access their WorkSpaces.
        /// </para>
        /// </summary>
        public AccessPropertyValue DeviceTypeZeroClient { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeZeroClient property is set.
        /// </summary>
        internal bool IsSetDeviceTypeZeroClient() => this.DeviceTypeZeroClient != null;
    }
}
