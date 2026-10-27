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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBrandProfileAttribute operation. Updates
    /// the value, description, or category of an existing brand profile attribute.
    /// </summary>
    public partial class UpdateBrandProfileAttributeRequest : AmazonEndUserMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property AttachmentBody. 
        /// <para>
        /// The binary content for an attribute of type IMAGE or DOCUMENT. The content is base64-encoded
        /// when it is sent over the wire.
        /// </para>
        /// </summary>
        public MemoryStream AttachmentBody { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentBody property is set.
        /// </summary>
        internal bool IsSetAttachmentBody() => this.AttachmentBody != null;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the brand profile attribute. The name is unique within a brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The text value of the attribute. This value applies to attributes of type TEXT.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValue property is set.
        /// </summary>
        internal bool IsSetAttributeValue() => this.AttributeValue != null;

        /// <summary>
        /// Gets and sets the property BrandProfileId. 
        /// <para>
        /// The unique identifier of the brand profile. You can specify either the bare ID or
        /// the full Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string BrandProfileId { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileId property is set.
        /// </summary>
        internal bool IsSetBrandProfileId() => this.BrandProfileId != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
