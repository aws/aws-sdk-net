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
    /// The returned result of the corresponding request.
    /// </summary>
    public partial class GetInvalidationResponse : AmazonWebServiceResponse
    {
        private Invalidation _invalidation;

        /// <summary>
        /// Gets and sets the property Invalidation. 
        /// <para>
        /// The invalidation's information. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/InvalidationDatatype.html">Invalidation
        /// Complex Type</a>.
        /// </para>
        /// </summary>
        public Invalidation Invalidation
        {
            get { return this._invalidation; }
            set { this._invalidation = value; }
        }

        // Check to see if Invalidation property is set
        internal bool IsSetInvalidation()
        {
            return this._invalidation != null;
        }

    }
}