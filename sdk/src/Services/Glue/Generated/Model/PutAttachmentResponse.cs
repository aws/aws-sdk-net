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
    /// This is the response object from the PutAttachment operation.
    /// </summary>
    public partial class PutAttachmentResponse : AmazonWebServiceResponse
    {
        private string _assetIdentifier;
        private string _attachmentName;
        private string _formTypeId;
        private string _itemIdentifier;
        private string _iterableFormName;

        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The unique identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1087)]
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
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property FormTypeId. 
        /// <para>
        /// The identifier of the form type for this attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The identifier of the item within the iterable form, if applicable.
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
        /// The name of the iterable form, if the attachment targets an item.
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