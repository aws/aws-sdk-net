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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetBucketAccessKeys operation.
    /// </summary>
    public partial class GetBucketAccessKeysResponse : AmazonWebServiceResponse
    {
        private List<AccessKey> _accessKeys = new List<AccessKey>();

        /// <summary>
        /// Gets and sets the property AccessKeys. 
        /// <para>
        /// An object that describes the access keys for the specified bucket.
        /// </para>
        /// </summary>
        public List<AccessKey> AccessKeys
        {
            get { return this._accessKeys; }
            set { this._accessKeys = value; }
        }

        // Check to see if AccessKeys property is set
        internal bool IsSetAccessKeys()
        {
            return this._accessKeys != null && this._accessKeys.Count > 0; 
        }

    }
}