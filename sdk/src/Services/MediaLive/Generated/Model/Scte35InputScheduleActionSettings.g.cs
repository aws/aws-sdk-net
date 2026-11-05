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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Scte35Input Schedule Action Settings
    /// </summary>
    public partial class Scte35InputScheduleActionSettings
    {
        /// <summary>
        /// Gets and sets the property InputAttachmentNameReference. In fixed mode, enter the
        /// name of the input attachment that you want to use as a SCTE-35 input. (Don't enter
        /// the ID of the input.)"
        /// </summary>
        public string InputAttachmentNameReference { get; set; }

        /// <summary>
        /// Checks to see if the InputAttachmentNameReference property is set.
        /// </summary>
        internal bool IsSetInputAttachmentNameReference() => this.InputAttachmentNameReference != null;

        /// <summary>
        /// Gets and sets the property Mode. Whether the SCTE-35 input should be the active input
        /// or a fixed input.
        /// </summary>
        [AWSProperty(Required = true)]
        public Scte35InputMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
