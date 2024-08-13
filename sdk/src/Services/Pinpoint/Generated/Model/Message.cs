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
    /// Specifies the content and settings for a push notification that's sent to recipients
    /// of a campaign.
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
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to occur if a recipient taps the push notification. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background.
        /// This is the default action.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DEEP_LINK - Your app opens and displays a designated user interface in the app. This
        /// setting uses the deep-linking features of iOS and Android.
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
        /// The body of the notification message. The maximum number of characters is 200.
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
        /// The URL of the image to display as the push-notification icon, such as the icon for
        /// the app.
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
        /// Gets and sets the property ImageSmallIconUrl. 
        /// <para>
        /// The URL of the image to display as the small, push-notification icon, such as a small
        /// version of the icon for the app.
        /// </para>
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
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The URL of an image to display in the push notification.
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
        /// Gets and sets the property JsonBody. 
        /// <para>
        /// The JSON payload to use for a silent push notification.
        /// </para>
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
        /// Gets and sets the property MediaUrl. 
        /// <para>
        /// The URL of the image or video to display in the push notification.
        /// </para>
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
        /// Gets and sets the property RawContent. 
        /// <para>
        /// The raw, JSON-formatted string to use as the payload for the notification message.
        /// If specified, this value overrides all other content for the message.
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
        /// Gets and sets the property SilentPush. 
        /// <para>
        /// Specifies whether the notification is a silent push notification, which is a push
        /// notification that doesn't display on a recipient's device. Silent push notifications
        /// can be used for cases such as updating an app's configuration, displaying messages
        /// in an in-app message center, or supporting phone home functionality.
        /// </para>
        /// </summary>
        public bool? SilentPush
        {
            get { return this._silentPush; }
            set { this._silentPush = value; }
        }

        // Check to see if SilentPush property is set
        internal bool IsSetSilentPush()
        {
            return this._silentPush.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. 
        /// <para>
        /// The number of seconds that the push-notification service should keep the message,
        /// if the service is unable to deliver the notification the first time. This value is
        /// converted to an expiration value when it's sent to a push-notification service. If
        /// this value is 0, the service treats the notification as if it expires immediately
        /// and the service doesn't store or try to deliver the notification again.
        /// </para>
        ///  
        /// <para>
        /// This value doesn't apply to messages that are sent through the Amazon Device Messaging
        /// (ADM) service.
        /// </para>
        /// </summary>
        public int? TimeToLive
        {
            get { return this._timeToLive; }
            set { this._timeToLive = value; }
        }

        // Check to see if TimeToLive property is set
        internal bool IsSetTimeToLive()
        {
            return this._timeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to display above the notification message on a recipient's device.
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
        /// The URL to open in a recipient's default mobile browser, if a recipient taps the push
        /// notification and the value of the Action property is URL.
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