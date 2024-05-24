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
    /// Specifies channel-specific content and settings for a message template that can be
    /// used in push notifications that are sent through the ADM (Amazon Device Messaging),
    /// Baidu (Baidu Cloud Push), or GCM (Firebase Cloud Messaging, formerly Google Cloud
    /// Messaging) channel.
    /// </summary>
    public partial class AndroidPushNotificationTemplate
    {
        private Action _action;
        private string _body;
        private string _imageIconUrl;
        private string _imageUrl;
        private string _rawContent;
        private string _smallImageIconUrl;
        private string _sound;
        private string _title;
        private string _url;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if a recipient taps a push notification that's based on the message
        /// template. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background.
        /// This is the default action.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DEEP_LINK - Your app opens and displays a designated user interface in the app. This
        /// action uses the deep-linking features of the Android platform.
        /// </para>
        /// </li> <li>
        /// <para>
        /// URL - The default mobile browser on the recipient's device opens and loads the web
        /// page at a URL that you specify.
        /// </para>
        /// </li></ul>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message body to use in a push notification that's based on the message template.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIconUrl. 
        /// <para>
        /// The URL of the large icon image to display in the content view of a push notification
        /// that's based on the message template.
        /// </para>
        /// </summary>
        public string ImageIconUrl
        {
            get { return this._imageIconUrl; }
            set { this._imageIconUrl = value; }
        }

        // Check to see if ImageIconUrl property is set
        internal bool IsSetImageIconUrl()
        {
            return this._imageIconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image to display in a push notification that's based on the message
        /// template.
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
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for a push notification that's
        /// based on the message template. If specified, this value overrides all other content
        /// for the message template.
        /// </para>
        /// </summary>
        public string RawContent
        {
            get { return this._rawContent; }
            set { this._rawContent = value; }
        }

        // Check to see if RawContent property is set
        internal bool IsSetRawContent()
        {
            return this._rawContent != null;
        }

        /// <summary>
        /// Gets and sets the property SmallImageIconUrl. 
        /// <para>
        /// The URL of the small icon image to display in the status bar and the content view
        /// of a push notification that's based on the message template.
        /// </para>
        /// </summary>
        public string SmallImageIconUrl
        {
            get { return this._smallImageIconUrl; }
            set { this._smallImageIconUrl = value; }
        }

        // Check to see if SmallImageIconUrl property is set
        internal bool IsSetSmallImageIconUrl()
        {
            return this._smallImageIconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Sound. 
        /// <para>
        /// The sound to play when a recipient receives a push notification that's based on the
        /// message template. You can use the default stream or specify the file name of a sound
        /// resource that's bundled in your app. On an Android platform, the sound file must reside
        /// in /res/raw/.
        /// </para>
        /// </summary>
        public string Sound
        {
            get { return this._sound; }
            set { this._sound = value; }
        }

        // Check to see if Sound property is set
        internal bool IsSetSound()
        {
            return this._sound != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to use in a push notification that's based on the message template. This
        /// title appears above the notification message on a recipient's device.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to open in a recipient's default mobile browser, if a recipient taps a push
        /// notification that's based on the message template and the value of the Action property
        /// is URL.
        /// </para>
        /// </summary>
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