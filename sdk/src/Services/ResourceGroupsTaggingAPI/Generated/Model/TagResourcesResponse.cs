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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// This is the response object from the TagResources operation.
    /// </summary>
    public partial class TagResourcesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, FailureInfo> _failedResourcesMap = new Dictionary<string, FailureInfo>();

        /// <summary>
        /// Gets and sets the property FailedResourcesMap. 
        /// <para>
        /// A map containing a key-value pair for each failed item that couldn't be tagged. The
        /// key is the ARN of the failed resource. The value is a <code>FailureInfo</code> object
        /// that contains an error code, a status code, and an error message. If there are no
        /// errors, the <code>FailedResourcesMap</code> is empty.
        /// </para>
        /// </summary>
        public Dictionary<string, FailureInfo> FailedResourcesMap
        {
            get { return this._failedResourcesMap; }
            set { this._failedResourcesMap = value; }
        }

        // Check to see if FailedResourcesMap property is set
        internal bool IsSetFailedResourcesMap()
        {
            return this._failedResourcesMap != null && this._failedResourcesMap.Count > 0; 
        }

    }
}