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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for InputLocation
    /// </summary>
    public partial class InputLocation
    {
        private string _passwordParam;
        private string _uri;
        private string _username;

        /// <summary>
        /// Gets and sets the property PasswordParam. key used to extract the password from EC2
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
        /// Gets and sets the property Uri. Uniform Resource Identifier - This should be a path
        /// to a file accessible to the Live system (eg. a http:// URI) depending on the output
        /// type. For example, a RTMP destination should have a uri simliar to: "rtmp://fmsserver/live".
        /// </summary>
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
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