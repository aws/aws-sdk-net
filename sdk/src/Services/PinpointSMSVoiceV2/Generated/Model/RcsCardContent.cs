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
    /// The content of a rich card, including title, description, media, and card-level suggested
    /// actions.
    /// </summary>
    public partial class RcsCardContent
    {
        private string _description;
        private RcsCardMedia _media;
        private List<RcsSuggestedAction> _suggestions = AWSConfigs.InitializeCollections ? new List<RcsSuggestedAction>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description text of the card. Maximum 2000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// The media content of the card, including the file URL, optional thumbnail, and display
        /// height.
        /// </para>
        /// </summary>
        public RcsCardMedia Media
        {
            get { return this._media; }
            set { this._media = value; }
        }

        // Check to see if Media property is set
        internal bool IsSetMedia()
        {
            return this._media != null;
        }

        /// <summary>
        /// Gets and sets the property Suggestions. 
        /// <para>
        /// Card-level suggested actions. Maximum 4 suggestions per card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public List<RcsSuggestedAction> Suggestions
        {
            get { return this._suggestions; }
            set { this._suggestions = value; }
        }

        // Check to see if Suggestions property is set
        internal bool IsSetSuggestions()
        {
            return this._suggestions != null && (this._suggestions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the card. Maximum 200 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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