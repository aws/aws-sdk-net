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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The content of a carousel card, including title, description, media, and card-level
    /// suggested actions. Media height is restricted to SHORT or MEDIUM.
    /// </summary>
    public partial class RcsCarouselCardContent
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description text of the carousel card. Maximum 2000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// The media content of the carousel card. Media height is restricted to SHORT or MEDIUM
        /// (TALL is not supported in carousels).
        /// </para>
        /// </summary>
        public RcsCarouselCardMedia Media { get; set; }

        /// <summary>
        /// Checks to see if the Media property is set.
        /// </summary>
        internal bool IsSetMedia() => this.Media != null;

        /// <summary>
        /// Gets and sets the property Suggestions. 
        /// <para>
        /// Card-level suggested actions for this carousel card. Maximum 4 suggestions per card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 4)]
        public List<RcsSuggestedAction> Suggestions { get; set; } = AWSConfigs.InitializeCollections ? new List<RcsSuggestedAction>() : null;

        /// <summary>
        /// Checks to see if the Suggestions property is set.
        /// </summary>
        internal bool IsSetSuggestions() => this.Suggestions != null && (this.Suggestions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the carousel card. Maximum 200 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
