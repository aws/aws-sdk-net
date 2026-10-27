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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Describes the components of a notification message.
    /// </summary>
    public partial class MessageComponents
    {
        /// <summary>
        /// Gets and sets the property CompleteDescription. 
        /// <para>
        /// A complete summary with all possible relevant information.
        /// </para>
        /// </summary>
        public string CompleteDescription { get; set; }

        /// <summary>
        /// Checks to see if the CompleteDescription property is set.
        /// </summary>
        internal bool IsSetCompleteDescription() => this.CompleteDescription != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A list of properties in key-value pairs. Pairs are shown in order of importance from
        /// most important to least important. Channels may limit the number of dimensions shown
        /// to the notification viewer.
        /// </para>
        ///  <note> 
        /// <para>
        /// Included dimensions, keys, and values are subject to change.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<Dimension> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Headline. 
        /// <para>
        /// A sentence long summary. For example, titles or an email subject line.
        /// </para>
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// Checks to see if the Headline property is set.
        /// </summary>
        internal bool IsSetHeadline() => this.Headline != null;

        /// <summary>
        /// Gets and sets the property MarkupDescription. 
        /// <para>
        /// A rich description in Portable Text format, which you can convert to markup formats
        /// such as HTML, Markdown, or plain text. Channels that don't support rich rendering
        /// ignore this field and use the plain text components instead.
        /// </para>
        /// </summary>
        public string MarkupDescription { get; set; }

        /// <summary>
        /// Checks to see if the MarkupDescription property is set.
        /// </summary>
        internal bool IsSetMarkupDescription() => this.MarkupDescription != null;

        /// <summary>
        /// Gets and sets the property ParagraphSummary. 
        /// <para>
        /// A paragraph long or multiple sentence summary. For example, Amazon Q Developer in
        /// chat applications notifications.
        /// </para>
        /// </summary>
        public string ParagraphSummary { get; set; }

        /// <summary>
        /// Checks to see if the ParagraphSummary property is set.
        /// </summary>
        internal bool IsSetParagraphSummary() => this.ParagraphSummary != null;
    }
}
