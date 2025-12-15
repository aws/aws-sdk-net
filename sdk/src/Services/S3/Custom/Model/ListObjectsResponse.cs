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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListObjects response and response metadata.
    /// </summary>
    public partial class ListObjectsResponse : AmazonWebServiceResponse
    {
        private string NextMarkerCustomGetter()
        {
            // If the list is truncated and there is at least
            // one object in the list returned and nextMarker
            // has not been populated with a value, use the
            // last returned Key as the default value.
            if (String.IsNullOrEmpty(_nextMarker) &&
                _isTruncated.GetValueOrDefault() &&
                (this.S3Objects?.Count > 0))
            {
                int lastObjIdx = this.S3Objects.Count - 1;
                _nextMarker = this.S3Objects[lastObjIdx].Key;
            }

            return this._nextMarker;
        }
    }
}
    
