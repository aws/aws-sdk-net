/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Message to send
    /// </summary>
    public partial class Message
    {
        private Action _action;
        private string _body;
        private string _imageIconUrl;
        private string _imageSmallIconUrl;
        private string _imageUrl;
        private string _jsonBody;
        private string _mediaUrl;
        private string _rawContent;
        private bool? _silentPush;
        private int? _timeToLive;
        private string _title;
        private string _url;

        /// <summary>
        /// Gets and sets the property Action. The action that occurs if the user taps a push
        /// notification delivered by the campaign:OPEN_APP - Your app launches, or it becomes
        /// the foreground app if it has been sent to the background. This is the default action.DEEP_LINK
        /// - Uses deep linking features in iOS and Android to open your app and display a designated
        /// user interface within the app.URL - The default mobile browser on the user's device
        /// launches and opens a web page at the URL you specify.
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
        /// Gets and sets the property Body. The message body. Can include up to 140 characters.
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
        /// Gets and sets the property ImageIconUrl. The URL that points to the icon image for
        /// the push notification icon, for example, the app icon.
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
        /// Gets and sets the property ImageSmallIconUrl. The URL that points to the small icon
        /// image for the push notification icon, for example, the app icon.
        /// </summary>
        public string ImageSmallIconUrl
        {
            get { return this._imageSmallIconUrl; }
            set { this._imageSmallIconUrl = value; }
        }

        // Check to see if ImageSmallIconUrl property is set
        internal bool IsSetImageSmallIconUrl()
        {
            return this._imageSmallIconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUrl. The URL that points to an image used in the push
        /// notification.
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
        /// Gets and sets the property JsonBody. The JSON payload used for a silent push.
        /// </summary>
        public string JsonBody
        {
            get { return this._jsonBody; }
            set { this._jsonBody = value; }
        }

        // Check to see if JsonBody property is set
        internal bool IsSetJsonBody()
        {
            return this._jsonBody != null;
        }

        /// <summary>
        /// Gets and sets the property MediaUrl. A URL that refers to the location of an image
        /// or video that you want to display in the push notification.
        /// </summary>
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
        /// Gets and sets the property RawContent. The Raw JSON formatted string to be used as
        /// the payload. This value overrides the message.
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
        /// Gets and sets the property SilentPush. Indicates if the message should display on
        /// the users device.Silent pushes can be used for Remote Configuration and Phone Home
        /// use cases.
        /// </summary>
        public bool SilentPush
        {
            get { return this._silentPush.GetValueOrDefault(); }
            set { this._silentPush = value; }
        }

        // Check to see if SilentPush property is set
        internal bool IsSetSilentPush()
        {
            return this._silentPush.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. This parameter specifies how long (in seconds)
        /// the message should be kept if the service is unable to deliver the notification the
        /// first time. If the value is 0, it treats the notification as if it expires immediately
        /// and does not store the notification or attempt to redeliver it. This value is converted
        /// to the expiration field when sent to the service. It only applies to APNs and GCM
        /// </summary>
        public int TimeToLive
        {
            get { return this._timeToLive.GetValueOrDefault(); }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. The message title that displays above the message
        /// on the user's device.
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
        /// Gets and sets the property Url. The URL to open in the user's mobile browser. Used
        /// if the value for Action is URL.
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