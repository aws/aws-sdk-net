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
    /// A standalone rich card with media, title, description, and suggested actions.
    /// </summary>
    public partial class RcsStandaloneCard
    {
        /// <summary>
        /// Gets and sets the property CardContent. 
        /// <para>
        /// The content of the rich card, including title, description, media, and card-level
        /// suggested actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RcsCardContent CardContent { get; set; }

        /// <summary>
        /// Checks to see if the CardContent property is set.
        /// </summary>
        internal bool IsSetCardContent() => this.CardContent != null;

        /// <summary>
        /// Gets and sets the property CardOrientation. 
        /// <para>
        /// The orientation of the rich card. Valid values are HORIZONTAL and VERTICAL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string CardOrientation { get; set; }

        /// <summary>
        /// Checks to see if the CardOrientation property is set.
        /// </summary>
        internal bool IsSetCardOrientation() => this.CardOrientation != null;

        /// <summary>
        /// Gets and sets the property ThumbnailImageAlignment. 
        /// <para>
        /// The alignment of the thumbnail image in a horizontal card. Valid values are LEFT and
        /// RIGHT. Only applicable when CardOrientation is HORIZONTAL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ThumbnailImageAlignment { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailImageAlignment property is set.
        /// </summary>
        internal bool IsSetThumbnailImageAlignment() => this.ThumbnailImageAlignment != null;
    }
}
