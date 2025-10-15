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
    /// Describes the cross-origin resource sharing (CORS) configuration for a Lightsail bucket.
    /// CORS defines a way for client web applications that are loaded in one domain to interact
    /// with resources in a different domain. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/configure-cors.html">Configuring
    /// cross-origin resource sharing (CORS)</a>.
    /// </summary>
    public partial class BucketCorsConfig
    {
        private List<BucketCorsRule> _rules = AWSConfigs.InitializeCollections ? new List<BucketCorsRule>() : null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// A set of origins and methods (cross-origin access that you want to allow). You can
        /// add up to 20 rules to the configuration. The total size is limited to 64 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<BucketCorsRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}