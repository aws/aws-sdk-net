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
    /// Determines whether CloudFront includes the <code>X-Frame-Options</code> HTTP response
    /// header and the header's value.
    /// 
    ///  
    /// <para>
    /// For more information about the <code>X-Frame-Options</code> HTTP response header,
    /// see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options">X-Frame-Options</a>
    /// in the MDN Web Docs.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyFrameOptions
    {
        private FrameOptionsList _frameOption;
        private bool? _override;

        /// <summary>
        /// Gets and sets the property FrameOption. 
        /// <para>
        /// The value of the <code>X-Frame-Options</code> HTTP response header. Valid values are
        /// <code>DENY</code> and <code>SAMEORIGIN</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about these values, see <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options">X-Frame-Options</a>
        /// in the MDN Web Docs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FrameOptionsList FrameOption
        {
            get { return this._frameOption; }
            set { this._frameOption = value; }
        }

        // Check to see if FrameOption property is set
        internal bool IsSetFrameOption()
        {
            return this._frameOption != null;
        }

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides the <code>X-Frame-Options</code>
        /// HTTP response header received from the origin with the one specified in this response
        /// headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Override
        {
            get { return this._override.GetValueOrDefault(); }
            set { this._override = value; }
        }

        // Check to see if Override property is set
        internal bool IsSetOverride()
        {
            return this._override.HasValue; 
        }

    }
}