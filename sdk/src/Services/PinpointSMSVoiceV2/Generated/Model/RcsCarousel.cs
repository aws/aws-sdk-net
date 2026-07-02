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
    /// A carousel of 2 to 10 scrollable rich cards.
    /// </summary>
    public partial class RcsCarousel
    {
        private List<RcsCarouselCardContent> _cardContents = AWSConfigs.InitializeCollections ? new List<RcsCarouselCardContent>() : null;
        private string _cardWidth;

        /// <summary>
        /// Gets and sets the property CardContents. 
        /// <para>
        /// The list of cards in the carousel. Minimum 2, maximum 10 cards.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=10)]
        public List<RcsCarouselCardContent> CardContents
        {
            get { return this._cardContents; }
            set { this._cardContents = value; }
        }

        // Check to see if CardContents property is set
        internal bool IsSetCardContents()
        {
            return this._cardContents != null && (this._cardContents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CardWidth. 
        /// <para>
        /// The width of cards in the carousel. Valid values are SMALL and MEDIUM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string CardWidth
        {
            get { return this._cardWidth; }
            set { this._cardWidth = value; }
        }

        // Check to see if CardWidth property is set
        internal bool IsSetCardWidth()
        {
            return this._cardWidth != null;
        }

    }
}