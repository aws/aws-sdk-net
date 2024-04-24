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
    /// Container for the parameters to the ImportClientBranding operation.
    /// Imports client branding. Client branding allows you to customize your WorkSpace's
    /// client login portal. You can tailor your login portal company logo, the support email
    /// address, support link, link to reset password, and a custom message for users trying
    /// to sign in.
    /// 
    ///  
    /// <para>
    /// After you import client branding, the default branding experience for the specified
    /// platform type is replaced with the imported experience
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must specify at least one platform type when importing client branding.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can import up to 6 MB of data with each request. If your request exceeds this
    /// limit, you can import client branding for different platform types using separate
    /// requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In each platform type, the <c>SupportEmail</c> and <c>SupportLink</c> parameters are
    /// mutually exclusive. You can specify only one parameter for each platform type, but
    /// not both.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Imported data can take up to a minute to appear in the WorkSpaces client.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ImportClientBrandingRequest : AmazonWorkSpacesRequest
    {
        private DefaultImportClientBrandingAttributes _deviceTypeAndroid;
        private IosImportClientBrandingAttributes _deviceTypeIos;
        private DefaultImportClientBrandingAttributes _deviceTypeLinux;
        private DefaultImportClientBrandingAttributes _deviceTypeOsx;
        private DefaultImportClientBrandingAttributes _deviceTypeWeb;
        private DefaultImportClientBrandingAttributes _deviceTypeWindows;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property DeviceTypeAndroid. 
        /// <para>
        /// The branding information to import for Android devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeAndroid
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
        /// The branding information to import for iOS devices.
        /// </para>
        /// </summary>
        public IosImportClientBrandingAttributes DeviceTypeIos
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
        /// The branding information to import for Linux devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeLinux
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
        /// The branding information to import for macOS devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeOsx
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
        /// The branding information to import for web access.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeWeb
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
        /// The branding information to import for Windows devices.
        /// </para>
        /// </summary>
        public DefaultImportClientBrandingAttributes DeviceTypeWindows
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The directory identifier of the WorkSpace for which you want to import client branding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}