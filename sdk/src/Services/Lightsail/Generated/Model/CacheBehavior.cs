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
    /// Describes the default cache behavior of an Amazon Lightsail content delivery network
    /// (CDN) distribution.
    /// </summary>
    public partial class CacheBehavior
    {
        private BehaviorEnum _behavior;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The cache behavior of the distribution.
        /// </para>
        ///  
        /// <para>
        /// The following cache behaviors can be specified:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>cache</c> </b> - This option is best for static sites. When specified, your
        /// distribution caches and serves your entire website as static content. This behavior
        /// is ideal for websites with static content that doesn't change depending on who views
        /// it, or for websites that don't use cookies, headers, or query strings to personalize
        /// content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>dont-cache</c> </b> - This option is best for sites that serve a mix of static
        /// and dynamic content. When specified, your distribution caches and serve only the content
        /// that is specified in the distribution's <c>CacheBehaviorPerPath</c> parameter. This
        /// behavior is ideal for websites or web applications that use cookies, headers, and
        /// query strings to personalize content for individual users.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BehaviorEnum Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

    }
}