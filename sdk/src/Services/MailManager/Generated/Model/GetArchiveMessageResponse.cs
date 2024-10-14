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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The response containing details about the requested archived email message.
    /// </summary>
    public partial class GetArchiveMessageResponse : AmazonWebServiceResponse
    {
        private Envelope _envelope;
        private string _messageDownloadLink;
        private Metadata _metadata;

        /// <summary>
        /// Gets and sets the property Envelope. 
        /// <para>
        /// The SMTP envelope information of the email.
        /// </para>
        /// </summary>
        public Envelope Envelope
        {
            get { return this._envelope; }
            set { this._envelope = value; }
        }

        // Check to see if Envelope property is set
        internal bool IsSetEnvelope()
        {
            return this._envelope != null;
        }

        /// <summary>
        /// Gets and sets the property MessageDownloadLink. 
        /// <para>
        /// A pre-signed URL to temporarily download the full message content.
        /// </para>
        /// </summary>
        public string MessageDownloadLink
        {
            get { return this._messageDownloadLink; }
            set { this._messageDownloadLink = value; }
        }

        // Check to see if MessageDownloadLink property is set
        internal bool IsSetMessageDownloadLink()
        {
            return this._messageDownloadLink != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata about the email.
        /// </para>
        /// </summary>
        public Metadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

    }
}