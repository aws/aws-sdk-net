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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about the values for reactions to a comment. CodeCommit supports a limited
    /// set of reactions.
    /// </summary>
    public partial class ReactionValueFormats
    {
        /// <summary>
        /// Gets and sets the property Emoji. 
        /// <para>
        /// The Emoji Version 1.0 graphic of the reaction. These graphics are interpreted slightly
        /// differently on different operating systems.
        /// </para>
        /// </summary>
        public string Emoji { get; set; }

        /// <summary>
        /// Checks to see if the Emoji property is set.
        /// </summary>
        internal bool IsSetEmoji() => this.Emoji != null;

        /// <summary>
        /// Gets and sets the property ShortCode. 
        /// <para>
        /// The emoji short code for the reaction. Short codes are interpreted slightly differently
        /// on different operating systems. 
        /// </para>
        /// </summary>
        public string ShortCode { get; set; }

        /// <summary>
        /// Checks to see if the ShortCode property is set.
        /// </summary>
        internal bool IsSetShortCode() => this.ShortCode != null;

        /// <summary>
        /// Gets and sets the property Unicode. 
        /// <para>
        /// The Unicode codepoint for the reaction.
        /// </para>
        /// </summary>
        public string Unicode { get; set; }

        /// <summary>
        /// Checks to see if the Unicode property is set.
        /// </summary>
        internal bool IsSetUnicode() => this.Unicode != null;
    }
}
