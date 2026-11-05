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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Timecode Burnin Settings
    /// </summary>
    public partial class TimecodeBurninSettings
    {
        /// <summary>
        /// Gets and sets the property FontSize. Choose a timecode burn-in font size
        /// </summary>
        [AWSProperty(Required = true)]
        public TimecodeBurninFontSize FontSize { get; set; }

        /// <summary>
        /// Checks to see if the FontSize property is set.
        /// </summary>
        internal bool IsSetFontSize() => this.FontSize != null;

        /// <summary>
        /// Gets and sets the property Position. Choose a timecode burn-in output position
        /// </summary>
        [AWSProperty(Required = true)]
        public TimecodeBurninPosition Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property Prefix. Create a timecode burn-in prefix (optional)
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
