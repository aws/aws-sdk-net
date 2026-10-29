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
    /// Container for the parameters to the ImportClientBranding operation. Imports client
    /// branding. Client branding allows you to customize your WorkSpace's client login portal.
    /// You can tailor your login portal company logo, the support email address, support
    /// link, link to reset password, and a custom message for users trying to sign in. <para>
    /// After you import client branding, the default branding experience for the specified
    /// platform type is replaced with the imported experience </para> <note> <ul> <li> <para>
    /// You must specify at least one platform type when importing client branding. </para>
    /// </li> <li> <para> You can import up to 6 MB of data with each request. If your request
    /// exceeds this limit, you can import client branding for different platform types using
    /// separate requests. </para> </li> <li> <para> In each platform type, the <c>SupportEmail</c>
    /// and <c>SupportLink</c> parameters are mutually exclusive. You can specify only one
    /// parameter for each platform type, but not both. </para> </li> <li> <para> Imported
    /// data can take up to a minute to appear in the WorkSpaces client. </para> </li> </ul>
    /// </note>
    /// </summary>
    public partial class ImportClientBrandingRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property DeviceTypeAndroid. 
        /// <para>
        /// The branding information to import for Android devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeAndroid { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeAndroid property is set.
        /// </summary>
        internal bool IsSetDeviceTypeAndroid() => this.DeviceTypeAndroid != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeIos. 
        /// <para>
        /// The branding information to import for iOS devices.
        /// </para>
        /// </summary>
        public IosImportClientBrandingAttributes DeviceTypeIos { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeIos property is set.
        /// </summary>
        internal bool IsSetDeviceTypeIos() => this.DeviceTypeIos != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeLinux. 
        /// <para>
        /// The branding information to import for Linux devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeLinux { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeLinux property is set.
        /// </summary>
        internal bool IsSetDeviceTypeLinux() => this.DeviceTypeLinux != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeOsx. 
        /// <para>
        /// The branding information to import for macOS devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeOsx { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeOsx property is set.
        /// </summary>
        internal bool IsSetDeviceTypeOsx() => this.DeviceTypeOsx != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWeb. 
        /// <para>
        /// The branding information to import for web access.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeWeb { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWeb property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWeb() => this.DeviceTypeWeb != null;

        /// <summary>
        /// Gets and sets the property DeviceTypeWindows. 
        /// <para>
        /// The branding information to import for Windows devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeWindows { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTypeWindows property is set.
        /// </summary>
        internal bool IsSetDeviceTypeWindows() => this.DeviceTypeWindows != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The directory identifier of the WorkSpace for which you want to import client branding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 65)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
