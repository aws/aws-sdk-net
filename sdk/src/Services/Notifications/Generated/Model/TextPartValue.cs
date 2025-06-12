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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
    /// Describes text information objects containing fields that determine how text part
    /// objects are composed.
    /// </summary>
    public partial class TextPartValue
    {
        private string _displayText;
        private Dictionary<string, string> _textByLocale = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TextPartType _type;
        private string _url;

        /// <summary>
        /// Gets and sets the property DisplayText. 
        /// <para>
        /// A short single line description of the link. Must be hyper-linked with the URL itself.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Used for text parts with the type <c>URL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DisplayText
        {
            get { return this._displayText; }
            set { this._displayText = value; }
        }

        // Check to see if DisplayText property is set
        internal bool IsSetDisplayText()
        {
            return this._displayText != null;
        }

        /// <summary>
        /// Gets and sets the property TextByLocale. 
        /// <para>
        /// A map of locales to the text in that locale.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TextByLocale
        {
            get { return this._textByLocale; }
            set { this._textByLocale = value; }
        }

        // Check to see if TextByLocale property is set
        internal bool IsSetTextByLocale()
        {
            return this._textByLocale != null && (this._textByLocale.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of text part. Determines the usage of all other fields and whether or not
        /// they're required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TextPartType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL itself.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}