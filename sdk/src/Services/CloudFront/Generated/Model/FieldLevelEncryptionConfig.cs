/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex data type that includes the profile configurations specified for field-level
    /// encryption.
    /// </summary>
    public partial class FieldLevelEncryptionConfig
    {
        private string _callerReference;
        private string _comment;
        private ContentTypeProfileConfig _contentTypeProfileConfig;
        private QueryArgProfileConfig _queryArgProfileConfig;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique number that ensures the request can't be replayed.
        /// </para>
        /// </summary>
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the configuration.
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
        /// A complex data type that specifies when to forward content if a content type isn't
        /// recognized and profiles to use as by default in a request if a query argument doesn't
        /// specify a profile to use.
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
        /// Gets and sets the property QueryArgProfileConfig. 
        /// <para>
        /// A complex data type that specifies when to forward content if a profile isn't found
        /// and the profile that can be provided as a query argument in a request.
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