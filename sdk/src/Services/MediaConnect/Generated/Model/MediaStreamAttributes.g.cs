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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Attributes that are related to the media stream.
    /// </summary>
    public partial class MediaStreamAttributes
    {
        /// <summary>
        /// Gets and sets the property Fmtp. 
        /// <para>
        /// The settings that you want to use to define the media stream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Fmtp Fmtp { get; set; }

        /// <summary>
        /// Checks to see if the Fmtp property is set.
        /// </summary>
        internal bool IsSetFmtp() => this.Fmtp != null;

        /// <summary>
        /// Gets and sets the property Lang. 
        /// <para>
        /// The audio language, in a format that is recognized by the receiver. 
        /// </para>
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// Checks to see if the Lang property is set.
        /// </summary>
        internal bool IsSetLang() => this.Lang != null;
    }
}
