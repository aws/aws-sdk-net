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
    /// Action to prepare an input for a future immediate input switch.
    /// </summary>
    public partial class InputPrepareScheduleActionSettings
    {
        /// <summary>
        /// Gets and sets the property InputAttachmentNameReference. The name of the input attachment
        /// that should be prepared by this action. If no name is provided, the action will stop
        /// the most recent prepare (if any) when activated.
        /// </summary>
        public string InputAttachmentNameReference { get; set; }

        /// <summary>
        /// Checks to see if the InputAttachmentNameReference property is set.
        /// </summary>
        internal bool IsSetInputAttachmentNameReference() => this.InputAttachmentNameReference != null;

        /// <summary>
        /// Gets and sets the property InputClippingSettings. Settings to let you create a clip
        /// of the file input, in order to set up the input to ingest only a portion of the file.
        /// </summary>
        public InputClippingSettings InputClippingSettings { get; set; }

        /// <summary>
        /// Checks to see if the InputClippingSettings property is set.
        /// </summary>
        internal bool IsSetInputClippingSettings() => this.InputClippingSettings != null;

        /// <summary>
        /// Gets and sets the property UrlPath. The value for the variable portion of the URL
        /// for the dynamic input, for this instance of the input. Each time you use the same
        /// dynamic input in an input switch action, you can provide a different value, in order
        /// to connect the input to a different content source.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UrlPath { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UrlPath property is set.
        /// </summary>
        internal bool IsSetUrlPath() => this.UrlPath != null && (this.UrlPath.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
