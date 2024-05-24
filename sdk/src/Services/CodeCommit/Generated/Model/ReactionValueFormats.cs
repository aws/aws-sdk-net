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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
        private string _emoji;
        private string _shortCode;
        private string _unicode;

        /// <summary>
        /// Gets and sets the property Emoji. 
        /// <para>
        /// The Emoji Version 1.0 graphic of the reaction. These graphics are interpreted slightly
        /// differently on different operating systems.
        /// </para>
        /// </summary>
        public string Emoji
        {
            get { return this._emoji; }
            set { this._emoji = value; }
        }

        // Check to see if Emoji property is set
        internal bool IsSetEmoji()
        {
            return this._emoji != null;
        }

        /// <summary>
        /// Gets and sets the property ShortCode. 
        /// <para>
        /// The emoji short code for the reaction. Short codes are interpreted slightly differently
        /// on different operating systems. 
        /// </para>
        /// </summary>
        public string ShortCode
        {
            get { return this._shortCode; }
            set { this._shortCode = value; }
        }

        // Check to see if ShortCode property is set
        internal bool IsSetShortCode()
        {
            return this._shortCode != null;
        }

        /// <summary>
        /// Gets and sets the property Unicode. 
        /// <para>
        /// The Unicode codepoint for the reaction.
        /// </para>
        /// </summary>
        public string Unicode
        {
            get { return this._unicode; }
            set { this._unicode = value; }
        }

        // Check to see if Unicode property is set
        internal bool IsSetUnicode()
        {
            return this._unicode != null;
        }

    }
}