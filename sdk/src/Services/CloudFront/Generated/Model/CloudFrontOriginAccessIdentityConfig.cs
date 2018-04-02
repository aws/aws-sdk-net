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
    /// Origin access identity configuration. Send a <code>GET</code> request to the <code>/<i>CloudFront
    /// API version</i>/CloudFront/identity ID/config</code> resource.
    /// </summary>
    public partial class CloudFrontOriginAccessIdentityConfig
    {
        private string _callerReference;
        private string _comment;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig() { }

        /// <summary>
        /// Instantiates CloudFrontOriginAccessIdentityConfig with the parameterized properties
        /// </summary>
        /// <param name="callerReference">A unique number that ensures the request can't be replayed. If the <code>CallerReference</code> is new (no matter the content of the <code>CloudFrontOriginAccessIdentityConfig</code> object), a new origin access identity is created. If the <code>CallerReference</code> is a value already sent in a previous identity request, and the content of the <code>CloudFrontOriginAccessIdentityConfig</code> is identical to the original request (ignoring white space), the response includes the same information returned to the original request.  If the <code>CallerReference</code> is a value you already sent in a previous request to create an identity, but the content of the <code>CloudFrontOriginAccessIdentityConfig</code> is different from the original request, CloudFront returns a <code>CloudFrontOriginAccessIdentityAlreadyExists</code> error. </param>
        public CloudFrontOriginAccessIdentityConfig(string callerReference)
        {
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique number that ensures the request can't be replayed.
        /// </para>
        ///  
        /// <para>
        /// If the <code>CallerReference</code> is new (no matter the content of the <code>CloudFrontOriginAccessIdentityConfig</code>
        /// object), a new origin access identity is created.
        /// </para>
        ///  
        /// <para>
        /// If the <code>CallerReference</code> is a value already sent in a previous identity
        /// request, and the content of the <code>CloudFrontOriginAccessIdentityConfig</code>
        /// is identical to the original request (ignoring white space), the response includes
        /// the same information returned to the original request. 
        /// </para>
        ///  
        /// <para>
        /// If the <code>CallerReference</code> is a value you already sent in a previous request
        /// to create an identity, but the content of the <code>CloudFrontOriginAccessIdentityConfig</code>
        /// is different from the original request, CloudFront returns a <code>CloudFrontOriginAccessIdentityAlreadyExists</code>
        /// error. 
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
        /// Any comments you want to include about the origin access identity. 
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

    }
}