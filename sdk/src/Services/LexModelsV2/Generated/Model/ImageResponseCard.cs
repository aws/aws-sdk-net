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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// A card that is shown to the user by a messaging platform. You define the contents
    /// of the card, the card is displayed by the platform. 
    /// 
    ///  
    /// <para>
    /// When you use a response card, the response from the user is constrained to the text
    /// associated with a button on the card.
    /// </para>
    /// </summary>
    public partial class ImageResponseCard
    {
        private List<Button> _buttons = AWSConfigs.InitializeCollections ? new List<Button>() : null;
        private string _imageUrl;
        private string _subtitle;
        private string _title;

        /// <summary>
        /// Gets and sets the property Buttons. 
        /// <para>
        /// A list of buttons that should be displayed on the response card. The arrangement of
        /// the buttons is determined by the platform that displays the button.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Button> Buttons
        {
            get { return this._buttons; }
            set { this._buttons = value; }
        }

        // Check to see if Buttons property is set
        internal bool IsSetButtons()
        {
            return this._buttons != null && (this._buttons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image to display on the response card. The image URL must be publicly
        /// available so that the platform displaying the response card has access to the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string ImageUrl
        {
            get { return this._imageUrl; }
            set { this._imageUrl = value; }
        }

        // Check to see if ImageUrl property is set
        internal bool IsSetImageUrl()
        {
            return this._imageUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Subtitle. 
        /// <para>
        /// The subtitle to display on the response card. The format of the subtitle is determined
        /// by the platform displaying the response card.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Subtitle
        {
            get { return this._subtitle; }
            set { this._subtitle = value; }
        }

        // Check to see if Subtitle property is set
        internal bool IsSetSubtitle()
        {
            return this._subtitle != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to display on the response card. The format of the title is determined by
        /// the platform displaying the response card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}