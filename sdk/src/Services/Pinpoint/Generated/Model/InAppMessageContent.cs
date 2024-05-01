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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The configuration for the message content.
    /// </summary>
    public partial class InAppMessageContent
    {
        private string _backgroundColor;
        private InAppMessageBodyConfig _bodyConfig;
        private InAppMessageHeaderConfig _headerConfig;
        private string _imageUrl;
        private InAppMessageButton _primaryBtn;
        private InAppMessageButton _secondaryBtn;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color for the message.
        /// </para>
        /// </summary>
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property BodyConfig. 
        /// <para>
        /// The configuration for the message body.
        /// </para>
        /// </summary>
        public InAppMessageBodyConfig BodyConfig
        {
            get { return this._bodyConfig; }
            set { this._bodyConfig = value; }
        }

        // Check to see if BodyConfig property is set
        internal bool IsSetBodyConfig()
        {
            return this._bodyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderConfig. 
        /// <para>
        /// The configuration for the message header.
        /// </para>
        /// </summary>
        public InAppMessageHeaderConfig HeaderConfig
        {
            get { return this._headerConfig; }
            set { this._headerConfig = value; }
        }

        // Check to see if HeaderConfig property is set
        internal bool IsSetHeaderConfig()
        {
            return this._headerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The image url for the background of message.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PrimaryBtn. 
        /// <para>
        /// The first button inside the message.
        /// </para>
        /// </summary>
        public InAppMessageButton PrimaryBtn
        {
            get { return this._primaryBtn; }
            set { this._primaryBtn = value; }
        }

        // Check to see if PrimaryBtn property is set
        internal bool IsSetPrimaryBtn()
        {
            return this._primaryBtn != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryBtn. 
        /// <para>
        /// The second button inside message.
        /// </para>
        /// </summary>
        public InAppMessageButton SecondaryBtn
        {
            get { return this._secondaryBtn; }
            set { this._secondaryBtn = value; }
        }

        // Check to see if SecondaryBtn property is set
        internal bool IsSetSecondaryBtn()
        {
            return this._secondaryBtn != null;
        }

    }
}