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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network Connect attachment.
    /// </summary>
    public partial class ConnectAttachment
    {
        private Attachment _attachment;
        private ConnectAttachmentOptions _options;
        private string _transportAttachmentId;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The attachment details.
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

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Options for connecting an attachment.
        /// </para>
        /// </summary>
        public ConnectAttachmentOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property TransportAttachmentId. 
        /// <para>
        /// The ID of the transport attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string TransportAttachmentId
        {
            get { return this._transportAttachmentId; }
            set { this._transportAttachmentId = value; }
        }

        // Check to see if TransportAttachmentId property is set
        internal bool IsSetTransportAttachmentId()
        {
            return this._transportAttachmentId != null;
        }

    }
}