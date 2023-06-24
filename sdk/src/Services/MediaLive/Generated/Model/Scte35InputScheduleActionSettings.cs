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
    /// Scte35Input Schedule Action Settings
    /// </summary>
    public partial class Scte35InputScheduleActionSettings
    {
        private string _inputAttachmentNameReference;
        private Scte35InputMode _mode;

        /// <summary>
        /// Gets and sets the property InputAttachmentNameReference. In fixed mode, enter the
        /// name of the input attachment that you want to use as a SCTE-35 input. (Don't enter
        /// the ID of the input.)"
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
        /// Gets and sets the property Mode. Whether the SCTE-35 input should be the active input
        /// or a fixed input.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35InputMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}