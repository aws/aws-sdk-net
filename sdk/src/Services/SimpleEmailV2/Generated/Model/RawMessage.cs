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
    /// Represents the raw content of an email message.
    /// </summary>
    public partial class RawMessage
    {
        private MemoryStream _data;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The raw email message. The message has to meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message has to contain a header and a body, separated by one blank line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All of the required header fields must be present in the message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each part of a multipart MIME message must be formatted properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attachments must be in a file format that the Amazon SES supports.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The raw data of the message needs to base64-encoded if you are accessing Amazon SES
        /// directly through the HTTPS interface. If you are accessing Amazon SES using an Amazon
        /// Web Services SDK, the SDK takes care of the base 64-encoding for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the MIME parts in your message contain content that is outside of the 7-bit
        /// ASCII character range, you should encode that content to ensure that recipients' email
        /// clients render the message properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The length of any single line of text in the message can't exceed 1,000 characters.
        /// This restriction is defined in <a href="https://tools.ietf.org/html/rfc5321">RFC 5321</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}