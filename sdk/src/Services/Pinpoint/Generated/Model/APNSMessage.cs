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
    /// APNS Message.
    /// </summary>
    public partial class APNSMessage
    {
        private Action _action;
        private int? _badge;
        private string _body;
        private string _category;
        private string _collapseId;
        private Dictionary<string, string> _data = new Dictionary<string, string>();
        private string _mediaUrl;
        private string _preferredAuthenticationMethod;
        private string _priority;
        private string _rawContent;
        private bool? _silentPush;
        private string _sound;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
        private string _threadId;
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
        /// Gets and sets the property Badge. Include this key when you want the system to modify
        /// the badge of your app icon. If this key is not included in the dictionary, the badge
        /// is not changed. To remove the badge, set the value of this key to 0.
        /// </summary>
        public int Badge
        {
            get { return this._badge.GetValueOrDefault(); }
            set { this._badge = value; }
        }

        // Check to see if Badge property is set
        internal bool IsSetBadge()
        {
            return this._badge.HasValue; 
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
        /// Gets and sets the property Category. Provide this key with a string value that represents
        /// the notification's type. This value corresponds to the value in the identifier property
        /// of one of your app's registered categories.
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CollapseId. An ID that, if assigned to multiple messages,
        /// causes APNs to coalesce the messages into a single push notification instead of delivering
        /// each message individually. The value must not exceed 64 bytes. Amazon Pinpoint uses
        /// this value to set the apns-collapse-id request header when it sends the message to
        /// APNs.
        /// </summary>
        public string CollapseId
        {
            get { return this._collapseId; }
            set { this._collapseId = value; }
        }

        // Check to see if CollapseId property is set
        internal bool IsSetCollapseId()
        {
            return this._collapseId != null;
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
        /// Gets and sets the property MediaUrl. The URL that points to a video used in the push
        /// notification.
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
        /// Gets and sets the property PreferredAuthenticationMethod. The preferred authentication
        /// method, either "CERTIFICATE" or "TOKEN"
        /// </summary>
        public string PreferredAuthenticationMethod
        {
            get { return this._preferredAuthenticationMethod; }
            set { this._preferredAuthenticationMethod = value; }
        }

        // Check to see if PreferredAuthenticationMethod property is set
        internal bool IsSetPreferredAuthenticationMethod()
        {
            return this._preferredAuthenticationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. The message priority. Amazon Pinpoint uses this
        /// value to set the apns-priority request header when it sends the message to APNs. Accepts
        /// the following values:"5" - Low priority. Messages might be delayed, delivered in groups,
        /// and throttled."10" - High priority. Messages are sent immediately. High priority messages
        /// must cause an alert, sound, or badge on the receiving device.The default value is
        /// "10".The equivalent values for FCM or GCM messages are "normal" and "high". Amazon
        /// Pinpoint accepts these values for APNs messages and converts them.For more information
        /// about the apns-priority parameter, see Communicating with APNs in the APNs Local and
        /// Remote Notification Programming Guide.
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
        /// Gets and sets the property Sound. Include this key when you want the system to play
        /// a sound. The value of this key is the name of a sound file in your app's main bundle
        /// or in the Library/Sounds folder of your app's data container. If the sound file cannot
        /// be found, or if you specify defaultfor the value, the system plays the default alert
        /// sound.
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
        /// Gets and sets the property ThreadId. Provide this key with a string value that represents
        /// the app-specific identifier for grouping notifications. If you provide a Notification
        /// Content app extension, you can use this value to group your notifications together.
        /// </summary>
        public string ThreadId
        {
            get { return this._threadId; }
            set { this._threadId = value; }
        }

        // Check to see if ThreadId property is set
        internal bool IsSetThreadId()
        {
            return this._threadId != null;
        }

        /// <summary>
        /// Gets and sets the property TimeToLive. The length of time (in seconds) that APNs stores
        /// and attempts to deliver the message. If the value is 0, APNs does not store the message
        /// or attempt to deliver it more than once. Amazon Pinpoint uses this value to set the
        /// apns-expiration request header when it sends the message to APNs.
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