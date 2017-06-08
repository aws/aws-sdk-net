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
    /// Default Push Notification Message.
    /// </summary>
    public partial class DefaultPushNotificationMessage
    {
        private Action _action;
        private string _body;
        private Dictionary<string, string> _data = new Dictionary<string, string>();
        private bool? _silentPush;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();
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