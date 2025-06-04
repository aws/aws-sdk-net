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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the cache configuration for an Amplify app.
    /// 
    ///  
    /// <para>
    /// For more information about how Amplify applies an optimal cache configuration for
    /// your app based on the type of content that is being served, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/managing-cache-configuration">Managing
    /// cache configuration</a> in the <i>Amplify User guide</i>.
    /// </para>
    /// </summary>
    public partial class CacheConfig
    {
        private CacheConfigType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of cache configuration to use for an Amplify app.
        /// </para>
        ///  
        /// <para>
        /// The <c>AMPLIFY_MANAGED</c> cache configuration automatically applies an optimized
        /// cache configuration for your app based on its platform, routing rules, and rewrite
        /// rules.
        /// </para>
        ///  
        /// <para>
        /// The <c>AMPLIFY_MANAGED_NO_COOKIES</c> cache configuration type is the same as <c>AMPLIFY_MANAGED</c>,
        /// except that it excludes all cookies from the cache key. This is the default setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CacheConfigType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}