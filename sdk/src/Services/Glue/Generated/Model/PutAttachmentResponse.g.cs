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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The unique identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1087)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AttachmentName. 
        /// <para>
        /// The name of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentName property is set.
        /// </summary>
        internal bool IsSetAttachmentName() => this.AttachmentName != null;

        /// <summary>
        /// Gets and sets the property FormTypeId. 
        /// <para>
        /// The identifier of the form type for this attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FormTypeId { get; set; }

        /// <summary>
        /// Checks to see if the FormTypeId property is set.
        /// </summary>
        internal bool IsSetFormTypeId() => this.FormTypeId != null;

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The identifier of the item within the iterable form, if applicable.
        /// </para>
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Checks to see if the ItemId property is set.
        /// </summary>
        internal bool IsSetItemId() => this.ItemId != null;

        /// <summary>
        /// Gets and sets the property IterableFormName. 
        /// <para>
        /// The name of the iterable form, if the attachment targets an item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string IterableFormName { get; set; }

        /// <summary>
        /// Checks to see if the IterableFormName property is set.
        /// </summary>
        internal bool IsSetIterableFormName() => this.IterableFormName != null;
    }
}
