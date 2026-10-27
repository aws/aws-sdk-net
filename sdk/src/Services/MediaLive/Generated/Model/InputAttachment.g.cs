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
    /// Placeholder documentation for InputAttachment
    /// </summary>
    public partial class InputAttachment
    {
        /// <summary>
        /// Gets and sets the property AutomaticInputFailoverSettings. User-specified settings
        /// for defining what the conditions are for declaring the input unhealthy and failing
        /// over to a different input.
        /// </summary>
        public AutomaticInputFailoverSettings AutomaticInputFailoverSettings { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticInputFailoverSettings property is set.
        /// </summary>
        internal bool IsSetAutomaticInputFailoverSettings() => this.AutomaticInputFailoverSettings != null;

        /// <summary>
        /// Gets and sets the property InputAttachmentName. User-specified name for the attachment.
        /// This is required if the user wants to use this input in an input switch action.
        /// </summary>
        public string InputAttachmentName { get; set; }

        /// <summary>
        /// Checks to see if the InputAttachmentName property is set.
        /// </summary>
        internal bool IsSetInputAttachmentName() => this.InputAttachmentName != null;

        /// <summary>
        /// Gets and sets the property InputId. The ID of the input
        /// </summary>
        public string InputId { get; set; }

        /// <summary>
        /// Checks to see if the InputId property is set.
        /// </summary>
        internal bool IsSetInputId() => this.InputId != null;

        /// <summary>
        /// Gets and sets the property InputSettings. Settings of an input (caption selector,
        /// etc.)
        /// </summary>
        public InputSettings InputSettings { get; set; }

        /// <summary>
        /// Checks to see if the InputSettings property is set.
        /// </summary>
        internal bool IsSetInputSettings() => this.InputSettings != null;

        /// <summary>
        /// Gets and sets the property LogicalInterfaceNames. Optional assignment of an input
        /// to a logical interface on the Node. Only applies to on premises channels.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogicalInterfaceNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogicalInterfaceNames property is set.
        /// </summary>
        internal bool IsSetLogicalInterfaceNames() => this.LogicalInterfaceNames != null && (this.LogicalInterfaceNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
