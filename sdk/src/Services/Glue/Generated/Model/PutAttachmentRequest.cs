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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the PutAttachment operation.
    /// Attaches a form to an asset or an iterable form item in Glue Data Catalog. If an attachment
    /// with the same name already exists, it is overwritten.
    /// </summary>
    public partial class PutAttachmentRequest : AmazonGlueRequest
    {
        private string _assetIdentifier;
        private string _attachmentName;
        private string _clientToken;
        private string _content;
        private string _formTypeId;
        private string _itemIdentifier;
        private string _iterableFormName;

        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The unique identifier of the asset to attach the form to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1087)]
        public string AssetIdentifier
        {
            get { return this._assetIdentifier; }
            set { this._assetIdentifier = value; }
        }

        // Check to see if AssetIdentifier property is set
        internal bool IsSetAssetIdentifier()
        {
            return this._assetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentName. 
        /// <para>
        /// The name of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AttachmentName
        {
            get { return this._attachmentName; }
            set { this._attachmentName = value; }
        }

        // Check to see if AttachmentName property is set
        internal bool IsSetAttachmentName()
        {
            return this._attachmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The JSON content of the form, conforming to the schema of the specified form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=300000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property FormTypeId. 
        /// <para>
        /// The identifier of the form type for this attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FormTypeId
        {
            get { return this._formTypeId; }
            set { this._formTypeId = value; }
        }

        // Check to see if FormTypeId property is set
        internal bool IsSetFormTypeId()
        {
            return this._formTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ItemIdentifier. 
        /// <para>
        /// The identifier of the item within the iterable form. Required when <c>iterableFormName</c>
        /// is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1087)]
        public string ItemIdentifier
        {
            get { return this._itemIdentifier; }
            set { this._itemIdentifier = value; }
        }

        // Check to see if ItemIdentifier property is set
        internal bool IsSetItemIdentifier()
        {
            return this._itemIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IterableFormName. 
        /// <para>
        /// The name of the iterable form. When specified along with <c>itemIdentifier</c>, the
        /// attachment targets an item within the iterable form rather than the asset itself.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string IterableFormName
        {
            get { return this._iterableFormName; }
            set { this._iterableFormName = value; }
        }

        // Check to see if IterableFormName property is set
        internal bool IsSetIterableFormName()
        {
            return this._iterableFormName != null;
        }

    }
}