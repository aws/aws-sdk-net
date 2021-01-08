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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Action to prepare an input for a future immediate input switch.
    /// </summary>
    public partial class InputPrepareScheduleActionSettings
    {
        private string _inputAttachmentNameReference;
        private InputClippingSettings _inputClippingSettings;
        private List<string> _urlPath = new List<string>();

        /// <summary>
        /// Gets and sets the property InputAttachmentNameReference. The name of the input attachment
        /// that should be prepared by this action. If no name is provided, the action will stop
        /// the most recent prepare (if any) when activated.
        /// </summary>
        public string InputAttachmentNameReference
        {
            get { return this._inputAttachmentNameReference; }
            set { this._inputAttachmentNameReference = value; }
        }

        // Check to see if InputAttachmentNameReference property is set
        internal bool IsSetInputAttachmentNameReference()
        {
            return this._inputAttachmentNameReference != null;
        }

        /// <summary>
        /// Gets and sets the property InputClippingSettings. Settings to let you create a clip
        /// of the file input, in order to set up the input to ingest only a portion of the file.
        /// </summary>
        public InputClippingSettings InputClippingSettings
        {
            get { return this._inputClippingSettings; }
            set { this._inputClippingSettings = value; }
        }

        // Check to see if InputClippingSettings property is set
        internal bool IsSetInputClippingSettings()
        {
            return this._inputClippingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UrlPath. The value for the variable portion of the URL
        /// for the dynamic input, for this instance of the input. Each time you use the same
        /// dynamic input in an input switch action, you can provide a different value, in order
        /// to connect the input to a different content source.
        /// </summary>
        public List<string> UrlPath
        {
            get { return this._urlPath; }
            set { this._urlPath = value; }
        }

        // Check to see if UrlPath property is set
        internal bool IsSetUrlPath()
        {
            return this._urlPath != null && this._urlPath.Count > 0; 
        }

    }
}