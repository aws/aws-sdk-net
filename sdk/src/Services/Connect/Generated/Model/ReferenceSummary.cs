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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about a reference. <code>ReferenceSummary</code> contains
    /// only one non null field between the URL and attachment based on the reference type.
    /// </summary>
    public partial class ReferenceSummary
    {
        private AttachmentReference _attachment;
        private UrlReference _url;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// Information about the attachment reference if the <code>referenceType</code> is <code>ATTACHMENT</code>.
        /// Otherwise, null.
        /// </para>
        /// </summary>
        public AttachmentReference Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// Information about the URL reference if the <code>referenceType</code> is <code>URL</code>.
        /// Otherwise, null.
        /// </para>
        /// </summary>
        public UrlReference Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}