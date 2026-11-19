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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// The kind of a template field, carrying that kind's constraints, placeholder or default.
    /// One discriminator instead of a separate kind enum, constraints blob and preset value,
    /// so kind and constraints cannot disagree. Read-only — templates are AWS-authored; the
    /// service validates each partner value against it. A URL the partner types is not a
    /// distinct kind: it is text with a URL pattern, and its link role is carried by the
    /// layout placeholder. The same holds for a colour, which is text with a hex-colour pattern.
    /// A link to another of the campaign's assets, whose URL DG writes at activation, is
    /// `AssetLink`.
    /// </summary>
    public partial class FieldType
    {
        /// <summary>
        /// Gets and sets the property AssetLink. A link to another asset on the same campaign.
        /// The partner chooses which asset, by `LinkedAssetId`; at activation DG writes that
        /// asset's public URL into the field. A landing page's download button is one, naming
        /// a `DOCUMENT`.
        /// </summary>
        public AssetLinkFieldType AssetLink { get; set; }

        /// <summary>
        /// Checks to see if the AssetLink property is set.
        /// </summary>
        internal bool IsSetAssetLink() => this.AssetLink != null;

        /// <summary>
        /// Gets and sets the property Image. An image field.
        /// </summary>
        public ImageFieldType Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property RichText. A field whose value is a constrained HTML fragment.
        /// </summary>
        public RichTextFieldType RichText { get; set; }

        /// <summary>
        /// Checks to see if the RichText property is set.
        /// </summary>
        internal bool IsSetRichText() => this.RichText != null;

        /// <summary>
        /// Gets and sets the property Text. A plain-text field.
        /// </summary>
        public TextFieldType Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
