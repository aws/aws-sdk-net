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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that defines the message-level security options that apply to messages that
    /// you send using the configuration set. Currently, these options determine whether Amazon
    /// SES API v2 adds an S/MIME signature to your messages and, if so, the format of that
    /// signature.
    /// </summary>
    public partial class MessageSecurityOptions
    {
        private SigningScheme _signingScheme;

        /// <summary>
        /// Gets and sets the property SigningScheme. 
        /// <para>
        /// The signing scheme that Amazon SES API v2 applies to messages sent with the configuration
        /// set.
        /// </para>
        /// </summary>
        public SigningScheme SigningScheme
        {
            get { return this._signingScheme; }
            set { this._signingScheme = value; }
        }

        // Check to see if SigningScheme property is set
        internal bool IsSetSigningScheme()
        {
            return this._signingScheme != null;
        }

    }
}