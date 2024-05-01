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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetBucketBundles operation.
    /// Returns the bundles that you can apply to a Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// The bucket bundle specifies the monthly cost, storage quota, and data transfer quota
    /// for a bucket.
    /// </para>
    ///  
    /// <para>
    /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
    /// action to update the bundle for a bucket.
    /// </para>
    /// </summary>
    public partial class GetBucketBundlesRequest : AmazonLightsailRequest
    {
        private bool? _includeInactive;

        /// <summary>
        /// Gets and sets the property IncludeInactive. 
        /// <para>
        /// A Boolean value that indicates whether to include inactive (unavailable) bundles in
        /// the response of your request.
        /// </para>
        /// </summary>
        public bool? IncludeInactive
        {
            get { return this._includeInactive; }
            set { this._includeInactive = value; }
        }

        // Check to see if IncludeInactive property is set
        internal bool IsSetIncludeInactive()
        {
            return this._includeInactive.HasValue; 
        }

    }
}