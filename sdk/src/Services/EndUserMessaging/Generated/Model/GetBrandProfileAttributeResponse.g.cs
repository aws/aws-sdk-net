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
    /// This is the response object from the GetBrandProfileAttribute operation.
    /// </summary>
    public partial class GetBrandProfileAttributeResponse : AmazonWebServiceResponse
    {
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
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of the attribute. TEXT stores an inline value. IMAGE and DOCUMENT store binary
        /// media that you upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BrandProfileAttributeType AttributeType { get; set; }

        /// <summary>
        /// Checks to see if the AttributeType property is set.
        /// </summary>
        internal bool IsSetAttributeType() => this.AttributeType != null;

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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the resource was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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

        /// <summary>
        /// Gets and sets the property MediaContentType. 
        /// <para>
        /// The MIME content type of the attribute media.
        /// </para>
        /// </summary>
        public string MediaContentType { get; set; }

        /// <summary>
        /// Checks to see if the MediaContentType property is set.
        /// </summary>
        internal bool IsSetMediaContentType() => this.MediaContentType != null;

        /// <summary>
        /// Gets and sets the property MediaDownloadUrl. 
        /// <para>
        /// A presigned Amazon S3 URL that you can use to download the attribute media. The URL
        /// is valid for one hour and is present only for attributes of type IMAGE or DOCUMENT.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string MediaDownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the MediaDownloadUrl property is set.
        /// </summary>
        internal bool IsSetMediaDownloadUrl() => this.MediaDownloadUrl != null;

        /// <summary>
        /// Gets and sets the property MediaSizeBytes. 
        /// <para>
        /// The size of the attribute media, in bytes.
        /// </para>
        /// </summary>
        public long? MediaSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the MediaSizeBytes property is set.
        /// </summary>
        internal bool IsSetMediaSizeBytes() => this.MediaSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
