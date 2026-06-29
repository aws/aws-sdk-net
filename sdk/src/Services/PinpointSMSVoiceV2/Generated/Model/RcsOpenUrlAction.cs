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
    /// A suggested action that opens a URL in the recipient's browser or an in-app webview.
    /// </summary>
    public partial class RcsOpenUrlAction
    {
        private string _application;
        private string _postbackData;
        private string _text;
        private string _url;
        private string _webviewViewMode;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// How to open the URL. BROWSER opens in the device's default browser. WEBVIEW opens
        /// in an in-app webview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property PostbackData. 
        /// <para>
        /// The postback data sent to your webhook when the user taps this action. Maximum 2048
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PostbackData
        {
            get { return this._postbackData; }
            set { this._postbackData = value; }
        }

        // Check to see if PostbackData property is set
        internal bool IsSetPostbackData()
        {
            return this._postbackData != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The display text of the action. Maximum 25 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to open. Must start with https://. Maximum 2048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property WebviewViewMode. 
        /// <para>
        /// The display mode of the webview. Valid values are FULL, HALF, and TALL. Only applicable
        /// when Application is WEBVIEW.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string WebviewViewMode
        {
            get { return this._webviewViewMode; }
            set { this._webviewViewMode = value; }
        }

        // Check to see if WebviewViewMode property is set
        internal bool IsSetWebviewViewMode()
        {
            return this._webviewViewMode != null;
        }

    }
}