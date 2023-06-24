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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Timecode Burnin Settings
    /// </summary>
    public partial class TimecodeBurninSettings
    {
        private TimecodeBurninFontSize _fontSize;
        private TimecodeBurninPosition _position;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property FontSize. Choose a timecode burn-in font size
        /// </summary>
        [AWSProperty(Required=true)]
        public TimecodeBurninFontSize FontSize
        {
            get { return this._fontSize; }
            set { this._fontSize = value; }
        }

        // Check to see if FontSize property is set
        internal bool IsSetFontSize()
        {
            return this._fontSize != null;
        }

        /// <summary>
        /// Gets and sets the property Position. Choose a timecode burn-in output position
        /// </summary>
        [AWSProperty(Required=true)]
        public TimecodeBurninPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. Create a timecode burn-in prefix (optional)
        /// </summary>
        [AWSProperty(Max=255)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}