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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// A user settings resource that can be associated with a web portal. Once associated
    /// with a web portal, user settings control how users can transfer data between a streaming
    /// session and the their local devices.
    /// </summary>
    public partial class UserSettings
    {
        private List<string> _associatedPortalArns = new List<string>();
        private EnabledType _copyAllowed;
        private EnabledType _downloadAllowed;
        private EnabledType _pasteAllowed;
        private EnabledType _printAllowed;
        private EnabledType _uploadAllowed;
        private string _userSettingsArn;

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this user settings is associated with.
        /// </para>
        /// </summary>
        public List<string> AssociatedPortalArns
        {
            get { return this._associatedPortalArns; }
            set { this._associatedPortalArns = value; }
        }

        // Check to see if AssociatedPortalArns property is set
        internal bool IsSetAssociatedPortalArns()
        {
            return this._associatedPortalArns != null && this._associatedPortalArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CopyAllowed. 
        /// <para>
        /// Specifies whether the user can copy text from the streaming session to the local device.
        /// </para>
        /// </summary>
        public EnabledType CopyAllowed
        {
            get { return this._copyAllowed; }
            set { this._copyAllowed = value; }
        }

        // Check to see if CopyAllowed property is set
        internal bool IsSetCopyAllowed()
        {
            return this._copyAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property DownloadAllowed. 
        /// <para>
        /// Specifies whether the user can download files from the streaming session to the local
        /// device.
        /// </para>
        /// </summary>
        public EnabledType DownloadAllowed
        {
            get { return this._downloadAllowed; }
            set { this._downloadAllowed = value; }
        }

        // Check to see if DownloadAllowed property is set
        internal bool IsSetDownloadAllowed()
        {
            return this._downloadAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property PasteAllowed. 
        /// <para>
        /// Specifies whether the user can paste text from the local device to the streaming session.
        /// </para>
        /// </summary>
        public EnabledType PasteAllowed
        {
            get { return this._pasteAllowed; }
            set { this._pasteAllowed = value; }
        }

        // Check to see if PasteAllowed property is set
        internal bool IsSetPasteAllowed()
        {
            return this._pasteAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property PrintAllowed. 
        /// <para>
        /// Specifies whether the user can print to the local device.
        /// </para>
        /// </summary>
        public EnabledType PrintAllowed
        {
            get { return this._printAllowed; }
            set { this._printAllowed = value; }
        }

        // Check to see if PrintAllowed property is set
        internal bool IsSetPrintAllowed()
        {
            return this._printAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property UploadAllowed. 
        /// <para>
        /// Specifies whether the user can upload files from the local device to the streaming
        /// session.
        /// </para>
        /// </summary>
        public EnabledType UploadAllowed
        {
            get { return this._uploadAllowed; }
            set { this._uploadAllowed = value; }
        }

        // Check to see if UploadAllowed property is set
        internal bool IsSetUploadAllowed()
        {
            return this._uploadAllowed != null;
        }

        /// <summary>
        /// Gets and sets the property UserSettingsArn. 
        /// <para>
        /// The ARN of the user settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string UserSettingsArn
        {
            get { return this._userSettingsArn; }
            set { this._userSettingsArn = value; }
        }

        // Check to see if UserSettingsArn property is set
        internal bool IsSetUserSettingsArn()
        {
            return this._userSettingsArn != null;
        }

    }
}