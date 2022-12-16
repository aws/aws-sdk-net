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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A summary of a field-level encryption item.
    /// </summary>
    public partial class FieldLevelEncryptionSummary
    {
        private string _comment;
        private ContentTypeProfileConfig _contentTypeProfileConfig;
        private string _id;
        private DateTime? _lastModifiedTime;
        private QueryArgProfileConfig _queryArgProfileConfig;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the field-level encryption item. The comment cannot be longer
        /// than 128 characters.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ContentTypeProfileConfig. 
        /// <para>
        /// A summary of a content type-profile mapping.
        /// </para>
        /// </summary>
        public ContentTypeProfileConfig ContentTypeProfileConfig
        {
            get { return this._contentTypeProfileConfig; }
            set { this._contentTypeProfileConfig = value; }
        }

        // Check to see if ContentTypeProfileConfig property is set
        internal bool IsSetContentTypeProfileConfig()
        {
            return this._contentTypeProfileConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of a field-level encryption item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the summary of field-level encryption items was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryArgProfileConfig. 
        /// <para>
        /// A summary of a query argument-profile mapping.
        /// </para>
        /// </summary>
        public QueryArgProfileConfig QueryArgProfileConfig
        {
            get { return this._queryArgProfileConfig; }
            set { this._queryArgProfileConfig = value; }
        }

        // Check to see if QueryArgProfileConfig property is set
        internal bool IsSetQueryArgProfileConfig()
        {
            return this._queryArgProfileConfig != null;
        }

    }
}