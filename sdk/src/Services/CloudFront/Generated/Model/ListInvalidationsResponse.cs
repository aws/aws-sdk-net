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
    public partial class ListInvalidationsResponse : AmazonWebServiceResponse
    {
        private InvalidationList _invalidationList;

        /// <summary>
        /// Gets and sets the property InvalidationList. 
        /// <para>
        /// Information about invalidation batches.
        /// </para>
        /// </summary>
        public InvalidationList InvalidationList
        {
            get { return this._invalidationList; }
            set { this._invalidationList = value; }
        }

        // Check to see if InvalidationList property is set
        internal bool IsSetInvalidationList()
        {
            return this._invalidationList != null;
        }

    }
}