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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The content and file name of the attachment returned by the <a>DescribeAttachment</a>
    /// operation.
    /// </summary>
    public partial class DescribeAttachmentResponse : AmazonWebServiceResponse
    {
        private Attachment _attachment;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// This object includes the attachment content and file name.
        /// </para>
        ///  
        /// <para>
        /// In the previous response syntax, the value for the <c>data</c> parameter appears as
        /// <c>blob</c>, which is represented as a base64-encoded string. The value for <c>fileName</c>
        /// is the name of the attachment, such as <c>troubleshoot-screenshot.png</c>.
        /// </para>
        /// </summary>
        public Attachment Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

    }
}