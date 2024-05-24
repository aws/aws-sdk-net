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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
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
namespace Amazon.WorkMailMessageFlow.Model
{
    /// <summary>
    /// Provides the MIME content of the updated email message as an S3 object. All MIME content
    /// must meet the following criteria:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Each part of a multipart MIME message must be formatted properly.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Attachments must be of a content type that Amazon SES supports. For more information,
    /// see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types-appendix.html">Unsupported
    /// Attachment Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If any of the MIME parts in a message contain content that is outside of the 7-bit
    /// ASCII character range, we recommend encoding that content.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Per <a href="https://tools.ietf.org/html/rfc5321#section-4.5.3.1.6">RFC 5321</a>,
    /// the maximum length of each line of text, including the &lt;CRLF&gt;, must not exceed
    /// 1,000 characters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The message must contain all the required header fields. Check the returned error
    /// message for more information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The value of immutable headers must remain unchanged. Check the returned error message
    /// for more information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Certain unique headers can only appear once. Check the returned error message for
    /// more information.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RawMessageContent
    {
        private S3Reference _s3Reference;

        /// <summary>
        /// Gets and sets the property S3Reference. 
        /// <para>
        /// The S3 reference of an email message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Reference S3Reference
        {
            get { return this._s3Reference; }
            set { this._s3Reference = value; }
        }

        // Check to see if S3Reference property is set
        internal bool IsSetS3Reference()
        {
            return this._s3Reference != null;
        }

    }
}