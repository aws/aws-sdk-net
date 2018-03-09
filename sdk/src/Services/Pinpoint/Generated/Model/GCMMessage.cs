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
    /// GCM Message.
    /// </summary>
    public partial class GCMMessage
    {
        private Action _action;
        private string _body;
        private string _collapseKey;
        private Dictionary<string, string> _data = new Dictionary<string, string>();
        private string _iconReference;
        private string _imageIconUrl;
        private string _imageUrl;
        private string _priority;
        private string _rawContent;
        private string _restrictedPackageName;
        private bool? _silentPush;
        private string _smallImageIconUrl;
        private string _sound;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
        private int? _timeToLive;
        private string _title;
        private string _url;

        /// <summary>
        /// Gets and sets the property Action. The action that occurs if the user taps a push
        /// notification delivered by the campaign: OPEN_APP - Your app launches, or it becomes
        /// the foreground app if it has been sent to the background. This is the default action.
        /// DEEP_LINK - Uses deep linking features in iOS and Android to open your app and display
        /// a designated user interface within the app. URL - The default mobile browser on the
        /// user's device launches and opens a web page at the URL you specify. Possible values
        /// include: OPEN_APP | DEEP_LINK | URL
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
        /// Gets and sets the property Body. The message body of the notification, the email body
        /// or the text message.
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
        /// Gets and sets the property CollapseKey. This parameter identifies a group of messages
        /// (e.g., with collapse_key: "Updates Available") that can be collapsed, so that only
        /// the last message gets sent when delivery can be resumed. This is intended to avoid
        /// sending too many of the same messages when the device comes back online or becomes
        /// active.
        /// </summary>
        public string CollapseKey
        {
            get { return this._collapseKey; }
            set { this._collapseKey = value; }
        }

        // Check to see if CollapseKey property is set
        internal bool IsSetCollapseKey()
        {
            return this._collapseKey != null;
        }

        /// <summary>
        /// Gets and sets the property Data. The data payload used for a silent push. This payload
        /// is added to the notifications' data.pinpoint.jsonBody' object
        /// </summary>
        public Dictionary<string, string> Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null && this._data.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IconReference. The icon image name of the asset saved in
        /// your application.
        /// </summary>
        public string IconReference
        {
            get { return this._iconReference; }
            set { this._iconReference = value; }
        }

        // Check to see if IconReference property is set
        internal bool IsSetIconReference()
        {
            return this._iconReference != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIconUrl. The URL that points to an image used as the
        /// large icon to the notification content view.
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
        /// Gets and sets the property Priority. The message priority. Amazon Pinpoint uses this
        /// value to set the FCM or GCM priority parameter when it sends the message. Accepts
        /// the following values:"Normal" - Messages might be delayed. Delivery is optimized for
        /// battery usage on the receiving device. Use normal priority unless immediate delivery
        /// is required."High" - Messages are sent immediately and might wake a sleeping device.The
        /// equivalent values for APNs messages are "5" and "10". Amazon Pinpoint accepts these
        /// values here and converts them.For more information, see About FCM Messages in the
        /// Firebase documentation.
        /// </summary>
        public string Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
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
        /// Gets and sets the property RestrictedPackageName. This parameter specifies the package
        /// name of the application where the registration tokens must match in order to receive
        /// the message.
        /// </summary>
        public string RestrictedPackageName
        {
            get { return this._restrictedPackageName; }
            set { this._restrictedPackageName = value; }
        }

        // Check to see if RestrictedPackageName property is set
        internal bool IsSetRestrictedPackageName()
        {
            return this._restrictedPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property SilentPush. Indicates if the message should display on
        /// the users device. Silent pushes can be used for Remote Configuration and Phone Home
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
        /// Gets and sets the property SmallImageIconUrl. The URL that points to an image used
        /// as the small icon for the notification which will be used to represent the notification
        /// in the status bar and content view
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
        /// Gets and sets the property Sound. Indicates a sound to play when the device receives
        /// the notification. Supports default, or the filename of a sound resource bundled in
        /// the app. Android sound files must reside in /res/raw/
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
        /// Gets and sets the property Substitutions. Default message substitutions. Can be overridden
        /// by individual address substitutions.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && this._substitutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. The length of time (in seconds) that FCM or
        /// GCM stores and attempts to deliver the message. If unspecified, the value defaults
        /// to the maximum, which is 2,419,200 seconds (28 days). Amazon Pinpoint uses this value
        /// to set the FCM or GCM time_to_live parameter.
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