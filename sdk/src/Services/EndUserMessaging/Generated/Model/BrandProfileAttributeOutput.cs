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
    /// Contains information about an attribute that was created for a brand profile.
    /// </summary>
    public partial class BrandProfileAttributeOutput
    {
        private string _attributeName;
        private BrandProfileAttributeType _attributeType;
        private string _mediaDownloadUrl;

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

    }
}