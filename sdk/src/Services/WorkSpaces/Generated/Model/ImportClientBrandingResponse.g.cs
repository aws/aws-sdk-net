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
    /// This is the response object from the ImportClientBranding operation.
    /// </summary>
    public partial class ImportClientBrandingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeviceTypeAndroid. 
        /// <para>
        /// The branding information configured for Android devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeAndroid { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeAndroid property is set.
        /// </summary>
        internal bool IsSetDeviceTypeAndroid() => this.DeviceTypeAndroid != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeIos. 
        /// <para>
        /// The branding information configured for iOS devices.
        /// </para>
        /// </summary>
        public IosClientBrandingAttributes DeviceTypeIos { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeIos property is set.
        /// </summary>
        internal bool IsSetDeviceTypeIos() => this.DeviceTypeIos != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeLinux. 
        /// <para>
        /// The branding information configured for Linux devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeLinux { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeLinux property is set.
        /// </summary>
        internal bool IsSetDeviceTypeLinux() => this.DeviceTypeLinux != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeOsx. 
        /// <para>
        /// The branding information configured for macOS devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeOsx { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeOsx property is set.
        /// </summary>
        internal bool IsSetDeviceTypeOsx() => this.DeviceTypeOsx != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWeb. 
        /// <para>
        /// The branding information configured for web access.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeWeb { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWeb property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWeb() => this.DeviceTypeWeb != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWindows. 
        /// <para>
        /// The branding information configured for Windows devices.
        /// </para>
        /// </summary>
        public DefaultClientBrandingAttributes DeviceTypeWindows { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWindows property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWindows() => this.DeviceTypeWindows != null;
    }
}
