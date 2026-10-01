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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
        private string _attributeName;
        private BrandProfileAttributeType _attributeType;
        private string _attributeValue;
        private string _category;
        private DateTime? _createdAt;
        private string _description;
        private string _mediaContentType;
        private string _mediaDownloadUrl;
        private long? _mediaSizeBytes;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the brand profile attribute. The name is unique within a brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of the attribute. TEXT stores an inline value. IMAGE and DOCUMENT store binary
        /// media that you upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BrandProfileAttributeType AttributeType
        {
            get { return this._attributeType; }
            set { this._attributeType = value; }
        }

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this._attributeType != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The text value of the attribute. This value applies to attributes of type TEXT.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the resource was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MediaContentType. 
        /// <para>
        /// The MIME content type of the attribute media.
        /// </para>
        /// </summary>
        public string MediaContentType
        {
            get { return this._mediaContentType; }
            set { this._mediaContentType = value; }
        }

        // Check to see if MediaContentType property is set
        internal bool IsSetMediaContentType()
        {
            return this._mediaContentType != null;
        }

        /// <summary>
        /// Gets and sets the property MediaDownloadUrl. 
        /// <para>
        /// A presigned Amazon S3 URL that you can use to download the attribute media. The URL
        /// is valid for one hour and is present only for attributes of type IMAGE or DOCUMENT.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string MediaDownloadUrl
        {
            get { return this._mediaDownloadUrl; }
            set { this._mediaDownloadUrl = value; }
        }

        // Check to see if MediaDownloadUrl property is set
        internal bool IsSetMediaDownloadUrl()
        {
            return this._mediaDownloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSizeBytes. 
        /// <para>
        /// The size of the attribute media, in bytes.
        /// </para>
        /// </summary>
        public long? MediaSizeBytes
        {
            get { return this._mediaSizeBytes; }
            set { this._mediaSizeBytes = value; }
        }

        // Check to see if MediaSizeBytes property is set
        internal bool IsSetMediaSizeBytes()
        {
            return this._mediaSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}