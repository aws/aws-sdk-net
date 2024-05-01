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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings to specify the rendering of motion graphics into the video stream.
    /// </summary>
    public partial class MotionGraphicsActivateScheduleActionSettings
    {
        private long? _duration;
        private string _passwordParam;
        private string _url;
        private string _username;

        /// <summary>
        /// Gets and sets the property Duration. Duration (in milliseconds) that motion graphics
        /// should render on to the video stream. Leaving out this property or setting to 0 will
        /// result in rendering continuing until a deactivate action is processed.
        /// </summary>
        [AWSProperty(Min=0, Max=86400000)]
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordParam. Key used to extract the password from EC2
        /// Parameter store
        /// </summary>
        public string PasswordParam
        {
            get { return this._passwordParam; }
            set { this._passwordParam = value; }
        }

        // Check to see if PasswordParam property is set
        internal bool IsSetPasswordParam()
        {
            return this._passwordParam != null;
        }

        /// <summary>
        /// Gets and sets the property Url. URI of the HTML5 content to be rendered into the live
        /// stream.
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

        /// <summary>
        /// Gets and sets the property Username. Documentation update needed
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}