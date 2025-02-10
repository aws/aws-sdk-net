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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// This is the response object from the RenderMessageTemplate operation.
    /// </summary>
    public partial class RenderMessageTemplateResponse : AmazonWebServiceResponse
    {
        private List<MessageTemplateAttachment> _attachments = AWSConfigs.InitializeCollections ? new List<MessageTemplateAttachment>() : null;
        private List<string> _attributesNotInterpolated = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MessageTemplateContentProvider _content;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The message template attachments.
        /// </para>
        /// </summary>
        public List<MessageTemplateAttachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributesNotInterpolated. 
        /// <para>
        /// The attribute keys that are not resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> AttributesNotInterpolated
        {
            get { return this._attributesNotInterpolated; }
            set { this._attributesNotInterpolated = value; }
        }

        // Check to see if AttributesNotInterpolated property is set
        internal bool IsSetAttributesNotInterpolated()
        {
            return this._attributesNotInterpolated != null && (this._attributesNotInterpolated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageTemplateContentProvider Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

    }
}