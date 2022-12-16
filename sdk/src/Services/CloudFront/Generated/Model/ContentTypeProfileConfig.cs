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
    /// The configuration for a field-level encryption content type-profile mapping.
    /// </summary>
    public partial class ContentTypeProfileConfig
    {
        private ContentTypeProfiles _contentTypeProfiles;
        private bool? _forwardWhenContentTypeIsUnknown;

        /// <summary>
        /// Gets and sets the property ContentTypeProfiles. 
        /// <para>
        /// The configuration for a field-level encryption content type-profile.
        /// </para>
        /// </summary>
        public ContentTypeProfiles ContentTypeProfiles
        {
            get { return this._contentTypeProfiles; }
            set { this._contentTypeProfiles = value; }
        }

        // Check to see if ContentTypeProfiles property is set
        internal bool IsSetContentTypeProfiles()
        {
            return this._contentTypeProfiles != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardWhenContentTypeIsUnknown. 
        /// <para>
        /// The setting in a field-level encryption content type-profile mapping that specifies
        /// what to do when an unknown content type is provided for the profile. If true, content
        /// is forwarded without being encrypted when the content type is unknown. If false (the
        /// default), an error is returned when the content type is unknown.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool ForwardWhenContentTypeIsUnknown
        {
            get { return this._forwardWhenContentTypeIsUnknown.GetValueOrDefault(); }
            set { this._forwardWhenContentTypeIsUnknown = value; }
        }

        // Check to see if ForwardWhenContentTypeIsUnknown property is set
        internal bool IsSetForwardWhenContentTypeIsUnknown()
        {
            return this._forwardWhenContentTypeIsUnknown.HasValue; 
        }

    }
}