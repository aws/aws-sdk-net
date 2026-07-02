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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
        private RcsCardContent _cardContent;
        private string _cardOrientation;
        private string _thumbnailImageAlignment;

        /// <summary>
        /// Gets and sets the property CardContent. 
        /// <para>
        /// The content of the rich card, including title, description, media, and card-level
        /// suggested actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RcsCardContent CardContent
        {
            get { return this._cardContent; }
            set { this._cardContent = value; }
        }

        // Check to see if CardContent property is set
        internal bool IsSetCardContent()
        {
            return this._cardContent != null;
        }

        /// <summary>
        /// Gets and sets the property CardOrientation. 
        /// <para>
        /// The orientation of the rich card. Valid values are HORIZONTAL and VERTICAL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string CardOrientation
        {
            get { return this._cardOrientation; }
            set { this._cardOrientation = value; }
        }

        // Check to see if CardOrientation property is set
        internal bool IsSetCardOrientation()
        {
            return this._cardOrientation != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailImageAlignment. 
        /// <para>
        /// The alignment of the thumbnail image in a horizontal card. Valid values are LEFT and
        /// RIGHT. Only applicable when CardOrientation is HORIZONTAL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ThumbnailImageAlignment
        {
            get { return this._thumbnailImageAlignment; }
            set { this._thumbnailImageAlignment = value; }
        }

        // Check to see if ThumbnailImageAlignment property is set
        internal bool IsSetThumbnailImageAlignment()
        {
            return this._thumbnailImageAlignment != null;
        }

    }
}