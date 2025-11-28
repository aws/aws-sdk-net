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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The content of the push message template that applies to APNS (Apple Push Notification
    /// service) notification service.
    /// </summary>
    public partial class PushAPNSMessageTemplateContent
    {
        private PushMessageAction _action;
        private MessageTemplateBodyContentProvider _body;
        private string _mediaUrl;
        private MessageTemplateBodyContentProvider _rawContent;
        private string _sound;
        private string _title;
        private string _url;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if a recipient taps a push notification that is based on the message
        /// template. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OPEN_APP</c> - Your app opens or it becomes the foreground app if it was sent
        /// to the background. This is the default action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEEP_LINK</c> - Your app opens and displays a designated user interface in the
        /// app. This action uses the deep-linking features of the iOS platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>URL</c> - The default mobile browser on the recipient's device opens and loads
        /// the web page at a URL that you specify.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PushMessageAction Action
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
        /// The message body to use in a push notification that is based on the message template.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider Body
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
        /// Gets and sets the property MediaUrl. 
        /// <para>
        /// The URL of an image or video to display in push notifications that are based on the
        /// message template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string MediaUrl
        {
            get { return this._mediaUrl; }
            set { this._mediaUrl = value; }
        }

        // Check to see if MediaUrl property is set
        internal bool IsSetMediaUrl()
        {
            return this._mediaUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for a push notification that's
        /// based on the message template. If specified, this value overrides all other content
        /// for the message template.
        /// </para>
        /// </summary>
        public MessageTemplateBodyContentProvider RawContent
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
        /// Gets and sets the property Sound. 
        /// <para>
        /// The key for the sound to play when the recipient receives a push notification that's
        /// based on the message template. The value for this key is the name of a sound file
        /// in your app's main bundle or the <c>Library/Sounds</c> folder in your app's data container.
        /// If the sound file can't be found or you specify <c>default</c> for the value, the
        /// system plays the default alert sound.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
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
        [AWSProperty(Sensitive=true, Min=1)]
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
        /// notification that's based on the message template and the value of the <c>action</c>
        /// property is <c>URL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
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