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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Represents an option rendered to the user when a prompt is shown. It could be an image,
    /// a button, a link, or text.
    /// </summary>
    public partial class GenericAttachment
    {
        /// <summary>
        /// Gets and sets the property AttachmentLinkUrl. 
        /// <para>
        /// The URL of an attachment to the response card.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AttachmentLinkUrl { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentLinkUrl property is set.
        /// </summary>
        internal bool IsSetAttachmentLinkUrl() => this.AttachmentLinkUrl != null;

        /// <summary>
        /// Gets and sets the property Buttons. 
        /// <para>
        /// The list of options to show to the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Button> Buttons { get; set; } = AWSConfigs.InitializeCollections ? new List<Button>() : null;

        /// <summary>
        /// Checks to see if the Buttons property is set.
        /// </summary>
        internal bool IsSetButtons() => this.Buttons != null && (this.Buttons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image that is displayed to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageUrl property is set.
        /// </summary>
        internal bool IsSetImageUrl() => this.ImageUrl != null;

        /// <summary>
        /// Gets and sets the property SubTitle. 
        /// <para>
        /// The subtitle shown below the title.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string SubTitle { get; set; }

        /// <summary>
        /// Checks to see if the SubTitle property is set.
        /// </summary>
        internal bool IsSetSubTitle() => this.SubTitle != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
