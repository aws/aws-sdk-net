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
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
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
    /// An invalidation batch.
    /// </summary>
    public partial class InvalidationBatch
    {
        private string _callerReference;
        private Paths _paths;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InvalidationBatch() { }

        /// <summary>
        /// Instantiates InvalidationBatch with the parameterized properties
        /// </summary>
        /// <param name="paths">The path of the object to invalidate. The path is relative to the distribution and must begin with a slash (/). You must enclose each invalidation object with the Path element tags. If the path includes non-ASCII characters or unsafe characters as defined in RFC 1783 (http://www.ietf.org/rfc/rfc1738.txt), URL encode those characters. Do not URL encode any other characters in the path, or CloudFront will not invalidate the old version of the updated object.</param>
        /// <param name="callerReference">A unique name that ensures the request can't be replayed. If the CallerReference is new (no matter the content of the Path object), a new distribution is created. If the CallerReference is a value you already sent in a previous request to create an invalidation batch, and the content of each Path element is identical to the original request, the response includes the same information returned to the original request. If the CallerReference is a value you already sent in a previous request to create a distribution but the content of any Path is different from the original request, CloudFront returns an InvalidationBatchAlreadyExists error.</param>
        public InvalidationBatch(Paths paths, string callerReference)
        {
            _paths = paths;
            _callerReference = callerReference;
        }

        /// <summary>
        /// Instantiates InvalidationBatch with the parameterized properties
        /// </summary>
        /// <param name="callerReference">A unique name that ensures the request can't be replayed. If the CallerReference is new (no matter the content of the Path object), a new distribution is created. If the CallerReference is a value you already sent in a previous request to create an invalidation batch, and the content of each Path element is identical to the original request, the response includes the same information returned to the original request. If the CallerReference is a value you already sent in a previous request to create a distribution but the content of any Path is different from the original request, CloudFront returns an InvalidationBatchAlreadyExists error.</param>
        public InvalidationBatch(string callerReference)
        {
            _callerReference = callerReference;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. A unique name that ensures the request
        /// can't be replayed. If the CallerReference is new (no matter the content of the Path
        /// object), a new distribution is created. If the CallerReference is a value you already
        /// sent in a previous request to create an invalidation batch, and the content of each
        /// Path element is identical to the original request, the response includes the same
        /// information returned to the original request. If the CallerReference is a value you
        /// already sent in a previous request to create a distribution but the content of any
        /// Path is different from the original request, CloudFront returns an InvalidationBatchAlreadyExists
        /// error.
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
        /// Gets and sets the property Paths. The path of the object to invalidate. The path is
        /// relative to the distribution and must begin with a slash (/). You must enclose each
        /// invalidation object with the Path element tags. If the path includes non-ASCII characters
        /// or unsafe characters as defined in RFC 1783 (http://www.ietf.org/rfc/rfc1738.txt),
        /// URL encode those characters. Do not URL encode any other characters in the path, or
        /// CloudFront will not invalidate the old version of the updated object.
        /// </summary>
        public Paths Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null;
        }

    }
}