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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for using a content delivery network (CDN), like Amazon CloudFront,
    /// for content and ad segment management.
    /// </summary>
    public partial class CdnConfiguration
    {
        private string _adSegmentUrlPrefix;
        private string _contentSegmentUrlPrefix;

        /// <summary>
        /// Gets and sets the property AdSegmentUrlPrefix. 
        /// <para>
        /// A non-default content delivery network (CDN) to serve ad segments. By default, AWS
        /// Elemental MediaTailor uses Amazon CloudFront with default cache settings as its CDN
        /// for ad segments. To set up an alternate CDN, create a rule in your CDN for the origin
        /// ads.mediatailor.<i>&lt;region&gt;</i>.amazonaws.com. Then specify the rule's name
        /// in this <c>AdSegmentUrlPrefix</c>. When AWS Elemental MediaTailor serves a manifest,
        /// it reports your CDN as the source for ad segments.
        /// </para>
        /// </summary>
        public string AdSegmentUrlPrefix
        {
            get { return this._adSegmentUrlPrefix; }
            set { this._adSegmentUrlPrefix = value; }
        }

        // Check to see if AdSegmentUrlPrefix property is set
        internal bool IsSetAdSegmentUrlPrefix()
        {
            return this._adSegmentUrlPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ContentSegmentUrlPrefix. 
        /// <para>
        /// A content delivery network (CDN) to cache content segments, so that content requests
        /// don’t always have to go to the origin server. First, create a rule in your CDN for
        /// the content segment origin server. Then specify the rule's name in this <c>ContentSegmentUrlPrefix</c>.
        /// When AWS Elemental MediaTailor serves a manifest, it reports your CDN as the source
        /// for content segments.
        /// </para>
        /// </summary>
        public string ContentSegmentUrlPrefix
        {
            get { return this._contentSegmentUrlPrefix; }
            set { this._contentSegmentUrlPrefix = value; }
        }

        // Check to see if ContentSegmentUrlPrefix property is set
        internal bool IsSetContentSegmentUrlPrefix()
        {
            return this._contentSegmentUrlPrefix != null;
        }

    }
}