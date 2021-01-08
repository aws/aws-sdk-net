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
    /// Container for the parameters to the ResetDistributionCache operation.
    /// Deletes currently cached content from your Amazon Lightsail content delivery network
    /// (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// After resetting the cache, the next time a content request is made, your distribution
    /// pulls, serves, and caches it from the origin.
    /// </para>
    /// </summary>
    public partial class ResetDistributionCacheRequest : AmazonLightsailRequest
    {
        private string _distributionName;

        /// <summary>
        /// Gets and sets the property DistributionName. 
        /// <para>
        /// The name of the distribution for which to reset cache.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>GetDistributions</code> action to get a list of distribution names that
        /// you can specify.
        /// </para>
        /// </summary>
        public string DistributionName
        {
            get { return this._distributionName; }
            set { this._distributionName = value; }
        }

        // Check to see if DistributionName property is set
        internal bool IsSetDistributionName()
        {
            return this._distributionName != null;
        }

    }
}